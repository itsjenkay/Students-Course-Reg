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
    
    public partial class STAFF_COURSE_ALLOCATION
    {
        public long Staff_Course_Allocation_Id { get; set; }
        public long Lecturer_User_Id { get; set; }
        public long Course_Id { get; set; }
        public int Programme_Id { get; set; }
    
        public virtual COURSE COURSE { get; set; }
        public virtual PROGRAMME PROGRAMME { get; set; }
        public virtual USER USER { get; set; }
    }
}
