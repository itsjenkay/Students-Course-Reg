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
    
    public partial class PROSPECTIVE_OLEVEL_RESULT_DETAIL
    {
        public long OLevel_Result_Detail_Id { get; set; }
        public long OLevel_Result_Id { get; set; }
        public int OLevel_Subject_Grade_Id { get; set; }
        public int OLevel_Subject_Id { get; set; }
    
        public virtual PROSPECTIVE_OLEVEL_RESULT PROSPECTIVE_OLEVEL_RESULT { get; set; }
        public virtual PROSPECTIVE_OLEVEL_SUBJECT PROSPECTIVE_OLEVEL_SUBJECT { get; set; }
        public virtual PROSPECTIVE_OLEVEL_SUBJECT_GRADE PROSPECTIVE_OLEVEL_SUBJECT_GRADE { get; set; }
    }
}
