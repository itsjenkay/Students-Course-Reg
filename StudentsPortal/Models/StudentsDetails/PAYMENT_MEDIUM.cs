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
    
    public partial class PAYMENT_MEDIUM
    {
        public PAYMENT_MEDIUM()
        {
            this.PAYMENTs = new HashSet<PAYMENT>();
        }
    
        public int Payment_Medium_Id { get; set; }
        public string Payment_Medium_Name { get; set; }
    
        public virtual ICollection<PAYMENT> PAYMENTs { get; set; }
    }
}
