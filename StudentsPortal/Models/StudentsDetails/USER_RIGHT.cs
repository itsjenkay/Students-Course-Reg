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
    
    public partial class USER_RIGHT
    {
        public long User_Right_Id { get; set; }
        public long User_Id { get; set; }
        public int Right_Id { get; set; }
    
        public virtual RIGHT RIGHT { get; set; }
        public virtual USER USER { get; set; }
    }
}
