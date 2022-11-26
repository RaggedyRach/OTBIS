using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3
{
    public class W5Membership
    {
        [Key]
        public int MembershipId { get; set; }
        public string Member_Type { get; set; }
        public string Membership_scheme { get; set; }
       
        public int Membership_number { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public string Membership_status { get; set; }

        public string Cancelled { get; set; }

        public string Title { get; set; }
        public string Forename { get; set;  }
        public string Surname { get; set; }

        public string Postitle { get; set; }
        public string Company_Name { get; set; }
        public string HouseNo { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set;  }
        public string City { get; set;  }
        public string County { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }

        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string StatusDescription { get; set; }

        public string PostalConsent { get; set; }

        public string PhoneConsent { get; set; }

        public string EmailConsent { get; set; }
        public string SMSConsent { get; set; }
    }
}
