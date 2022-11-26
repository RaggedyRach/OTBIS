using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.ArenaDataObjects
{
    public class SummarySalesChannel
    {
        public int SummarySalesChannelId { get; set; }
        public string SummarySalesChannelName { get; set; }

        public int TotalTickets { get; set; }

        public decimal TotalFaceValue { get; set; }

        public decimal NetCapacityPercentage { get; set; }
    }
}
