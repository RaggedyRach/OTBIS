using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.ArenaDataObjects
{
    public class Inquiry
    {
        public int InquiryId { get; set; }
        public string Inventory { get; set; }
        public int TotalTickets { get; set; }   
        public int GA { set; get; }

        public int Price1 { get; set; }
        public int Price2 { get; set; }
        public int Disa { set; get; }

    }
}
