using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using Unison.Models;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Net;

namespace Unison.Controllers
{
    public class MasterController : Controller
    {
        string DBCONFIG = "";
        // GET: Master
        public ActionResult HospitalList()
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
        public ActionResult Requestor()
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
        public ActionResult ServiceProvider()
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
        public ActionResult Manufacturer()
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
        public ActionResult Assignee()
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
        public new ActionResult User()
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
        public ActionResult AssetMgmt()
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
        public ActionResult IncidentMgmt()
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
        public ActionResult ProblemCategory()
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
        public ActionResult StatusMaster()
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
        public ActionResult RootCauseMaster()
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
        public ActionResult EmailSettingMaster()
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
        public ActionResult lablePrint()
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
        public string SaveProblemCategory(string Problem_Categroy, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@CAT_Name", Problem_Categroy);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_Problem_Category", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                return "ERROR:" + ex.InnerException;
            }
        }
        public JsonResult LoadProblemCategory()
        {
            try
            {
                List<Problem_Category> lst = new List<Problem_Category>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Problem_Category>("SP_Load_Problem_Category", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveStatusMaster(string Status_Name, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Status_Name", Status_Name);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_Status_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                return "ERROR:" + ex.InnerException;
            }
        }
        public string SaveRootCauseMaster(string Root_Cause, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Root_Cause", Root_Cause);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_Root_Cause_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                return "ERROR:" + ex.InnerException;
            }
        }
        public JsonResult LoadRootCasueMaster()
        {
            try
            {
                List<RootCause_Master> lst = new List<RootCause_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<RootCause_Master>("SP_Load_RootCause_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult LoadstatusMaster()
        {
            try
            {
                List<Status_Master> lst = new List<Status_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Status_Master>("SP_Load_Status_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveHospitalMaster(string HospitalName, string EmailId, string ContactNumber, string Location, string PostalCode, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@HospitalName", HospitalName);
                    p.Add("@EmailId", EmailId);
                    p.Add("@ContactNumber", ContactNumber);
                    p.Add("@Location", Location);
                    p.Add("@PostalCode", PostalCode);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_Hospital_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult LoadHospitalMaster()
        {
            try
            {
                List<Hospital_Master> lst = new List<Hospital_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Hospital_Master>("SP_Load_Hospital_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveManufacturerMaster(string Manufacturer_Name, string EmailId, string ContactNumber, string Location, string E_Contact_Person, string Id, string EPersonName)
        {
            try
            {

                string Status = "SUCCESS";
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Manufacturer_Name", Manufacturer_Name);
                    p.Add("@EmailId", EmailId);
                    p.Add("@ContactNumber", ContactNumber);
                    p.Add("@Location", Location);
                    p.Add("@E_Contact_Person", E_Contact_Person);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    p.Add("@EPersonName", EPersonName);
                    Status = db.Query<string>("SP_Insert_Manufacturer_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
                return Status + ":";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult LoadManufacturerMaster()
        {
            try
            {
                List<Manufacturer_Master> lst = new List<Manufacturer_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Manufacturer_Master>("SP_Load_Manufacturer_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveServiceProviderMaster(string ServiceProvider_Name, string EmailId, string ContactNumber, string Location, string E_Contact_Person, string Id, string ECName, string ECNumber)
        {
            try
            {
                string Status = "SUCCESS";
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@ServiceProvider_Name", ServiceProvider_Name);
                    p.Add("@EmailId", EmailId);
                    p.Add("@ContactNumber", ContactNumber);
                    p.Add("@Location", Location);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    p.Add("@ECName", ECName);
                    p.Add("@ECNumber", ECNumber);
                    Status = db.Query<string>("SP_Insert_ServiceProvider_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
                return Status + ":";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult LoadServiceProviderMaster()
        {
            try
            {
                List<ServiceProvider_Master> lst = new List<ServiceProvider_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<ServiceProvider_Master>("SP_Load_ServiceProvider_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveAssigneeMaster(string AssigneeName, string EmailId, string ContactNumber, string Location, string JobTitle, string ServiceProvider, string Manufaturer, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@AssigneeName", AssigneeName);
                    p.Add("@EmailId", EmailId);
                    p.Add("@ContactNumber", ContactNumber);
                    p.Add("@Location", Location);
                    p.Add("@JobTitle", JobTitle);
                    p.Add("@ServiceProvider", ServiceProvider);
                    p.Add("@Manufaturer", Manufaturer);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_Assignee_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult Load_Assignee_Master()
        {
            try
            {
                List<Assignee_Master> lst = new List<Assignee_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Assignee_Master>("SP_Load_Assignee_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveEmailSettings(string SenderName, string EmailId, string Password, string PORT, string SMTP, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@SenderName", SenderName);
                    p.Add("@EmailId", EmailId);
                    p.Add("@Password", Password);
                    p.Add("@PORT", PORT);
                    p.Add("@SMTP", SMTP);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_Email_Settings", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult Load_Email_Setting()
        {
            try
            {
                List<Email_Settings> lst = new List<Email_Settings>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Email_Settings>("SP_Load_Email_Settings", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string Save_User_Master(string UserName, string EmailId, string ContactNumber, string Role, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@UserName", UserName);
                    p.Add("@EmailId", EmailId);
                    p.Add("@ContactNumber", ContactNumber);
                    p.Add("@Role", Role);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_User_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult Load_User_Master()
        {
            try
            {
                List<User_Master> lst = new List<User_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<User_Master>("SP_Load_User_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string SaveAssetMaster(string Maufacturer, string serviceProvider, string AssetName, string AssetDescription,
            string SerialNumber, string InstallationDate, string SystemId, string LastPMDate, string PMSpecs, string ServiceContraactDate, string Id
            , string Hospital_Id, string ContractType, string ServiceContraactEndDate, string NextPMDate
            , string AE_TITLE, string IP_Address, int PORT, string DWML, string DICOM,string SysLoc,string SysComments,string Category)
        {
            try
            {
                int Asset_id = 0;
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Maufacturer", Maufacturer);
                    p.Add("@serviceProvider", serviceProvider);
                    p.Add("@AssetName", AssetName);
                    p.Add("@AssetDescription", AssetDescription);
                    p.Add("@SerialNumber", SerialNumber);
                    p.Add("@InstallationDate", InstallationDate);
                    p.Add("@SystemId", SystemId);
                    p.Add("@LastPMDate", LastPMDate);
                    p.Add("@PMSpecs", PMSpecs);
                    p.Add("@ServiceContraactDate", ServiceContraactDate);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    p.Add("@Hospital_Id", Hospital_Id);
                    p.Add("@ContractType", ContractType);
                    p.Add("@ServiceContraactEndDate", ServiceContraactEndDate);
                    p.Add("@NextPMDate", NextPMDate);
                    p.Add("@Category", Category);
                    p.Add("@AE_TITLE", AE_TITLE);
                    p.Add("@IP_Address", IP_Address);
                    p.Add("@PORT", PORT);
                    p.Add("@DWML", DWML);
                    p.Add("@DICOM", DICOM);
                    p.Add("@SysLoc", SysLoc);
                    p.Add("@SysComments", SysComments);
                    Asset_id=db.Query<int>("SP_Insert_Asset_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
                return "SUCCESS:" + Asset_id;
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult Load_Asset_Master()
        {
            try
            {
                List<Assets_Master> lst = new List<Assets_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Assets_Master>("SP_Load_Asset_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string SaveRequestorMaster(string RequestorName, string EmailId, string ContactNumber, string JobTitle,
           string Address, string HospitalName, string UnisonId, string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@RequestorName", RequestorName);
                    p.Add("@EmailId", EmailId);
                    p.Add("@ContactNumber", ContactNumber);
                    p.Add("@JobTitle", JobTitle);
                    p.Add("@Address", Address);
                    p.Add("@HospitalName", HospitalName);
                    p.Add("@UnisonId", UnisonId);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    db.Query<int>("SP_Insert_Requestor_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult Load_requestor_Master()
        {
            try
            {
                List<Requestor_Master> lst = new List<Requestor_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Requestor_Master>("SP_Load_Requestor_Master", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string SaveIncidetMaster(string Requestor, string Hospital, string ProblemCategory, string Assets,
          string ProblemDescription, string Assignee, string Status, string Priority, string Comments, string Solutions,
          string Root, string RootDescription, string DueDate, string Id, string Manufacturer, string Service_Provider,string Cost,string OpenDate)
        {
            string InsertReocrdStatus = "ERROR";
            string DBConfig = ConfigurationManager.AppSettings["DBConfig"].ToString();
            string Ticket_Subject = "Unison Capital Investment";
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                int caseid = 0;


                //Whenever the ticket is edited, assignee is getting notification this has to be avoided.  Only when the change in assignee, notification to be done.
                //ITs only for update mode.
                List<AssigneeEmail> Flst = new List<AssigneeEmail>();
                using (IDbConnection db = new SqlConnection(DBConfig))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Id", Id);
                    Flst = db.Query<AssigneeEmail>("SP_Load_AssigneeDetail_ById", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                var names = new List<string>();
                for (int n=0;n<Flst.Count;n++)
                {
                    names.Add(Flst.ElementAt(n).Assignee_Name);
                }
                var name1 = string.Join(",", names);


                using (IDbConnection db = new SqlConnection(DBConfig))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Requestor", Requestor);
                    p.Add("@Hospital", Hospital);
                    p.Add("@ProblemCategory", ProblemCategory);
                    p.Add("@Assets", Assets);
                    p.Add("@ProblemDescription", ProblemDescription);
                    p.Add("@Assignee", Assignee);
                    p.Add("@Status", Status);
                    p.Add("@Priority", Priority);
                    p.Add("@Comments", Comments);
                    p.Add("@Solutions", Solutions);
                    p.Add("@Root", Root);
                    p.Add("@RootDescription", RootDescription);
                    p.Add("@DueDate", DueDate);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    p.Add("@Id", Id);
                    p.Add("@Manufacturer", Manufacturer);
                    p.Add("@Service_Provider", Service_Provider);
                    p.Add("@Cost", Cost);
                    p.Add("@OpenDate", OpenDate);
                    caseid = db.Query<int>("SP_Insert_Incident_Master", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).FirstOrDefault(); 
                    InsertReocrdStatus = "SUCCESS";
                }
                //Get Assignee Details from Id 
                //Get Ticket Details and Other Things for sending mail
                if (InsertReocrdStatus == "SUCCESS")
                {
                    //Assignee
                    List<AssigneeEmail> lst = new List<AssigneeEmail>();
                    using (IDbConnection db = new SqlConnection(DBConfig))
                    {
                        DynamicParameters p = new DynamicParameters();
                        p.Add("@Id", caseid);
                        lst = db.Query<AssigneeEmail>("SP_Load_AssigneeDetail_ById", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                    }
                    //-------------------------------------------
                    List<Incident_Master_Email> rlst = new List<Incident_Master_Email>();
                    using (IDbConnection db = new SqlConnection(DBConfig))
                    {
                        DynamicParameters p = new DynamicParameters();
                        p.Add("@Id", caseid);
                        rlst = db.Query<Incident_Master_Email>("SP_Load_Incident_Email", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                    }
                    //-----------------------------------------
                    StringBuilder Msg = new StringBuilder();
                    if (Id == "0")
                    {
                        var filePath = Server.MapPath("~/Content/Emails/eMailTemplate_AssignTicket.txt");
                        //INSERT INSIDENT 
                        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                        {
                            Msg.Append(streamReader.ReadToEnd());
                        }
                        string AssigneeName = "";
                        string AssigneeEmailId = "";
                        var AssigneeEmailList = new List<string>();
                        if (lst.Count() != 0)
                        {
                            for (int l = 0; l < lst.Count; l++)
                            {
                                AssigneeName = lst.ElementAt(l).Assignee_Name;
                                AssigneeEmailId = lst.ElementAt(l).Email_Id;
                                AssigneeEmailList.Add(lst.ElementAt(l).Email_Id);

                            }
                            var AssigneeEmailId1 = string.Join(",", AssigneeEmailList);
                            //string s = newone.ToString();
                            if (rlst.Count() != 0)
                                {
                                if (lst.Count > 1)
                                {
                                    Msg.Replace("{Assignee_Name}", "Team");
                                }
                                else
                                {
                                    Msg.Replace("{Assignee_Name}", AssigneeName);
                                }
                                   
                                    Msg.Replace("{SR_Number}", rlst.ElementAt(0).Ticket_Id);
                                    Msg.Replace("{Asset_ID}", rlst.ElementAt(0).Assets_Id);
                                    Msg.Replace("{Hospital_Name}", rlst.ElementAt(0).Hospital_Name);
                                    Msg.Replace("{Manufacturer}", rlst.ElementAt(0).Manufacturer_Name);
                                    Msg.Replace("{Asset_Name}", rlst.ElementAt(0).Asset_Name);
                                    Msg.Replace("{Asset_Description}", rlst.ElementAt(0).Asset_Description);
                                    Msg.Replace("{Serial_Number}", rlst.ElementAt(0).SerialNumber);
                                    Msg.Replace("{Contract_Type}", rlst.ElementAt(0).ContractType);
                                    Msg.Replace("{Priority}", rlst.ElementAt(0).Priority);
                                    Msg.Replace("{Problem description}", ProblemDescription);
                                    Msg.Replace("{Requestor_Name}", rlst.ElementAt(0).RequestorName);
                                    Msg.Replace("{Phone_Number}", rlst.ElementAt(0).Contact_Number);
                                    Msg.Replace("{Email_Id}", rlst.ElementAt(0).Email_Id);
                                    Msg.Replace("{Requestor_Id}", rlst.ElementAt(0).Req_Id);
                                }
                                //}
                                // }

                                string sub_Ass = rlst.ElementAt(0).Ticket_Id + "-" + rlst.ElementAt(0).Hospital_Name + "-" + rlst.ElementAt(0).Manufacturer_Name + "-" + rlst.ElementAt(0).Asset_Name + "-" + rlst.ElementAt(0).Asset_Description + "-" + rlst.ElementAt(0).SerialNumber;

                                if (string.IsNullOrEmpty(AssigneeEmailId1) != true)
                                {
                                    SendMail(sub_Ass, Msg.ToString(), AssigneeEmailId1);
                                }
                            //}
                        }
                        #region RequestorStatusMessage
                        if (rlst.ElementAt(0).Status_Name == "Open")
                        {
                            var fPath = Server.MapPath("~/Content/Emails/eMailTemplate_Ticket_Open.txt");
                            var f1 = new FileStream(fPath, FileMode.Open, FileAccess.Read);
                            StringBuilder New_Open_Message = new StringBuilder();
                            using (var streamReader = new StreamReader(f1, Encoding.UTF8))
                            {
                                New_Open_Message.Append(streamReader.ReadToEnd());
                            }
                            New_Open_Message.Replace("{SR_Number}", rlst.ElementAt(0).Ticket_Id);
                            New_Open_Message.Replace("{Requestor_Name}", rlst.ElementAt(0).RequestorName);
                            string sub = Ticket_Subject + rlst.ElementAt(0).Ticket_Id + "-" + rlst.ElementAt(0).Hospital_Name + "-" + rlst.ElementAt(0).Status_Name;

                            SendMail(sub, New_Open_Message.ToString(), rlst.ElementAt(0).Email_Id);
                        }
                        if (rlst.ElementAt(0).Status_Name == "Closed")
                        {
                            var fPath = Server.MapPath("~/Content/Emails/eMailTemplate_Ticket_Closed.txt");
                            var f1 = new FileStream(fPath, FileMode.Open, FileAccess.Read);
                            StringBuilder New_Closed_Message = new StringBuilder();
                            using (var streamReader = new StreamReader(f1, Encoding.UTF8))
                            {
                                New_Closed_Message.Append(streamReader.ReadToEnd());
                            }
                            New_Closed_Message.Replace("{Requestor_Name}", rlst.ElementAt(0).RequestorName);
                            string sub = Ticket_Subject + rlst.ElementAt(0).Ticket_Id + "-" + rlst.ElementAt(0).Hospital_Name + "-" + rlst.ElementAt(0).Status_Name;
                            SendMail(sub, New_Closed_Message.ToString(), rlst.ElementAt(0).Email_Id);
                        }
                        #endregion RequestorStatusMessage
                    }
                    else
                    {
                        /// Mode of Edit update mail needs to send to Assignee and status mail send to requestor  only for open and closed status //22-May-2019
                        #region AssigneeMail
                        //Assignee
                        List<AssigneeEmail> lst1 = new List<AssigneeEmail>();
                        using (IDbConnection db = new SqlConnection(DBConfig))
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@Id", caseid);
                            lst1 = db.Query<AssigneeEmail>("SP_Load_AssigneeDetail_ById", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                        }
                        //-------------------------------------------
                        List<Incident_Master_Email> rlst1 = new List<Incident_Master_Email>();
                        using (IDbConnection db = new SqlConnection(DBConfig))
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@Id", caseid);
                            rlst1 = db.Query<Incident_Master_Email>("SP_Load_Incident_Email", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                        }
                        //-----------------------------------------
                        StringBuilder Msg1 = new StringBuilder();
                        var filePath = Server.MapPath("~/Content/Emails/eMailTemplate_AssignTicket.txt");
                        //INSERT INSIDENT 
                        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                        {
                            Msg1.Append(streamReader.ReadToEnd());
                        }
                        string AssigneeName = "";
                        string AssigneeEmailId = "";
                        var AssigneeEmailList = new List<string>();
                        var AssigneeNameList = new List<string>();
                        if (lst1.Count() != 0)
                        {
                            for (int k = 0; k < lst1.Count; k++)
                            {
                                AssigneeName = lst1.ElementAt(k).Assignee_Name;
                                AssigneeEmailId = lst1.ElementAt(k).Email_Id;
                                AssigneeEmailList.Add(lst1.ElementAt(k).Email_Id);
                                AssigneeNameList.Add(lst1.ElementAt(k).Assignee_Name);

                            }
                            var AssigneeEmailId1 = string.Join(",", AssigneeEmailList);
                            var AssigneeName1= string.Join(",", AssigneeNameList);

                            if (rlst1.Count() != 0)
                            {
                                if (lst1.Count > 1)
                                {
                                    Msg1.Replace("{Assignee_Name}", "Team");
                                }
                                else
                                {
                                    Msg1.Replace("{Assignee_Name}", AssigneeName);
                                }
                                Msg1.Replace("{SR_Number}", rlst1.ElementAt(0).Ticket_Id);
                                Msg1.Replace("{Asset_ID}", rlst1.ElementAt(0).Assets_Id);
                                Msg1.Replace("{Hospital_Name}", rlst1.ElementAt(0).Hospital_Name);
                                Msg1.Replace("{Manufacturer}", rlst1.ElementAt(0).Manufacturer_Name);
                                Msg1.Replace("{Asset_Name}", rlst1.ElementAt(0).Asset_Name);
                                Msg1.Replace("{Asset_Description}", rlst1.ElementAt(0).Asset_Description);
                                Msg1.Replace("{Serial_Number}", rlst1.ElementAt(0).SerialNumber);
                                Msg1.Replace("{Contract_Type}", rlst1.ElementAt(0).ContractType);
                                Msg1.Replace("{Priority}", rlst1.ElementAt(0).Priority);
                                Msg1.Replace("{Problem description}", ProblemDescription);
                                Msg1.Replace("{Requestor_Name}", rlst1.ElementAt(0).RequestorName);
                                Msg1.Replace("{Phone_Number}", rlst1.ElementAt(0).Contact_Number);
                                Msg1.Replace("{Email_Id}", rlst1.ElementAt(0).Email_Id);
                                Msg1.Replace("{Requestor_Id}", rlst1.ElementAt(0).Req_Id);


                                string sub_Ass = rlst1.ElementAt(0).Ticket_Id + "-" + rlst1.ElementAt(0).Hospital_Name + "-" + rlst1.ElementAt(0).Manufacturer_Name + "-" + rlst1.ElementAt(0).Asset_Name + "-" + rlst1.ElementAt(0).Asset_Description + "-" + rlst1.ElementAt(0).SerialNumber;

                                //The following Code works only Edit mode if the If the assignee Changed then only mail will goo .
                                //Whenever the ticket is edited, assignee is getting notification this has to be avoided.  Only when the change in assignee, notification to be done. [ SUB: Product design Meeting - Unison   Date: 26 May 2019 === Check the mail]
                                if (Flst.ElementAt(0).Assignee_Name != AssigneeName && name1 != AssigneeName1)
                                {
                                    if (string.IsNullOrEmpty(AssigneeEmailId1) != true)
                                    {
                                        SendMail(sub_Ass, Msg1.ToString(), AssigneeEmailId1);
                                    }
                                }
                            }
                        }
                        

                        #endregion AssigneeMail

                        ////
                        #region RequestorStatusMessage
                        if (rlst.ElementAt(0).Status_Name == "Open")
                        {
                            var fPath = Server.MapPath("~/Content/Emails/eMailTemplate_Ticket_Open.txt");
                            var f1 = new FileStream(fPath, FileMode.Open, FileAccess.Read);
                            StringBuilder New_Open_Message = new StringBuilder();
                            using (var streamReader = new StreamReader(f1, Encoding.UTF8))
                            {
                                New_Open_Message.Append(streamReader.ReadToEnd());
                            }
                            New_Open_Message.Replace("{SR_Number}", rlst.ElementAt(0).Ticket_Id);
                            New_Open_Message.Replace("{Requestor_Name}", rlst.ElementAt(0).RequestorName);
                            string sub = Ticket_Subject + rlst.ElementAt(0).Ticket_Id + "-" + rlst.ElementAt(0).Hospital_Name + "-" + rlst.ElementAt(0).Status_Name;

                            SendMail(sub, New_Open_Message.ToString(), rlst.ElementAt(0).Email_Id);
                        }
                        if (rlst.ElementAt(0).Status_Name == "Closed")
                        {
                            var fPath = Server.MapPath("~/Content/Emails/eMailTemplate_Ticket_Closed.txt");
                            var f1 = new FileStream(fPath, FileMode.Open, FileAccess.Read);
                            StringBuilder New_Closed_Message = new StringBuilder();
                            using (var streamReader = new StreamReader(f1, Encoding.UTF8))
                            {
                                New_Closed_Message.Append(streamReader.ReadToEnd());
                            }
                            New_Closed_Message.Replace("{Requestor_Name}", rlst.ElementAt(0).RequestorName);
                            string sub = Ticket_Subject + rlst.ElementAt(0).Ticket_Id + "-" + rlst.ElementAt(0).Hospital_Name + "-" + rlst.ElementAt(0).Status_Name;
                            SendMail(sub, New_Closed_Message.ToString(), rlst.ElementAt(0).Email_Id);
                        }
                        #endregion RequestorStatusMessage
                    }
                }

                return "SUCCESS:" + caseid;
            }
            catch (Exception ex)
            {
                //throw null;
                return ex.Message.ToString();
            }
        }

        public JsonResult Load_Incident_Master()
        {
            try
            {
                List<Incident_Master> lst = new List<Incident_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<Incident_Master>("SP_Load_Incident", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
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
        public string SendMail(string Subject, string MailBody, string toaddress)
        {
            try
            {
                var MailSettings = LoadMailSettings_SendMail();
                if (MailSettings.Count() != 0)
                {
                    string SMTP = MailSettings.ElementAt(0).SMTP;
                    int PORT = MailSettings.ElementAt(0).PORT;
                    string Sender_Name = MailSettings.ElementAt(0).Sender_Name;
                    string Sender_Email_Id = MailSettings.ElementAt(0).Sender_Email_Id;
                    string Email_Password = MailSettings.ElementAt(0).Email_Password;
                    string Email_Address = MailSettings.ElementAt(0).Email_Address;

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(SMTP);
                    //SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.UseDefaultCredentials = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                   
                    SmtpServer.Port = PORT;
                    mail.From = new MailAddress(Sender_Email_Id, Sender_Name);
                    mail.CC.Add("servicecenter@unisonuae.com");
                    mail.To.Add(toaddress);
                    mail.Subject = Subject;
                    mail.Body = MailBody;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(Email_Address, Email_Password);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    return "MAIL SEND";

                    //string SMTP = "smtp.office365.com";
                    //int PORT = 587;
                    //string Sender_Name = "dinesh.mv@imperiumapp.com";
                    //string Sender_Email_Id = "dinesh.mv@imperiumapp.com";
                    //string Email_Password = "*****";
                    //string Email_Address = "dinesh.mv@imperiumapp.com";

                    //MailMessage mail = new MailMessage();
                    //SmtpClient SmtpServer = new SmtpClient(SMTP);
                    ////SmtpServer.UseDefaultCredentials = false;
                    ////ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    //SmtpServer.Port = PORT;
                    //mail.From = new MailAddress(Sender_Email_Id, Sender_Name);
                    //mail.CC.Add("chandan@imperiumapp.com");
                    //mail.To.Add("ramnarayanan@imperiumapp.com");
                    //mail.Subject = Subject;
                    //mail.Body = MailBody;
                    //SmtpServer.Credentials = new System.Net.NetworkCredential(Email_Address, Email_Password);
                    //SmtpServer.EnableSsl = true;
                    //SmtpServer.Send(mail);
                    //return "MAIL SEND";
                }
                else
                {
                    return "MAIL SETTING NOT FOUNT";
                }

            }
            catch (Exception ex)
            {
                return "MAIL NOT SENT ERROR";
            }
        }
        public List<MailSettings> LoadMailSettings()
        {
            try
            {
                List<MailSettings> lst = new List<MailSettings>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<MailSettings>("SP_Load_Mail_Settings", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<MailSettings> LoadMailSettings_SendMail()
        {
            try
            {
                List<MailSettings> lst = new List<MailSettings>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {

                    lst = db.Query<MailSettings>("SP_Load_Mail_Settings_SendMail", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SP_Insert_Comment(string Case_Id, string Comments)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Case_Id", Case_Id);
                    p.Add("@Comments", Comments);
                    p.Add("@User_Id", User_Id);
                    p.Add("@Created_Date", System.DateTime.Now.ToString());
                    db.Query<int>("SP_Insert_Comment", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }
        public JsonResult Load_Comments_By_CaseId(string Case_Id)
        {
            try
            {
                List<Comments_Details> lst = new List<Comments_Details>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Case_Id", Case_Id);
                    lst = db.Query<Comments_Details>("SP_Load_Comments_Case_Id", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult LoadAttachments(string Case_Id)
        {
            try
            {
                List<Attachments> lst = new List<Attachments>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Caseid", Case_Id);
                    lst = db.Query<Attachments>("SP_LOAD_Attachments", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult LoadAssetAttachments(string Asset_Id)
        {
            try
            {
                List<AssetAttachments> lst = new List<AssetAttachments>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Assetid", Asset_Id);
                    lst = db.Query<AssetAttachments>("SP_LOAD_Asset_Attachments", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public JsonResult Load_Asset_Master_LabelPrint(string from, string to, string Hospital_Id)
        {
            try
            {
                List<Assets_Master> lst = new List<Assets_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    //p.Add("@From", from);
                    //p.Add("@TO", to);
                    p.Add("@Hospital_Id", Hospital_Id);
                    lst = db.Query<Assets_Master>("SP_Load_Asset_Master_Label_Print", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string Delete_HospitalMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Hospital", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_RequestorMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Requestor", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_ServiceProviderMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_ServiceProvider", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_ManuFacturerMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_ManuFacturer", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_AssigneeMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Assignee", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_AssetMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Asset", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_IncidentMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Incident", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_UserMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_User", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }

        public string Delete_Problem_CatMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_ProblemCateg", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_StatusMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Status", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_RootCauseMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_RootCause", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string Delete_EmailSettingsMaster(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_EmailSettings", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public JsonResult Load_Assignee_Master_Id(string ServiceProvider_Id,string Manufacturer)
        {
            try
            {
                List<Assignee_Master> lst = new List<Assignee_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Id", ServiceProvider_Id);
                    p.Add("@MId", Manufacturer);
                    lst = db.Query<Assignee_Master>("SP_Load_Assignee_Master_Id", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Load_Asset_Master_ById(string Id,string Hospital_Id)
        {
            try
            {
                List<Assets_Master> lst = new List<Assets_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Id", Id);
                    p.Add("@Hospital_Id", Hospital_Id);
                    lst = db.Query<Assets_Master>("SP_Load_Asset_Master_ByManuId", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Load_Asset_Master_ByAssetId(string Id)
        {
            try
            {
                List<Assets_Master> lst = new List<Assets_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Asset_Id", Id);
                    lst = db.Query<Assets_Master>("SP_Load_Asset_Master_ByAssetId", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ActionResult UploadFiles()
        {

            string path = Server.MapPath("~/Content/Upload/") + Request.Form["ID"] + "/";
            if (Directory.Exists(Server.MapPath("~/Content/Upload/" + Request.Form["ID"] + "")))
            {
                HttpFileCollectionBase files = Request.Files;

                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase file = files[i];

                    file.SaveAs(path + file.FileName);


                    //InsertFile(Request.Form["ID"], file.FileName.Replace(".pdf", ""), path);
                    InsertFile(Request.Form["ID"], file.FileName, path);
                }
                if(files.Count!=0)
                { 
                return Json(files.Count + " Files Uploaded!");
                }
                else
                {
                    return Json("Updated Successfuly");
                }
            }
            else
            {
                Directory.CreateDirectory(Server.MapPath("~/Content/Upload/" + Request.Form["ID"] + ""));
                HttpFileCollectionBase files = Request.Files;

                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase file = files[i];
                    file.SaveAs(path + file.FileName);


                    //InsertFile(Request.Form["ID"], file.FileName.Replace(".pdf", ""), path);
                    InsertFile(Request.Form["ID"], file.FileName, path);
                }
                if (files.Count != 0)
                {
                    return Json(files.Count + " Files Uploaded!");
                }
                else
                {
                    return Json("Saved Successfuly");
                }
            }


        }

        public string InsertFile(string Caseid, string Filename, string path)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                string NewFileName = Path.GetFileNameWithoutExtension(Filename);
                FileInfo fi = new FileInfo(Filename);
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    string extn = fi.Extension;
                    string extn1 = extn.Replace(".", "");
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Case_Id", Caseid);
                    p.Add("@File_Name", NewFileName);
                    p.Add("@File_Ext", extn1);
                    p.Add("@Created_By", User_Id);
                    p.Add("@File_Path", path);
                    db.Query<int>("SP_Insert_Files", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }


        public ActionResult UploadAsset()
        {

            string path = Server.MapPath("~/Content/AssetUpload/") + Request.Form["ID"] + "/";
            if (Directory.Exists(Server.MapPath("~/Content/AssetUpload/" + Request.Form["ID"] + "")))
            {
                HttpFileCollectionBase files = Request.Files;

                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase file = files[i];

                    file.SaveAs(path + file.FileName);


                    InsertAsset(Request.Form["ID"], file.FileName, path);
                }
                if (files.Count != 0)
                {
                    return Json(files.Count + " Files Uploaded!");
                }
                else
                {
                    return Json("Updated Successfuly");
                }
            }
            else
            {
                Directory.CreateDirectory(Server.MapPath("~/Content/AssetUpload/" + Request.Form["ID"] + ""));
                HttpFileCollectionBase files = Request.Files;

                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase file = files[i];
                    file.SaveAs(path + file.FileName);


                    InsertAsset(Request.Form["ID"], file.FileName, path);
                }
                if (files.Count != 0)
                {
                    return Json(files.Count + " Files Uploaded!");
                }
                else
                {
                    return Json("Saved Successfuly");
                }
            }
        }
        public string InsertAsset(string Assetid, string Filename, string path)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());
                string NewFileName = Path.GetFileNameWithoutExtension(Filename);
                FileInfo fi = new FileInfo(Filename);
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    string extn = fi.Extension;
                    string extn1 = extn.Replace(".", "");
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Asset_Id", Assetid);
                    p.Add("@File_Name", NewFileName);
                    p.Add("@File_Ext", extn1);
                    p.Add("@Created_By", User_Id);
                    p.Add("@File_Path", path);
                    db.Query<int>("SP_Insert_Assets", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                return "SUCCESS:";
            }
            catch (Exception ex)
            {
                throw null;
            }
        }


        public JsonResult Load_Hospital_BYREQUESTORID(string Requestor_Id)
        {
            try
            {
                List<Hospital_Master> lst = new List<Hospital_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Requestor_Id", Requestor_Id);
                    lst = db.Query<Hospital_Master>("SP_Load_Hospital_Master_BY_Requestor_Id", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Load_Hospital_BY_ASSET_Id(string Asset_Id)
        {
            try
            {
                List<MAN_HSP_Master> lst = new List<MAN_HSP_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Asset_Id", Asset_Id);
                    lst = db.Query<MAN_HSP_Master>("SP_LOAD_MAN_HOSP_BY_ASSETID", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult Load_Incident_Master_UnisonId(string Id)
        {
            try
            {
                List<Incident_Master> lst = new List<Incident_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@UID", Id);
                    lst = db.Query<Incident_Master>("SP_Load_Incident_UID", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string DeleteAsset(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());

                string path = Server.MapPath("~/Content/Upload/") + Id + "/";
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    //p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Attachment", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public string DeleteAssetFile(string Id)
        {
            try
            {
                int User_Id = Convert.ToInt32(GetUserId());

                string path = Server.MapPath("~/Content/AssetUpload/") + Id + "/";
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    //p.Add("@User_Id", User_Id);
                    p.Add("@Id", Id);
                    db.Query<Comments_Details>("SP_Del_Asset_Attachment", p, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                return "Success:";
            }
            catch (Exception ex)
            {
                return "Error:";
            }
        }
        public JsonResult Load_Manufaturer_BYHospitalId(string Hospital_Id)
        {
            try
            {
                List<Manufacturer_Master> lst = new List<Manufacturer_Master>();
                int User_Id = Convert.ToInt32(GetUserId());
                using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["DBConfig"].ToString()))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("Hospital_Id", Hospital_Id);
                    lst = db.Query<Manufacturer_Master>("SP_Load_Manufaturer_BYHospitalId", commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
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