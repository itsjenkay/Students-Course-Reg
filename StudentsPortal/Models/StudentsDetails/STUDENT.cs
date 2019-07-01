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
    
    public partial class STUDENT
    {
        public STUDENT()
        {
            this.COURSE_REGISTRATION = new HashSet<COURSE_REGISTRATION>();
            this.STUDENT_HOSTEL = new HashSet<STUDENT_HOSTEL>();
            this.STUDENT_LEVEL = new HashSet<STUDENT_LEVEL>();
            this.TRANSCRIPT_REQUEST = new HashSet<TRANSCRIPT_REQUEST>();
        }
    
        public long Person_Id { get; set; }
        public Nullable<long> Admission_Id { get; set; }
        public int Student_Category_Id { get; set; }
        public int Student_Status_Id { get; set; }
        public string Matric_Number { get; set; }
        public Nullable<bool> Activated { get; set; }
        public string Student_Status_Reason { get; set; }
    
        public virtual ADMISSION ADMISSION { get; set; }
        public virtual ICollection<COURSE_REGISTRATION> COURSE_REGISTRATION { get; set; }
        public virtual PERSON PERSON { get; set; }
        public virtual ICollection<STUDENT_HOSTEL> STUDENT_HOSTEL { get; set; }
        public virtual ICollection<STUDENT_LEVEL> STUDENT_LEVEL { get; set; }
        public virtual STUDENT_CATEGORY STUDENT_CATEGORY { get; set; }
        public virtual STUDENT_STATUS STUDENT_STATUS { get; set; }
        public virtual ICollection<TRANSCRIPT_REQUEST> TRANSCRIPT_REQUEST { get; set; }
    }
}
