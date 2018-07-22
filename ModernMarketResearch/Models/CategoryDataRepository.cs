using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernMarketResearch.Models
{
    public class CategoryDataRepository
    {
        ModernMarketResearchEntities db = new ModernMarketResearchEntities();
        public List<Category> GetAllCategories()
        {
            var repoCategory = db.ReportMasters.Select(x => x.CategoryId).ToList();

            var parent = db.CategoryMasters.Where(x => x.ParentCategoryId == 0).Select(x => new Category
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                CategoryUrl = x.CategoryUrl,
                ParentCategoryId = x.ParentCategoryId
            }).ToList();

            int[] parentIds = parent.Select(p => p.CategoryId).ToArray();


            //var childs = db.CategoryMasters.Where(x => parentIds.Contains((int)x.ParentCategoryId)).Select(x => new Category
            //{
            //    CategoryId = x.CategoryId,
            //    CategoryName = x.CategoryName,
            //    CategoryUrl = x.CategoryURL,
            //    ParentCategoryId = x.ParentCategoryId
            //}).OrderBy(x => x.CategoryId).ToList();

            var childs = db.CategoryMasters.Where(x => parentIds.Contains((int)x.ParentCategoryId)).Select(x => new Category
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                CategoryUrl = x.CategoryUrl,
                ParentCategoryId = x.ParentCategoryId
            }).OrderBy(x => x.CategoryId).ToList();

            foreach (var c in parent)
            {
                //c.ChildCategory = childs.Where(x => x.ParentCategoryId == c.CategoryId).Take(5).ToList();
                c.ChildCategory = childs.Where(x => x.ParentCategoryId == c.CategoryId && repoCategory.Contains(x.CategoryId)).Take(5).ToList();
            }

            return parent;
        }
        public List<Category> GetMainCategories()
        {
            var repoCategory = db.ReportMasters.Select(x => x.CategoryId).ToList();

            //var parent = db.CategoryMasters.Where(x => x.ParentCategoryId == 0).Select(x => new Category
            //{
            //    CategoryId = x.CategoryId,
            //    CategoryName = x.CategoryName,
            //    CategoryUrl = x.CategoryURL,
            //    ParentCategoryId = x.ParentCategoryId
            //}).ToList();

            //int[] parentIds = parent.Select(p => p.CategoryId).ToArray();

            int[] MainparentIds = new int[] { 749, 750, 751, 752, 753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 878, 1081, 1270, 1271 };


            var parent = db.CategoryMasters.Where(x => MainparentIds.Contains((int)x.CategoryId)).Select(x => new Category
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                CategoryUrl = x.CategoryUrl,
                ParentCategoryId = x.ParentCategoryId,
                Count = db.ReportMasters.Where(y => y.CategoryId == x.CategoryId).Count()
            }).OrderBy(x => x.CategoryId).ToList();

            var childs = db.CategoryMasters.Where(x => MainparentIds.Contains((int)x.ParentCategoryId)).Select(x => new Category
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                CategoryUrl = x.CategoryUrl,
                ParentCategoryId = x.ParentCategoryId,
                Count = db.ReportMasters.Where(y => y.CategoryId == x.CategoryId).Count()
            }).OrderBy(x => x.CategoryId).ToList();

            foreach (var c in parent)
            {
                //c.ChildCategory = childs.Where(x => x.ParentCategoryId == c.CategoryId).Take(5).ToList();
                c.ChildCategory = childs.Where(x => x.ParentCategoryId == c.CategoryId && repoCategory.Contains(x.CategoryId)).ToList();
            }

            return parent;
        }
    }
}