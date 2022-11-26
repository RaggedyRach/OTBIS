using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3
{
    public class W5SalesSummary
    {
        [Key]
        public int W5salesSummaryId { get; set; }
        public int? Code { get; set; }

        public string Description { get; set; }
        public int? Quantity { get; set; }

        public int VisitorQuantity { get; set;}
        public decimal? NetValue { get; set; }

        public decimal? VAT    { get; set; }
        public decimal? Gross { get; set; }
        public decimal? Cost { get; set; }

        public decimal? Profit { get; set; }
        public decimal? Profit_Percent { get; set; }

    }
}
