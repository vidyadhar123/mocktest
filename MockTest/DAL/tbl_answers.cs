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
    
    public partial class tbl_answers
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool IsRight { get; set; }
        public int QuestionId { get; set; }
    
        public virtual tbl_questions tbl_questions { get; set; }
    }
}
