//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MockTest.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_questions
    {
        public tbl_questions()
        {
            this.tbl_answers = new HashSet<tbl_answers>();
        }
    
        public int Id { get; set; }
        public string Question { get; set; }
        public int SubCategoryId { get; set; }
    
        public virtual ICollection<tbl_answers> tbl_answers { get; set; }
        public virtual tbl_subjectCategory tbl_subjectCategory { get; set; }
    }
}
