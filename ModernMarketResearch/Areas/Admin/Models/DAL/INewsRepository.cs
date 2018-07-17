using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMarketResearch.Areas.Admin.Models.DAL
{
    interface INewsRepository
    {
        void InsertNews(NewsVM news);
        NewsMaster GetNewsById(int newsid);
        NewsVM EditNews(int id);
        void EditpostNews(NewsVM news);
        void NewsDelete(int newsid);
        List<NewsMaster> GetNews();
    }
}
