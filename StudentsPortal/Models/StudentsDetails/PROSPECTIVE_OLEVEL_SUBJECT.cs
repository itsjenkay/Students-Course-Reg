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
    
    public partial class PROSPECTIVE_OLEVEL_SUBJECT
    {
        public PROSPECTIVE_OLEVEL_SUBJECT()
        {
            this.PROSPECTIVE_OLEVEL_RESULT_DETAIL = new HashSet<PROSPECTIVE_OLEVEL_RESULT_DETAIL>();
        }
    
        public int OLevel_Subject_Id { get; set; }
        public string OLevel_Subject_Name { get; set; }
        public bool Activated { get; set; }
    
        public virtual ICollection<PROSPECTIVE_OLEVEL_RESULT_DETAIL> PROSPECTIVE_OLEVEL_RESULT_DETAIL { get; set; }
    }
}
