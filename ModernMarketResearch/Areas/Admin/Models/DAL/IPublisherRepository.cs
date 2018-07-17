using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMarketResearch.Areas.Admin.Models.DAL
{
    interface IPublisherRepository
    {
         List<PublisherMaster> GetPublisher();
   
      
        //[CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
         void InsertPublisher(PublisherVM pub);
      
        
         PublisherVM GetPublisherById(int id);
        
        // [CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
         void PublisherEdit(PublisherVM pub);
  
        //   [CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
          
        

    }
}
