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
    
    public partial class TRIBE
    {
        public TRIBE()
        {
            this.People = new HashSet<PERSON>();
        }
    
        public int Tribe_Id { get; set; }
        public string Tribe_Name { get; set; }
    
        public virtual ICollection<PERSON> People { get; set; }
    }
}
