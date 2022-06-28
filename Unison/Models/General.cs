using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unison.Models
{
    public class General
    {

    }
    public class Problem_Category
    {
        public int Id { get; set; }
        public string Category_Name { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }

    }
    public class Status_Master
    {
        public int Id { get; set; }
        public string Status_Name { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }

    }
    public class RootCause_Master
    {
        public int Id { get; set; }
        public string RootCause_Name { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }

    }
    public class Hospital_Master
    {
        public int Hospital_Id { get; set; }
        public string Hospital_Name { get; set; }
        public string Location { get; set; }
        public string Postal_Code { get; set; }
        public string Contact_Number { get; set; }
        public string Email_Id { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }

    }
    public class Manufacturer_Master
    {
        public int Manufacturer_Id { get; set; }
        public string Manufacturer_Name { get; set; }
        public string Location { get; set; }
        public string E_Contact_Person { get; set; }
        public string Contact_Number { get; set; }
        public string Email_Id { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }
        public string EPersonName { get; set; }

    }
    public class ServiceProvider_Master
    {
        public int ServiceProvider_Id { get; set; }
        public string ServiceProvider_Name { get; set; }
        public string Location { get; set; }
        public string Contact_Number { get; set; }
        public string Email_Id { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }
        public string ECName { get; set; }
        public string ECNumber { get; set; }

    }
    public class Assignee_Master
    {
        public int Assignee_Id { get; set; }
        public string Assignee_Name { get; set; }
        public string Location { get; set; }
        public string Contact_Number { get; set; }
        public string JobTitle { get; set; }
        public int ServiceProvider { get; set; }
        public int Manufaturer { get; set; }
        public string Manufacturer_Name { get; set; }
        public string ServiceProvider_Name { get; set; }
        public string Email_Id { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }

    }
    public class Email_Settings
    {
        public int Id { get; set; }
        public string Sender_Name { get; set; }
        public string Sender_Email_Id { get; set; }
        public string Email_Address { get; set; }
        public string Email_Password { get; set; }
        public int PORT { get; set; }
        public int Manufaturer { get; set; }
        public string SMTP { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }

    }
    public class User_Master
    {
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Email_Id { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Contact_Number { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }

    }
    public class Assets_Master
    {
        public int Asset_Id { get; set; }
        public string Asset_Name { get; set; }
        public string Asset_Description { get; set; }
        public string SerialNumber { get; set; }
        public string InstallationDate { get; set; }
        public string SystemId { get; set; }
        public string LastPMDate { get; set; }
        public string PMSpecs { get; set; }
        public string ServiceContraactDate { get; set; }
        public string ServiceProvider_Name { get; set; }
        public string Manufacturer_Name { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public bool Is_Active { get; set; }
        public string Unison_ID { get; set; }
        public string Maufacturer { get; set; }
        public string serviceProvider { get; set; }
        public int Hospital_Id { get; set; }
        public string Hospital_Name { get; set; }
        public string ContractType { get; set; }
        public string ServiceContraactEndDate { get; set; }
        public string NextPMDate { get; set; }
        public string AE_TITLE { get; set; }
        public string IP_ADDRESS { get; set; }
        public int PORT { get; set; }
        public bool DMWL { get; set; }
        public bool Dicom_send { get; set; }
        public string System_Location { get; set; }
        public string System_Comments { get; set; }
        public string Category { get; set; }
    }
    public class Requestor_Master
    {
        public int Id { get; set; }
        public string RequestorName { get; set; }
        public string Email_Id { get; set; }
        public string Contact_Number { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        public string Hospital_Name { get; set; }
        public string UnisonId { get; set; }
        public string Created_Date { get; set; }
        public string Created_By { get; set; }
        public bool Is_Active { get; set; }
        public  string Hospital_Id { get; set; }
    }
    public class AssigneeEmail
    {
        public int Assignee_Id { get; set; }
        public string Email_Id { get; set; }
        public string Assignee_Name { get; set; }
    }
    public class Incident_Master
    {
        public string Ticket_Id { get; set; }
        public int Id { get; set; }
        public string Requestor_Id { get; set; }
        public string Hospital_Id { get; set; }
        public string ProblemCategory_Id { get; set; }
        public string Assets_Id { get; set; }
        public string Assets_Itration_Id { get; set; }
        public string ProblemDescripition { get; set; }
        public string Assignee { get; set; }
        public string Assignee_Name { get; set; }
        public string Contact_Number { get; set; }
        public string Status_Id { get; set; }
        public string Priority { get; set; }
        public string Comments { get; set; }
        public string Solution { get; set; }
        public string Root_Id { get; set; }
        public string rootCDescripition { get; set; }
        public string dtDueDate { get; set; }
        public string Created_Date { get; set; }
        public string Created_By { get; set; }
        public string Closed_Date { get; set; }
        public bool Is_Active { get; set; }
        public string RequestorName{ get; set; }
        public string RequestorMobileNo { get; set; }        
        public string Hospital_Name{ get; set; }
        public string Category_Name{ get; set; }
        public string Asset_Name{ get; set; }
        public string Asset_Description { get; set; }
        public string SerialNumber { get; set; }        
        public string Status_Name{ get; set; }
        public string RootCause_Name{ get; set; }
        public string  Manufacturer_Id { get; set; }
        public string Manufacturer_Name { get; set; }       
        public string  Service_Provider_Id { get; set; }
        public string ServiceProvider_Name { get; set; }
        public string Open_Date { get; set; }
        public string Cost { get; set; }
        public string ContractType { get; set; }
    }
    public class Incident_Master_Email
    {
        public string Ticket_Id { get; set; }
        public int Id { get; set; }
        public string Requestor_Id { get; set; }
        public string Hospital_Id { get; set; }
        public string ProblemCategory_Id { get; set; }
        public string Assets_Id { get; set; }
        public string ProblemDescripition { get; set; }
        public string Assignee { get; set; }
        public string Status_Id { get; set; }
        public string Priority { get; set; }
        public string Comments { get; set; }
        public string Solution { get; set; }
        public string Root_Id { get; set; }
        public string rootCDescripition { get; set; }
        public string dtDueDate { get; set; }
        public string Created_Date { get; set; }
        public string Created_By { get; set; }
        public bool Is_Active { get; set; }
        public string RequestorName { get; set; }
        public string Hospital_Name { get; set; }
        public string Category_Name { get; set; }
        public string Asset_Name { get; set; }
        public string Status_Name { get; set; }
        public string RootCause_Name { get; set; }
        public string Manufacturer_Id { get; set; }
        public string Service_Provider_Id { get; set; }
        public string Req_Id { get; set; }
        public string Manufacturer_Name { get; set; }
        public string ServiceProvider_Name { get; set; }
        
        public string Email_Id { get; set; }
        public string Contact_Number { get; set; }
        public string Asset_Description { get; set; }
        public string SerialNumber { get; set; }
        public string ContractType { get; set; }
    }
    public class MailSettings
    {
         public int Id { get; set; }
        public string Sender_Name { get; set; }
        public string Sender_Email_Id { get; set; }
        public string Email_Address { get; set; }
        public string Email_Password { get; set; }
        public int PORT { get; set; }
        public string SMTP { get; set; }
        public int Created_By { get; set; }
        public string Created_Date { get; set; }
        public int Updated_By { get; set; }
        public string Updated_Date { get; set; }
        public string Is_Active { get; set; }
    }
    public class Comments_Details
    {
        public int Id { get; set; }
        public string Case_Id { get; set; }
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Comments { get; set; }
        public string  Created_Date { get; set; }
    }
    public class Attachments
    {
        public int Id { get; set; }
        public string Case_Id { get; set; }
        public string File_Name { get; set; }
        public string File_Ext { get; set; }
        public string Comments { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }


    }
    public class Dashboard
    {
        public int Open { get; set; }
        public int Closed { get; set; }
        public int Pending { get; set; }
        public int Followup { get; set; }

    }
    public class Dashboard_1
    {
        public int Totla_Records { get; set; }

    }
    public class Dashboard_2
    {
        public int Totla_Records { get; set; }
        public string RequestorName { get; set; }

    }
    public class Dashboard_3
    {
        public int Totla_Records { get; set; }
        public string Manufacturer_Name { get; set; }

    }
    public class Dashboard_4
    {
        public int Totla_Records { get; set; }
        public string Hospital_Name { get; set; }

    }
    public class Dashboard_5
    {
        public int Totla_Records { get; set; }
        public string Category_Name { get; set; }

    }
    public class Report1
    {
        public string Ticket_Id { get; set; }
        public int Id { get; set; }
        public string Requestor_Id { get; set; }
        public string Hospital_Id { get; set; }
        public string ProblemCategory_Id { get; set; }
        public string Assets_Id { get; set; }
        public string ProblemDescripition { get; set; }
        public string Assignee { get; set; }
        public string Assignee_Name { get; set; }
        public string Contact_Number { get; set; }
        public string Status_Id { get; set; }
        public string Priority { get; set; }
        public string Comments { get; set; }
        public string Solution { get; set; }
        public string Root_Id { get; set; }
        public string rootCDescripition { get; set; }
        public string dtDueDate { get; set; }
        public string Created_Date { get; set; }
        public string Created_By { get; set; }
        public string Closed_Date { get; set; }
        public bool Is_Active { get; set; }
        public string RequestorName { get; set; }
        public string RequestorMobileNo { get; set; }
        public string Hospital_Name { get; set; }
        public string Category_Name { get; set; }
        public string Asset_Name { get; set; }
        public string Asset_Description { get; set; }
        public string SerialNumber { get; set; }
        public string Status_Name { get; set; }
        public string RootCause_Name { get; set; }
        public string Manufacturer_Id { get; set; }
        public string Manufacturer_Name { get; set; }
        public string Service_Provider_Id { get; set; }
        public string ServiceProvider_Name { get; set; }
        //public string Contact_Number { get; set; }
        //public string RequestorName { get; set; }
        //public string Id { get; set; }
        //public string Assignee_Name { get; set; }
        //public string Assignee { get; set; }
        //public string Hospital_Name { get; set; }
        //public string Asset_Name { get; set; }
        //public string Unison_ID { get; set; }
        //public string ServiceProvider_Name { get; set; }
        //public string Manufacturer_Name { get; set; }
        //public string Priority { get; set; }
        //public string Status_Name { get; set; }
        //public string Category_Name { get; set; }
        //public string RootCause_Name { get; set; }
        //public string User_Name { get; set; }
        //public string Created_Date { get; set; }
        //public string Closed_Date { get; set; }
    }
    public class Report2
    {
        public string RequestorName { get; set; }
        public string Id { get; set; }
        public string Assignee { get; set; }
        public string Assignee_Name { get; set; }
        public string Hospital_Name { get; set; }
        public string Asset_Name { get; set; }
        public string Unison_ID { get; set; }
        public string ServiceProvider_Name { get; set; }
        public string Manufacturer_Name { get; set; }
        public string Priority { get; set; }
        public string Status_Name { get; set; }
        public string Category_Name { get; set; }
        public string ProblemDescripition { get; set; }
        public string RootCause_Name { get; set; }
        public string rootCDescripition { get; set; }
        public string dtDueDate { get; set; }
        public string User_Name { get; set; }
        public string Created_Date { get; set; }
        public string Closed_Date { get; set; }
        public string Last_PM_Date { get; set; }
        public string ServiceContraactDate { get; set; }
        public string PMSpecs { get; set; }
        public string Solution { get; set; }
        public string ContractType { get; set; }
        public string NextPMDate { get; set; }
    }
    public class MAN_HSP_Master
    {
        public int Asset_Id { get; set; }
        public string Asset_Name { get; set; }
        public int Maufacturer { get; set; }
        public int Hospital_Id { get; set; }
        public string Unison_ID { get; set; }
        public string Hospital_Name { get; set; }
        public string Manufacturer_Name { get; set; }

    }
    public class Dashboard_6
    {
        public int Totla_Records { get; set; }
        public int TOT_Open { get; set; }
        public int TOT_Closed { get; set; }
        public int TOT_Pending { get; set; }
        public string Name { get; set; }

    }

    public class AssetAttachments
    {
        public int Id { get; set; }
        public string Asset_Id { get; set; }
        public string File_Name { get; set; }
        public string File_Ext { get; set; }
        public string Comments { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }


    }
}