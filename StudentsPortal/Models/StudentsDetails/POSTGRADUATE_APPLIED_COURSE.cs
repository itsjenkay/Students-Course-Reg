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
    
    public partial class POSTGRADUATE_APPLIED_COURSE
    {
        public long Person_Id { get; set; }
        public int PostGraduate_Department_Id { get; set; }
        public int Session_Id { get; set; }
        public int Programme_Id { get; set; }
    
        public virtual PERSON PERSON { get; set; }
        public virtual POSTGRADUATE_DEPARTMENT POSTGRADUATE_DEPARTMENT { get; set; }
        public virtual PROGRAMME PROGRAMME { get; set; }
        public virtual SESSION SESSION { get; set; }
    }
}
