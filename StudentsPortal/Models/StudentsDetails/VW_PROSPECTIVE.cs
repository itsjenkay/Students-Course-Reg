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
    
    public partial class VW_PROSPECTIVE
    {
        public long Person_Id { get; set; }
        public string application_number { get; set; }
        public int Programme_Id { get; set; }
        public string fullname { get; set; }
        public int Department_Id { get; set; }
        public int sessionId { get; set; }
        public string Programme_Name { get; set; }
        public string Session_Name { get; set; }
        public string Passport_Url { get; set; }
        public int SecondDepartment { get; set; }
        public string Appication_Number { get; set; }
        public Nullable<bool> Admitted { get; set; }
        public long OLevel_Result_Id { get; set; }
        public string OLevel_Subject_Grade_Name { get; set; }
        public Nullable<int> Olevel_Exam_Attempt_Id { get; set; }
        public string OLevel_Subject_Name { get; set; }
        public string Mobile_Phone { get; set; }
        public string AdmissionTypeName { get; set; }
        public int AdmissionTypeId { get; set; }
        public Nullable<byte> Gender_Id { get; set; }
        public string Gender_Name { get; set; }
        public string Contact_Address { get; set; }
        public string Email_Address { get; set; }
        public Nullable<System.DateTime> Date_Of_Birth { get; set; }
        public string State_Id { get; set; }
        public string State_Name { get; set; }
        public Nullable<int> Local_Government_Id { get; set; }
        public string Local_Government_Name { get; set; }
        public string Home_Town { get; set; }
        public int Country_Id { get; set; }
        public Nullable<int> Religion_Id { get; set; }
        public string Religion_Name { get; set; }
        public Nullable<int> Genotype_Id { get; set; }
        public Nullable<int> Disability_Id { get; set; }
        public string Disability_Name { get; set; }
        public Nullable<int> Tribe_Id { get; set; }
        public string Tribe_Name { get; set; }
        public string Hobbies { get; set; }
        public string Country_Name { get; set; }
    }
}
