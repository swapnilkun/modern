//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcellentMarketResearch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMaster
    {
        public int UserId { get; set; }
        public string UserFName { get; set; }
        public string UserLName { get; set; }
        public string CurrentAddress { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public string PermnentAddress { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public string CompanyName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
