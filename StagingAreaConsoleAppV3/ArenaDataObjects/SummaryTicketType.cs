using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.ArenaDataObjects
{
    public class SummaryTicketType
    {
        public int SummaryTicketTypeId { get; set; }

        public string SummaryTicketName { get; set; }

        public int TotalTickets { get; set; }

        public decimal TotalFaceValue { get; set; }

        public decimal NetCapacityPercentage { get; set; }
    }
}
