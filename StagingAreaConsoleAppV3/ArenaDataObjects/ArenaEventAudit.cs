using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3
{
    public class ArenaEventAudit
    {
        public int ArenaEventAuditId { get; set; }
        public string EventTitle { get; set; }  
        public string   EventCode   { get; set; }   
        public DateTime DataAsAt { get; set; }
        public int TotalTickets { get; set; }

        public int NetCapacity { get; set; }
        public decimal RetailAvailability { get; set; } 
        public decimal TotalFaceValue { get; set; }
        public decimal Potential { get; set; }
        public int Sold { get; set; }
        public decimal SoldPercentage { get; set; }
        public int Comps { get; set; }
        public decimal CompsPercentage { get; set; }

        public int PrePrints { get; set; }

        public decimal PrePrintsPercentage { get; set; }    

        public int Holds { get; set; }
        public decimal HoldsPercentage { get; set; }
    
        public int Opens { get; set; }

        public decimal OpensPercentage { get; set; }

        public int Inquiry { get; set; }
        public decimal InquiryPercentage { get; set; }  

     

        public int TotalTicketsSoldToday { get; set; }
        public decimal TotalFaceValueToday { get; set; }
    }
}
