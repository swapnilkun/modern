﻿using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernMarketResearch.Models.ViewModel
{
    public class ReportDetailsVM
    {
        public ReportVM ReportDetails { get; set; }
        public Category Category { get; set; }
        public IEnumerable<BreadsCum> BreadcrumbCategory { get; set; }
    }
}