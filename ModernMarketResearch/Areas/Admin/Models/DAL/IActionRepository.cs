using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMarketResearch.Areas.Admin.Models.DAL
{
    interface IActionRepository
    {
        List<ActionMaster> GetAction();
        void InsertAction(ActionVM actionvm);
        ActionVM GetActionById(int ActionId);
        void UpdateAction(ActionVM actionvm);
        void DeleteAction(int ActionId);
    }
}
