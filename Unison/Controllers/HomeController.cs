using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Unison.Models;

namespace Unison.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                //string SMTP = "smtp.office365.com";
                //int PORT = 587;
                //string Sender_Name = "test.smtp@unisonuae.com";
                //string Sender_Email_Id = "test.smtp@unisonuae.com";
                //string Email_Password = "bfsgcbnlgmtdhtwd";
                //string Email_Address = "test.smtp@unisonuae.com";

                //MailMessage mail = new MailMessage();
                //SmtpClient SmtpServer = new SmtpClient(SMTP);
                ////SmtpServer.UseDefaultCredentials = false;
                ////ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //SmtpServer.Port = PORT;
                //mail.From = new MailAddress(Sender_Email_Id, Sender_Name);
                //mail.CC.Add("dinesh.mv@imperiumapp.com");
                //mail.To.Add("ramnarayanan@imperiumapp.com");
                //mail.Subject = "Test";
                //mail.Body = "Test";
                //SmtpServer.Credentials = new System.Net.NetworkCredential(Email_Address, Email_Password);
                //SmtpServer.EnableSsl = true;
                //SmtpServer.Send(mail);
                //return "MAIL SEND";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

            return View();
        }

        public ActionResult Dashboard()
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
        public string Login(string UserName,string Password)
        {
            var UserObj = Load_User_Master(UserName, Password);
            if (UserObj.Count() != 0)
            {
                System.Web.HttpContext.Current.Session["UserName"] = UserName;
                System.Web.HttpContext.Current.Session["User_Id"] = UserObj.ElementAt(0).User_Id;
                System.Web.HttpContext.Current.Session["User_Email_Id"] = UserObj.ElementAt(0).User_Email_Id;
                System.Web.HttpContext.Current.Session["Role"] = UserObj.ElementAt(0).Role;
                if (UserObj.ElementAt(0).Role != null)
                {
                    if (UserObj.ElementAt(0).Role.ToLower() == "admin")
                    {
                        return "Home/Dashboard";
                    }
                    else if((UserObj.ElementAt(0).Role.ToLower() == "user"))
                    {
                        return "Master/IncidentMgmt";
                    }
                    else
                    {
                        return "Master/AssetMgmt";
                    }
                }
                else
                {
                    return "Home/Dashboard";
                }
               
            }
            else
            {
                return null;
            }
           
        }
        public List<User_Master> Load_User_Master(string User_Name ,string Password)
        {
            try
            {
                List<User_Master> lst = new List<User_Master>();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@UserName", User_Name);
                    p.Add("@Password", Password);
                    lst = db.Query<User_Master>("SP_Load_User_Master_Login",p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Dashboard_I()
        {
            try
            {
                List<Dashboard> lst = new List<Dashboard>();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    //DynamicParameters p = new DynamicParameters();
                   
                    lst = db.Query<Dashboard>("SP_Dashboard", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Dashboard_1()
        {
            try
            {
                List<Dashboard_1> lst = new List<Dashboard_1>();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    //DynamicParameters p = new DynamicParameters();

                    lst = db.Query<Dashboard_1>("SP_Dashboard_1", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Dashboard_2()
        {
            try
            {
                List<Dashboard_2> lst = new List<Dashboard_2>();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    //DynamicParameters p = new DynamicParameters();

                    lst = db.Query<Dashboard_2>("SP_Dashboard_2", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Dashboard_3()
        {
            try
            {
                List<Dashboard_3> lst = new List<Dashboard_3>();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    //DynamicParameters p = new DynamicParameters();

                    lst = db.Query<Dashboard_3>("SP_Dashboard_3", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Dashboard_4()
        {
            try
            {
                List<Dashboard_4> lst = new List<Dashboard_4>();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    //DynamicParameters p = new DynamicParameters();

                    lst = db.Query<Dashboard_4>("SP_Dashboard_4", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Dashboard_5()
        {
            try
            {
                List<Dashboard_5> lst = new List<Dashboard_5>();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    //DynamicParameters p = new DynamicParameters();

                    lst = db.Query<Dashboard_5>("SP_Dashboard_5", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public ActionResult ChangePassword()
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
        public string ChangePassword_M(string CPWD)
        {
            try
            {
                var User_ID = System.Web.HttpContext.Current.Session["User_Id"];
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@CPWD", CPWD);
                    p.Add("@User_ID", User_ID);
                    db.Query<int>("SP_CHANGEPASSWORD",p, commandTimeout: 60, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }

                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public JsonResult Dashboard_6(string DT,string TYPE)
        {
            try
            {
                List<Dashboard_6> lst = new List<Dashboard_6>();

                if (DT == "TODAY")
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                    {
                        DynamicParameters p = new DynamicParameters();
                        p.Add("@TYPE", TYPE);
                        lst = db.Query<Dashboard_6>("SP_Dashboard_All_TODAY", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                    }
                }
                else if (DT == "WEEK")
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                    {
                        DynamicParameters p = new DynamicParameters();
                        p.Add("@TYPE", TYPE);
                        lst = db.Query<Dashboard_6>("SP_Dashboard_All_WEEK", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                    }
                }
                else if (DT == "MONTH")
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                    {
                        DynamicParameters p = new DynamicParameters();
                        p.Add("@TYPE", TYPE);
                        lst = db.Query<Dashboard_6>("SP_Dashboard_All_MONTH", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                    }
                }
                else
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                    {
                        DynamicParameters p = new DynamicParameters();
                        p.Add("@TYPE", TYPE);
                        lst = db.Query<Dashboard_6>("SP_Dashboard_All_TODAY", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                    }
                }


                

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}