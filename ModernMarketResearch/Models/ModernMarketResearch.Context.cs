﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ModernMarketResearchEntities : DbContext
    {
        public ModernMarketResearchEntities()
            : base("name=ModernMarketResearchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ActionMaster> ActionMasters { get; set; }
        public DbSet<BuyingInfo> BuyingInfoes { get; set; }
        public DbSet<CategoryMaster> CategoryMasters { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CustomerInquiry> CustomerInquiries { get; set; }
        public DbSet<NewsMaster> NewsMasters { get; set; }
        public DbSet<PublisherMaster> PublisherMasters { get; set; }
        public DbSet<ReportDeliveryType> ReportDeliveryTypes { get; set; }
        public DbSet<ReportMaster> ReportMasters { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<RoleActionRelation> RoleActionRelations { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<UserMaster> UserMasters { get; set; }
        public DbSet<UserRoleRelation> UserRoleRelations { get; set; }
    
        [EdmFunction("ModernMarketResearchEntities", "SplitString")]
        public virtual IQueryable<SplitString_Result> SplitString(string stringToSplit)
        {
            var stringToSplitParameter = stringToSplit != null ?
                new ObjectParameter("StringToSplit", stringToSplit) :
                new ObjectParameter("StringToSplit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SplitString_Result>("[ModernMarketResearchEntities].[SplitString](@StringToSplit)", stringToSplitParameter);
        }
    
        public virtual ObjectResult<spBreadsCum_Result> spBreadsCum(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spBreadsCum_Result>("spBreadsCum", categoryIdParameter);
        }
    
        public virtual ObjectResult<spCategoryRelatedReport_Result> spCategoryRelatedReport(Nullable<int> catid, Nullable<int> pageno, ObjectParameter p_Count)
        {
            var catidParameter = catid.HasValue ?
                new ObjectParameter("Catid", catid) :
                new ObjectParameter("Catid", typeof(int));
    
            var pagenoParameter = pageno.HasValue ?
                new ObjectParameter("Pageno", pageno) :
                new ObjectParameter("Pageno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCategoryRelatedReport_Result>("spCategoryRelatedReport", catidParameter, pagenoParameter, p_Count);
        }
    
        public virtual ObjectResult<spDetailsRoleAction_Result> spDetailsRoleAction(Nullable<int> roleId)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spDetailsRoleAction_Result>("spDetailsRoleAction", roleIdParameter);
        }
    
        public virtual ObjectResult<spDetailsUserRole_Result> spDetailsUserRole(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spDetailsUserRole_Result>("spDetailsUserRole", userIdParameter);
        }
    
        public virtual ObjectResult<spLatestNews_Result> spLatestNews()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLatestNews_Result>("spLatestNews");
        }
    
        public virtual ObjectResult<spLatestReport_Result> spLatestReport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLatestReport_Result>("spLatestReport");
        }
    
        public virtual ObjectResult<spNewAllLatestReport_Result> spNewAllLatestReport(Nullable<int> pageno, ObjectParameter p_Count)
        {
            var pagenoParameter = pageno.HasValue ?
                new ObjectParameter("Pageno", pageno) :
                new ObjectParameter("Pageno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spNewAllLatestReport_Result>("spNewAllLatestReport", pagenoParameter, p_Count);
        }
    
        public virtual int spRoleActionDelete(Nullable<int> roleId)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRoleActionDelete", roleIdParameter);
        }
    
        public virtual int spRoleActionInsert(Nullable<int> roleId, string roleName, Nullable<bool> isActive, Nullable<int> createdBy, Nullable<int> modifiedBy, Nullable<System.DateTime> createdDate, Nullable<System.DateTime> modifiedDate, string actionId)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(int));
    
            var modifiedByParameter = modifiedBy.HasValue ?
                new ObjectParameter("ModifiedBy", modifiedBy) :
                new ObjectParameter("ModifiedBy", typeof(int));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var modifiedDateParameter = modifiedDate.HasValue ?
                new ObjectParameter("ModifiedDate", modifiedDate) :
                new ObjectParameter("ModifiedDate", typeof(System.DateTime));
    
            var actionIdParameter = actionId != null ?
                new ObjectParameter("ActionId", actionId) :
                new ObjectParameter("ActionId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRoleActionInsert", roleIdParameter, roleNameParameter, isActiveParameter, createdByParameter, modifiedByParameter, createdDateParameter, modifiedDateParameter, actionIdParameter);
        }
    
        public virtual int spRoleActionUpdate(Nullable<int> roleId, string roleName, Nullable<bool> isActive, Nullable<int> createdBy, Nullable<int> modifiedBy, Nullable<System.DateTime> createdDate, Nullable<System.DateTime> modifiedDate, string actionId)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(int));
    
            var modifiedByParameter = modifiedBy.HasValue ?
                new ObjectParameter("ModifiedBy", modifiedBy) :
                new ObjectParameter("ModifiedBy", typeof(int));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var modifiedDateParameter = modifiedDate.HasValue ?
                new ObjectParameter("ModifiedDate", modifiedDate) :
                new ObjectParameter("ModifiedDate", typeof(System.DateTime));
    
            var actionIdParameter = actionId != null ?
                new ObjectParameter("ActionId", actionId) :
                new ObjectParameter("ActionId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRoleActionUpdate", roleIdParameter, roleNameParameter, isActiveParameter, createdByParameter, modifiedByParameter, createdDateParameter, modifiedDateParameter, actionIdParameter);
        }
    
        public virtual ObjectResult<spSelectedNewsDetails_Result> spSelectedNewsDetails(string newsUrl)
        {
            var newsUrlParameter = newsUrl != null ?
                new ObjectParameter("NewsUrl", newsUrl) :
                new ObjectParameter("NewsUrl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectedNewsDetails_Result>("spSelectedNewsDetails", newsUrlParameter);
        }
    
        public virtual ObjectResult<spSelectRoleAction_Result> spSelectRoleAction()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectRoleAction_Result>("spSelectRoleAction");
        }
    
        public virtual int spUserRoleDelete(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUserRoleDelete", userIdParameter);
        }
    
        public virtual int spUserRoleInsert(Nullable<int> userId, string userFName, string userLName, string currentAddress, string state, string city, string contactNumber, string permnentAddress, string gender, string companyName, string emailAddress, string password, Nullable<bool> isActive, Nullable<int> createdBy, Nullable<int> modifiedBy, Nullable<System.DateTime> createdDate, Nullable<System.DateTime> modifiedDate, string roleId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var userFNameParameter = userFName != null ?
                new ObjectParameter("UserFName", userFName) :
                new ObjectParameter("UserFName", typeof(string));
    
            var userLNameParameter = userLName != null ?
                new ObjectParameter("UserLName", userLName) :
                new ObjectParameter("UserLName", typeof(string));
    
            var currentAddressParameter = currentAddress != null ?
                new ObjectParameter("CurrentAddress", currentAddress) :
                new ObjectParameter("CurrentAddress", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var permnentAddressParameter = permnentAddress != null ?
                new ObjectParameter("PermnentAddress", permnentAddress) :
                new ObjectParameter("PermnentAddress", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var emailAddressParameter = emailAddress != null ?
                new ObjectParameter("EmailAddress", emailAddress) :
                new ObjectParameter("EmailAddress", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(int));
    
            var modifiedByParameter = modifiedBy.HasValue ?
                new ObjectParameter("ModifiedBy", modifiedBy) :
                new ObjectParameter("ModifiedBy", typeof(int));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var modifiedDateParameter = modifiedDate.HasValue ?
                new ObjectParameter("ModifiedDate", modifiedDate) :
                new ObjectParameter("ModifiedDate", typeof(System.DateTime));
    
            var roleIdParameter = roleId != null ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUserRoleInsert", userIdParameter, userFNameParameter, userLNameParameter, currentAddressParameter, stateParameter, cityParameter, contactNumberParameter, permnentAddressParameter, genderParameter, companyNameParameter, emailAddressParameter, passwordParameter, isActiveParameter, createdByParameter, modifiedByParameter, createdDateParameter, modifiedDateParameter, roleIdParameter);
        }
    
        public virtual ObjectResult<spUserRoleSelect_Result> spUserRoleSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUserRoleSelect_Result>("spUserRoleSelect");
        }
    
        public virtual int spUserRoleUpdate(Nullable<int> userId, string userFName, string userLName, string currentAddress, string state, string city, string contactNumber, string permnentAddress, string gender, string companyName, string emailAddress, string password, Nullable<bool> isActive, Nullable<int> createdBy, Nullable<int> modifiedBy, Nullable<System.DateTime> createdDate, Nullable<System.DateTime> modifiedDate, string roleId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var userFNameParameter = userFName != null ?
                new ObjectParameter("UserFName", userFName) :
                new ObjectParameter("UserFName", typeof(string));
    
            var userLNameParameter = userLName != null ?
                new ObjectParameter("UserLName", userLName) :
                new ObjectParameter("UserLName", typeof(string));
    
            var currentAddressParameter = currentAddress != null ?
                new ObjectParameter("CurrentAddress", currentAddress) :
                new ObjectParameter("CurrentAddress", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var permnentAddressParameter = permnentAddress != null ?
                new ObjectParameter("PermnentAddress", permnentAddress) :
                new ObjectParameter("PermnentAddress", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var emailAddressParameter = emailAddress != null ?
                new ObjectParameter("EmailAddress", emailAddress) :
                new ObjectParameter("EmailAddress", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(int));
    
            var modifiedByParameter = modifiedBy.HasValue ?
                new ObjectParameter("ModifiedBy", modifiedBy) :
                new ObjectParameter("ModifiedBy", typeof(int));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var modifiedDateParameter = modifiedDate.HasValue ?
                new ObjectParameter("ModifiedDate", modifiedDate) :
                new ObjectParameter("ModifiedDate", typeof(System.DateTime));
    
            var roleIdParameter = roleId != null ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUserRoleUpdate", userIdParameter, userFNameParameter, userLNameParameter, currentAddressParameter, stateParameter, cityParameter, contactNumberParameter, permnentAddressParameter, genderParameter, companyNameParameter, emailAddressParameter, passwordParameter, isActiveParameter, createdByParameter, modifiedByParameter, createdDateParameter, modifiedDateParameter, roleIdParameter);
        }
    }
}
