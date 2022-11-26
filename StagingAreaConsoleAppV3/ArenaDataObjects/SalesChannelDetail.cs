using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.ArenaDataObjects
{
    public class SalesChannelDetail
    {
        public int SalesChannelDetailId { get; set; }
        public string SalesChannelDetailName { get; set; }
        public string TicketTypeName { get; set; }
        public string Qualifier1 { get; set; }

        public string Qualifier2 { get; set; }
        public string Qualifier3 { get; set; }
        public int TotalTickets { get; set; }

        public decimal TotalFaceValue { get; set; }

        public decimal NetCapacityPercentage { get; set; }

        public int GA {get; set;}
        public int Price1 {get; set;}

        public int Price2 { get; set;}
        public int Price3 { get; set;}

        public int Disa { get; set; }

        public int SWest { get; set; }





    }
}
