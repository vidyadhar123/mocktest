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
    
    public partial class tbl_verification_info
    {
        public int Id { get; set; }
        public System.Guid RegistrationId { get; set; }
        public string VerificationLink { get; set; }
        public string VerificationCode { get; set; }
        public Nullable<System.DateTime> LinkGenerateDate { get; set; }
        public Nullable<System.DateTime> VerificationDate { get; set; }
        public bool IsVerify { get; set; }
    
        public virtual tbl_registration tbl_registration { get; set; }
    }
}
