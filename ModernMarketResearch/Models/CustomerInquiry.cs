//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModernMarketResearch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerInquiry
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }
        public string CaptchaCode { get; set; }
        public string CustomerMessage { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> ReportId { get; set; }
        public string FormType { get; set; }
        public string ReportTitle { get; set; }
        public string AreaCode { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
