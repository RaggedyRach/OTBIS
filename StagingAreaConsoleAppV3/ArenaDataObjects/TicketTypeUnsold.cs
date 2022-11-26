using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.ArenaDataObjects
{
    public class TicketTypeUnsold
    {
        [Key]
        public int TicketTypeId { get; set; }
        public string TicketType { get; set; }
        public string Qualifier1 { get; set; }
        public string Qualifier2 { get; set; }
        public string Qualifier3 { get; set; }
        public int TotalUnsold { get; set; }
        public decimal Potential { get; set; }

        public int GA { get; set; }
        public int Price1 { get; set; }
        public int Price2 { get; set; }

        public int Price3 { get; set; }
        public int Disa { get; set; }

        public int SWEST { get; set; }
        public int six { get; set; }
        public int seven { get; set; }


    }
}
