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
    
    public partial class RIGHT
    {
        public RIGHT()
        {
            this.USER_RIGHT = new HashSet<USER_RIGHT>();
        }
    
        public int Right_Id { get; set; }
        public string Right_Action { get; set; }
        public bool Activated { get; set; }
    
        public virtual ICollection<USER_RIGHT> USER_RIGHT { get; set; }
    }
}
