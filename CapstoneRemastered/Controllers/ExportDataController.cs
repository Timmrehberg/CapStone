using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapstoneRemastered.Models;
using ClosedXML;
using ClosedXML.Excel;
using System.IO;

namespace ExportDataTableToExcelInMVC4.Controllers
{
    public class ExportDataController : Controller
    {
        public ActionResult Index()
        {
            string constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);
            string query = "select * From DailyLogMileageAndFuelReports";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            IList<DailyLogMileageAndFuelReport> model = new List<DailyLogMileageAndFuelReport>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                model.Add(new DailyLogMileageAndFuelReport()
                {
                    Driver = dt.Rows[i]["Driver"].ToString(),
                    DateofWork = dt.Rows[i]["DateofWork"].ToString(),
                    Owner = dt.Rows[i]["Owner"].ToString(),
                    State = dt.Rows[i]["State"].ToString(),
                    Routestraveled = dt.Rows[i]["Routestraveled"].ToString(),
                    Totalgaspurchased = Convert.ToDouble(dt.Rows[i]["Totalgaspurchased"]),
                    Totalmilesdriven = Convert.ToInt32(dt.Rows[i]["Totalmilesdriven"]),
                    Tractornumber = Convert.ToInt32(dt.Rows[i]["Tractornumber"]),
                    Trailernumber = Convert.ToInt32(dt.Rows[i]["Trailernumber"]),
                    Pronumber = Convert.ToInt32(dt.Rows[i]["Pronumber"]),
                    Odometerstart = Convert.ToInt32(dt.Rows[i]["Odometerstart"]),
                    Odometerfinish = Convert.ToInt32(dt.Rows[i]["Odometerfinish"]),
                    




                });
            }
             return View(model);
        }

        public ActionResult ExportData()
        {
            String constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);
            string query = "select * From DailyLogMileageAndFuelReports";
            DataTable dt = new DataTable();
            dt.TableName = "Log";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                wb.Style.Font.Bold = true;

                Response.Clear();
                Response.Buffer = true;
                Response.Charset = "";
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment;filename= EmployeeReport.xlsx");

                using (MemoryStream MyMemoryStream = new MemoryStream())
                {
                    wb.SaveAs(MyMemoryStream);
                    MyMemoryStream.WriteTo(Response.OutputStream);
                    Response.Flush();
                    Response.End();
                }
            }

            return RedirectToAction("Index", "ExportData");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
