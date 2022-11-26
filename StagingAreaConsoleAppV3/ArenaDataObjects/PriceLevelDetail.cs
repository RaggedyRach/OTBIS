using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3.ArenaDataObjects
{
    public class PriceLevelDetail
    {
        [Key]
        public int PricLevelDetailId{ get; set; }

        public string TicketTypeName { get; set; }

        public string Qualifier1 { get; set;}

        public string Qualifier2 { get; set; }

        public string Qualifier3 { get; set; }

        public decimal FaceValue { get; set; }
        public int TotalTickeets { get; set; }

        public decimal TotalFaceValue { get; set; }

        public decimal NetCapacityPErcentage { get; set; }

        public int AgentAssistenPhone { get; set; }

        public int Internet { get; set; }

        public int PrimaryBoxOffice { get; set; }

        public int SecondaryBoxOffice { get; set; } 

        public int TAP { get; set; }

    }
}
