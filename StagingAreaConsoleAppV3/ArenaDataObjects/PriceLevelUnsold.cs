using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.ArenaDataObjects
{
    public class PriceLevelUnsold
    {
        public int PriceLevelUnsoldId { get; set; }
        public string Price { get; set; }
        public string TicketType { get; set; }
    
        public string Qualifier1 { get; set; }

        public string Qualifier2 { get; set; }
        public string Qualifier3 { get; set; }

        public int TotalUnsold { get; set;}

        public decimal NetCapacityPercent { get; set; } 
    }
}
