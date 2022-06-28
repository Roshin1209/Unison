using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unison.Models;

namespace Unison.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {

            if (System.Web.HttpContext.Current.Session["User_Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult PMReport()
        {

            if (System.Web.HttpContext.Current.Session["User_Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public JsonResult CASE_Report(string Hospital_Name,string Assignee,string Manufacturer,string Asset_Id ,string ServiceProvider,
            string ProbCate ,string Status ,string AssetName,string FromDate,string EndDate)
        {
            try
            {
                List<Report1> lst = new List<Report1>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Hospital_Name", Hospital_Name);
                    p.Add("@Assignee", Assignee);
                    p.Add("@Manufacturer", Manufacturer);
                    p.Add("@Asset_Id", Asset_Id);
                    p.Add("@ServiceProvider", ServiceProvider);
                    p.Add("@ProbCate", ProbCate);
                    p.Add("@Status", Status);
                    p.Add("@AssetName", AssetName);
                    p.Add("@FromDate", FromDate);
                    p.Add("@EndDate", EndDate);
                    lst = db.Query<Report1>("Report1", p,commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult PM_Report(string Hospital_Name, string FDate,string EDate)
        {
            try
            {
                List<Report2> lst = new List<Report2>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Hospital_Name", Hospital_Name);
                    p.Add("@FromDate", FDate);
                    p.Add("@EndDate", EDate);
                    lst = db.Query<Report2>("Report2", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string GetUserId()
        {
            if (System.Web.HttpContext.Current.Session["User_Id"] != null)
            {
                return System.Web.HttpContext.Current.Session["User_Id"].ToString();
            }
            else
            {
                return "0";
            }
        }
    }
}