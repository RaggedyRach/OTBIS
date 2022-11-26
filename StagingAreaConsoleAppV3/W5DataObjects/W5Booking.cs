using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StagingAreaConsoleAppV3
{
    public class W5Booking
    {
        [Key]
        public int W5Booking_RefId { get; set; }    
        public string Res_Type { get; set; }
        public string resource_name { get; set; }
        public string EventName { get; set; }
        public DateTime? Booked_Date { get; set; }
        public DateTime? First_Payment_Received { get; set; }    
        public DateTime? Actual_Visit_Date { get; set; }
        public int? Actual_Visit_till_no { get; set; }

        public DateTime? Booking_Visit_Date { get; set; }
        public int Booking_ETA { get; set; }

        public decimal BookedValue { get; set; }
        public decimal ActualValue { get; set; }

        public int Booked_Child { get; set; }
        public int Actual_Child { get; set; }

        public int Booked_Adult { get; set; }

        public int Actual_Adult { get; set; }

        public string Status { get; set; }

        public string Booking_Category { get; set; }
        public string Leader { get; set; }
        public string title { get; set; }

        public string forename { get; set; }

        public string surname { get; set; }

        public string email { get; set; }
     }
}
