using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMarketResearch.Areas.Admin.Models.DAL
{
    interface IReportRepository
    {
        void InsertReport(ReportVM news);
        ReportVM GetReportById(int newsid);
        ReportVM EditGetReport(int id);
        bool EditPostReport(ReportVM reportvm);
        void ReportDelete(int ReportId);
        //List<ReportVM> GetReport();
    }
}
