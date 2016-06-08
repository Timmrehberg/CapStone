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

namespace CapstoneRemastered.Controllers
{
    public class ExportHoursToExcelController : Controller
    {
        // GET: ExportHoursToExcel
        public ActionResult Index()
        {
            string constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);
            string query = "select * From HourBreakdowns";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            IList<HourBreakdown> model = new List<HourBreakdown>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                model.Add(new HourBreakdown()
                {
                    Driver = dt.Rows[i]["Driver"].ToString(),
                    Hoursworked = Convert.ToInt32(dt.Rows[i]["Hoursworked"]),
                    VehicleNumbers = dt.Rows[i]["Owner"].ToString(),
                    Signature = dt.Rows[i]["State"].ToString(),
                    CoDriver = dt.Rows[i]["CoDriver"].ToString(),
                    OnDutyHours = dt.Rows[i]["OnDutyHours"].ToString(),
                    OffDutyHours = dt.Rows[i]["OffDutyHours"].ToString(),
                    OnDutyHours2 = dt.Rows[i]["OnDutyHours2"].ToString(),
                    OffDutyHours2 = dt.Rows[i]["OffDutyHours2"].ToString(),
                    OnDutyHours3 = dt.Rows[i]["OnDutyHours3"].ToString(),
                    OffDutyHours3 = dt.Rows[i]["OffDutyHours3"].ToString(),
                    TotalHours = dt.Rows[i]["TotalHours"].ToString(),
    });
            }
            return View(model);
        }
        public ActionResult ExportData()
        {
            String constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);
            string query = "select * From HourBreakdowns";
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
                Response.AddHeader("content-disposition", "attachment;filename= HourBreakdown.xlsx");

                using (MemoryStream MyMemoryStream = new MemoryStream())
                {
                    wb.SaveAs(MyMemoryStream);
                    MyMemoryStream.WriteTo(Response.OutputStream);
                    Response.Flush();
                    Response.End();
                }
            }

            return RedirectToAction("Index", "ExportHoursToExcel");
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
