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
    
    public partial class PROGRAMME
    {
        public PROGRAMME()
        {
            this.ADMISSIONS = new HashSet<ADMISSION>();
            this.COURSE_REGISTRATION = new HashSet<COURSE_REGISTRATION>();
            this.COURSE_TIME_TABLE_SCHEDULE = new HashSet<COURSE_TIME_TABLE_SCHEDULE>();
            this.ETRANZACT_FEE_SCHEDULE = new HashSet<ETRANZACT_FEE_SCHEDULE>();
            this.FEE_DETAIL = new HashSet<FEE_DETAIL>();
            this.JUPEB_ADMISSIONS = new HashSet<JUPEB_ADMISSIONS>();
            this.JUPEB_PROSPECTIVE_APPLIED_COURSE = new HashSet<JUPEB_PROSPECTIVE_APPLIED_COURSE>();
            this.POSTGRADUATE_ADMISSIONS = new HashSet<POSTGRADUATE_ADMISSIONS>();
            this.POSTGRADUATE_APPLIED_COURSE = new HashSet<POSTGRADUATE_APPLIED_COURSE>();
            this.POSTGRADUATE_COURSE_REGISTRATION = new HashSet<POSTGRADUATE_COURSE_REGISTRATION>();
            this.POSTGRADUATE_STUDENT_LEVEL = new HashSet<POSTGRADUATE_STUDENT_LEVEL>();
            this.PROGRAMME_DEPARTMENT = new HashSet<PROGRAMME_DEPARTMENT>();
            this.PROSPECTIVE_APPLIED_COURSE = new HashSet<PROSPECTIVE_APPLIED_COURSE>();
            this.PROSPECTIVE_SECOND_APPLIED_COURSE = new HashSet<PROSPECTIVE_SECOND_APPLIED_COURSE>();
            this.QUIZ_TIME_TABLE_SCHEDULE = new HashSet<QUIZ_TIME_TABLE_SCHEDULE>();
            this.STAFF_COURSE_ALLOCATION = new HashSet<STAFF_COURSE_ALLOCATION>();
            this.STUDENT_LEVEL = new HashSet<STUDENT_LEVEL>();
        }
    
        public int Programme_Id { get; set; }
        public string Programme_Name { get; set; }
        public bool Activated { get; set; }
        public string Programme_Code { get; set; }
        public string Programme_Description { get; set; }
    
        public virtual ICollection<ADMISSION> ADMISSIONS { get; set; }
        public virtual ICollection<COURSE_REGISTRATION> COURSE_REGISTRATION { get; set; }
        public virtual ICollection<COURSE_TIME_TABLE_SCHEDULE> COURSE_TIME_TABLE_SCHEDULE { get; set; }
        public virtual ICollection<ETRANZACT_FEE_SCHEDULE> ETRANZACT_FEE_SCHEDULE { get; set; }
        public virtual ICollection<FEE_DETAIL> FEE_DETAIL { get; set; }
        public virtual ICollection<JUPEB_ADMISSIONS> JUPEB_ADMISSIONS { get; set; }
        public virtual ICollection<JUPEB_PROSPECTIVE_APPLIED_COURSE> JUPEB_PROSPECTIVE_APPLIED_COURSE { get; set; }
        public virtual ICollection<POSTGRADUATE_ADMISSIONS> POSTGRADUATE_ADMISSIONS { get; set; }
        public virtual ICollection<POSTGRADUATE_APPLIED_COURSE> POSTGRADUATE_APPLIED_COURSE { get; set; }
        public virtual ICollection<POSTGRADUATE_COURSE_REGISTRATION> POSTGRADUATE_COURSE_REGISTRATION { get; set; }
        public virtual ICollection<POSTGRADUATE_STUDENT_LEVEL> POSTGRADUATE_STUDENT_LEVEL { get; set; }
        public virtual ICollection<PROGRAMME_DEPARTMENT> PROGRAMME_DEPARTMENT { get; set; }
        public virtual ICollection<PROSPECTIVE_APPLIED_COURSE> PROSPECTIVE_APPLIED_COURSE { get; set; }
        public virtual ICollection<PROSPECTIVE_SECOND_APPLIED_COURSE> PROSPECTIVE_SECOND_APPLIED_COURSE { get; set; }
        public virtual ICollection<QUIZ_TIME_TABLE_SCHEDULE> QUIZ_TIME_TABLE_SCHEDULE { get; set; }
        public virtual ICollection<STAFF_COURSE_ALLOCATION> STAFF_COURSE_ALLOCATION { get; set; }
        public virtual ICollection<STUDENT_LEVEL> STUDENT_LEVEL { get; set; }
    }
}
