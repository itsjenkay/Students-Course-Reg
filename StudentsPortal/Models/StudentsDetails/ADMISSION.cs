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
    
    public partial class ADMISSION
    {
        public ADMISSION()
        {
            this.STUDENTs = new HashSet<STUDENT>();
        }
    
        public long Admissions_Id { get; set; }
        public int Department_Id { get; set; }
        public Nullable<bool> Activated { get; set; }
        public int Programme_Id { get; set; }
        public int Session_Id { get; set; }
        public long Prospective_Student_Id { get; set; }
        public Nullable<System.DateTime> Date_Uploaded { get; set; }
        public Nullable<long> Uploaded_By_User_Id { get; set; }
        public int Status { get; set; }
        public string AdmissionReason { get; set; }
        public int AdmissionMode { get; set; }
        public Nullable<bool> isExpired { get; set; }
        public Nullable<System.DateTime> Expiration { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual PROGRAMME PROGRAMME { get; set; }
        public virtual PROSPECTIVE_STUDENT PROSPECTIVE_STUDENT { get; set; }
        public virtual SESSION SESSION { get; set; }
        public virtual USER USER { get; set; }
        public virtual ICollection<STUDENT> STUDENTs { get; set; }
    }
}
