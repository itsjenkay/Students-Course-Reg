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
    
    public partial class OFFLINE_PAYMENT
    {
        public long Payment_Id { get; set; }
        public int Etranzact_Fee_Schedule_Id { get; set; }
        public Nullable<decimal> Transaction_Amount { get; set; }
        public string Transaction_Description { get; set; }
        public Nullable<System.DateTime> Transaction_Date { get; set; }
        public string Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
    
        public virtual ETRANZACT_FEE_SCHEDULE ETRANZACT_FEE_SCHEDULE { get; set; }
        public virtual PAYMENT PAYMENT { get; set; }
    }
}
