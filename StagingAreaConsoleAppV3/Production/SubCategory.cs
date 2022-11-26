using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.Production
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        public string SubCategoryName { get; set; }

        public int? CategoryId { get; set; }
    }
}
