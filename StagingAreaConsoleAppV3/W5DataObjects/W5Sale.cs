using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StagingAreaConsoleAppV3
{
    public class W5Sale
    {
        [Key]
        public int? W5SaleId { get; set; }
        public string Branch { get; set; }
        public int? Sale_ref { get; set; }
        public string SessionNo { get; set; }
        public int? TillID { get; set; }

        public string Staff { get; set; }
        public int? Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public int Week { get; set; }
        public DateTime? Weekstart { get; set; }

        public int? Hour { get; set; }
        public string Slot { get; set; }
        public DateTime? Tran_Date { get; set; }

        public string TranTime { get; set; }

        public DateTime? Visit_Date { get; set; }
        public int? PLU { get; set; }

        public string privateDesc { get; set; }

        public string Department { get; set; }

        public string Catagory { get; set; }

        public string SubCatagory { get; set; }
        public string Supplier { get; set; }

        public decimal? cost_price { get; set; }

        public int? Qty_Sold { get; set; }

        public decimal? price_paid { get; set; }

        public decimal? vatAmt { get; set; }
        public decimal? Gross_line_Total { get; set; }
        public decimal? Vat_line { get; set; }

        public decimal? Net_line { get; set; }
        public char? VatCode { get; set; }

        public int? VatRate { get; set; }

        public string Vat_description { get; set; }

        public string DiscountType{ get; set; }

        public string VoucherName {get; set;}

        public string SystemDiscount_Name { get; set; }

        public decimal? Discount_value { get; set; }
        public decimal? Selling_Price { get; set;}
        public string Payment_Method { get; set; }
        public int? nominal { get; set; }

        public int? PersonId { get; set;  }
        public int? Adults { get; set; }
        public int? Children { get; set; }

        public string Voucher_reference { get; set; }

        


    }
}
