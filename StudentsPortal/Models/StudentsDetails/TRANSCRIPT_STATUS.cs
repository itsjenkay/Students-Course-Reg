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
    
    public partial class TRANSCRIPT_STATUS
    {
        public TRANSCRIPT_STATUS()
        {
            this.TRANSCRIPT_REQUEST = new HashSet<TRANSCRIPT_REQUEST>();
        }
    
        public int Transcript_Status_Id { get; set; }
        public string Transcript_Status_Name { get; set; }
        public string Transcript_Status_Description { get; set; }
    
        public virtual ICollection<TRANSCRIPT_REQUEST> TRANSCRIPT_REQUEST { get; set; }
    }
}
