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
    
    public partial class STAFF_RATING
    {
        public long Staff_Rating_Id { get; set; }
        public long StaffUser_Id { get; set; }
        public long Rated_By_Person { get; set; }
        public int Rating_Score { get; set; }
        public int Semester_Id { get; set; }
        public int Session_Id { get; set; }
        public System.DateTime Date_Entered { get; set; }
        public bool activated { get; set; }
        public string Rating_Comment { get; set; }
    
        public virtual PERSON PERSON { get; set; }
        public virtual SEMESTER SEMESTER { get; set; }
        public virtual SESSION SESSION { get; set; }
        public virtual USER USER { get; set; }
    }
}
