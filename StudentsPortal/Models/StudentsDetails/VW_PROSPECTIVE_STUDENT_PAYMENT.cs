//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsPortal.Models.StudentsDetails
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_PROSPECTIVE_STUDENT_PAYMENT
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Other_Name { get; set; }
        public string Appication_Number { get; set; }
        public Nullable<int> Department_Id { get; set; }
        public string Session_Name { get; set; }
        public int Session_Id { get; set; }
        public long Person_Id { get; set; }
        public Nullable<bool> Admitted { get; set; }
        public string AdmissionTypeName { get; set; }
        public Nullable<int> Status_Id { get; set; }
        public System.DateTime Date_Entered { get; set; }
        public int Faculty_Id { get; set; }
        public string Faculty_Name { get; set; }
        public string Passport_Url { get; set; }
    }
}
