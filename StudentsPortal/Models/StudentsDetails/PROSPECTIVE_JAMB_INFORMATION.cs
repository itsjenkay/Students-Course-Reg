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
    
    public partial class PROSPECTIVE_JAMB_INFORMATION
    {
        public long Person_Id { get; set; }
        public string Jamb_Registration_Number { get; set; }
        public Nullable<double> Jamb_Score { get; set; }
        public Nullable<int> Exam_Year { get; set; }
        public string FirstSubject { get; set; }
        public Nullable<int> FirstSubjectScore { get; set; }
        public string SecondSubject { get; set; }
        public Nullable<int> SeconeSubjectScore { get; set; }
        public string ThirdSubject { get; set; }
        public Nullable<int> ThirdSubjectScore { get; set; }
        public string ForthSubject { get; set; }
        public Nullable<int> ForthSubjectScore { get; set; }
    
        public virtual PERSON PERSON { get; set; }
    }
}
