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
    
    public partial class STAFF_QUALIFICATIONS
    {
        public int Qualification_Id { get; set; }
        public string Qualification_Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Cert_Obtained { get; set; }
        public Nullable<long> Staff_Id { get; set; }
    
        public virtual CERTIFICATE_OBTAINED CERTIFICATE_OBTAINED { get; set; }
        public virtual STAFF STAFF { get; set; }
    }
}
