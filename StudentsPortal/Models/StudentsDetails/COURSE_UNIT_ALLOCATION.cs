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
    
    public partial class COURSE_UNIT_ALLOCATION
    {
        public int Course_Unit_Allocation_Id { get; set; }
        public int Department_Id { get; set; }
        public int Level_Id { get; set; }
        public int Semester_Id { get; set; }
        public byte Minimum_Unit { get; set; }
        public byte Maximum_Unit { get; set; }
        public int Session_Id { get; set; }
        public int Compuslory_Course_Unit { get; set; }
        public int Optional_Course_Unit { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual LEVEL LEVEL { get; set; }
        public virtual SEMESTER SEMESTER { get; set; }
        public virtual SESSION SESSION { get; set; }
    }
}
