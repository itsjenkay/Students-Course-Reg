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
    
    public partial class PERSON
    {
        public PERSON()
        {
            this.ETRANZACT_PAYMENT = new HashSet<ETRANZACT_PAYMENT>();
            this.PAYMENTs = new HashSet<PAYMENT>();
            this.PROSPECTIVE_OLEVEL_RESULT = new HashSet<PROSPECTIVE_OLEVEL_RESULT>();
            this.PROSPECTIVE_STUDENT_PREVIOUS_EDUCATION = new HashSet<PROSPECTIVE_STUDENT_PREVIOUS_EDUCATION>();
            this.REFERAL_SYSTEM = new HashSet<REFERAL_SYSTEM>();
            this.REFEREEs = new HashSet<REFEREE>();
            this.STAFF_RATING = new HashSet<STAFF_RATING>();
            this.USERs = new HashSet<USER>();
        }
    
        public long Person_Id { get; set; }
        public int Person_Type_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Other_Name { get; set; }
        public string Initial { get; set; }
        public Nullable<int> Title_Id { get; set; }
        public string Passport_Url { get; set; }
        public string Signature_Image_Url { get; set; }
        public Nullable<int> Gender_Id { get; set; }
        public string Contact_Address { get; set; }
        public string Email_Address { get; set; }
        public string Mobile_Phone { get; set; }
        public Nullable<System.DateTime> Date_Of_Birth { get; set; }
        public string State_Id { get; set; }
        public Nullable<int> Local_Government_Id { get; set; }
        public string Home_Town { get; set; }
        public string Home_Address { get; set; }
        public Nullable<int> Country_Id { get; set; }
        public Nullable<int> Religion_Id { get; set; }
        public System.DateTime Date_Entered { get; set; }
        public int Role_Id { get; set; }
        public Nullable<int> Genotype_Id { get; set; }
        public Nullable<int> Disability_Id { get; set; }
        public Nullable<int> Tribe_Id { get; set; }
        public string ParentName { get; set; }
        public string ParentNumber { get; set; }
        public string Family_Kindred { get; set; }
        public string Village { get; set; }
    
        public virtual COUNTRY COUNTRY { get; set; }
        public virtual DISABILITY DISABILITY { get; set; }
        public virtual ICollection<ETRANZACT_PAYMENT> ETRANZACT_PAYMENT { get; set; }
        public virtual GENDER GENDER { get; set; }
        public virtual GENOTYPE GENOTYPE { get; set; }
        public virtual JUPEB_PROSPECTIVE_APPLIED_COURSE JUPEB_PROSPECTIVE_APPLIED_COURSE { get; set; }
        public virtual LOCAL_GOVERNMENT LOCAL_GOVERNMENT { get; set; }
        public virtual NEXT_OF_KIN NEXT_OF_KIN { get; set; }
        public virtual ICollection<PAYMENT> PAYMENTs { get; set; }
        public virtual PERSON_TYPE PERSON_TYPE { get; set; }
        public virtual RELIGION RELIGION { get; set; }
        public virtual ROLE ROLE { get; set; }
        public virtual STATE STATE { get; set; }
        public virtual TITLE TITLE { get; set; }
        public virtual TRIBE TRIBE { get; set; }
        public virtual POSTGRADUATE_APPLIED_COURSE POSTGRADUATE_APPLIED_COURSE { get; set; }
        public virtual POSTGRADUATE_STUDENT POSTGRADUATE_STUDENT { get; set; }
        public virtual PROSPECTIVE_APPLIED_COURSE PROSPECTIVE_APPLIED_COURSE { get; set; }
        public virtual PROSPECTIVE_JAMB_INFORMATION PROSPECTIVE_JAMB_INFORMATION { get; set; }
        public virtual ICollection<PROSPECTIVE_OLEVEL_RESULT> PROSPECTIVE_OLEVEL_RESULT { get; set; }
        public virtual PROSPECTIVE_SECOND_APPLIED_COURSE PROSPECTIVE_SECOND_APPLIED_COURSE { get; set; }
        public virtual PROSPECTIVE_STUDENT PROSPECTIVE_STUDENT { get; set; }
        public virtual ICollection<PROSPECTIVE_STUDENT_PREVIOUS_EDUCATION> PROSPECTIVE_STUDENT_PREVIOUS_EDUCATION { get; set; }
        public virtual ICollection<REFERAL_SYSTEM> REFERAL_SYSTEM { get; set; }
        public virtual ICollection<REFEREE> REFEREEs { get; set; }
        public virtual STAFF STAFF { get; set; }
        public virtual ICollection<STAFF_RATING> STAFF_RATING { get; set; }
        public virtual STUDENT STUDENT { get; set; }
        public virtual ICollection<USER> USERs { get; set; }
    }
}
