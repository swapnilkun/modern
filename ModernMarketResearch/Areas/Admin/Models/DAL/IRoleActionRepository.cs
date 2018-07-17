using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMarketResearch.Areas.Admin.Models.DAL
{
    interface IRoleActionRepository
    {
        IEnumerable<spSelectRoleAction_Result> GetRoleAction();
        void InsertAction(RoleActionVM Roleaction, int[] actions);
        void UpdateAction(int id, RoleMaster rolemaster, int[] actions);
        void DeleteAction(int RoleId);
        spDetailsRoleAction_Result DetailAction(int RoleId);
    }
}
