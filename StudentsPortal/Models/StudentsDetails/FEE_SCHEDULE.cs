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
    
    public partial class FEE_SCHEDULE
    {
        public FEE_SCHEDULE()
        {
            this.ETRANZACT_FEE_SCHEDULE = new HashSet<ETRANZACT_FEE_SCHEDULE>();
            this.ETRANZACT_TERMINAL = new HashSet<ETRANZACT_TERMINAL>();
            this.FEE_DETAIL = new HashSet<FEE_DETAIL>();
            this.PAYMENTs = new HashSet<PAYMENT>();
            this.REMITA_PAYMENT_SETTINGS = new HashSet<REMITA_PAYMENT_SETTINGS>();
        }
    
        public int Fee_Schedule_Id { get; set; }
        public string Fee_Schedule_Name { get; set; }
    
        public virtual ICollection<ETRANZACT_FEE_SCHEDULE> ETRANZACT_FEE_SCHEDULE { get; set; }
        public virtual ICollection<ETRANZACT_TERMINAL> ETRANZACT_TERMINAL { get; set; }
        public virtual ICollection<FEE_DETAIL> FEE_DETAIL { get; set; }
        public virtual ICollection<PAYMENT> PAYMENTs { get; set; }
        public virtual ICollection<REMITA_PAYMENT_SETTINGS> REMITA_PAYMENT_SETTINGS { get; set; }
    }
}
