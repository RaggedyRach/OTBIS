using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3
{
    public class CarPark
    {

        public int Id { get; set; }
        public string ParkingNode { get; set; }
        public string TicketNumber { get; set; }
        public string NumberPlate { get; set; }

        public string MediaType { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string PNLaneEntryStation { get; set; }

        public string LaneEntryStation { get; set; }

        public DateTime? PaymentDateTime { get; set; }
        public string PaymentDeviceParkingNode { get; set; }
        public string PaymentDevice { get; set; }

        public string Currency { get; set; }
        public double? Fee { get; set; }

        public double? Validation { get; set; }

        public double? Net { get; set; }

        public double? Taxes { get; set; }

        public Char MOP { get; set; }
        public string ReceiptId { get; set; }

        public DateTime? ExitDateTime { get; set; }
        public string ParkingNodeLaneExit { get; set; }

        public string LaneExitStation { get; set; }

        public DateTime? StayTime { get; set; }

    }
}
