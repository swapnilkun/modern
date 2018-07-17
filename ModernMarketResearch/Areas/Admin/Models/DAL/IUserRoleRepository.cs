using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMarketResearch.Areas.Admin.Models.DAL
{
    interface IUserRoleRepository
    {
        void InsertUserRole(UserRoleVM userrole, int[] roleids);
        IEnumerable<spUserRoleSelect_Result> GetUserRole();
        void UpdateUserRole(int id, UserRoleVM userrole, int[] Roles);
        // void DeleteUserRole(int RoleId);
        spDetailsUserRole_Result DetailUserRole(int id);
    }
}
