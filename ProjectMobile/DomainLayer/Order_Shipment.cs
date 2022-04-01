using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Order_Shipment
    {
        public int id { get; set; }
        [ForeignKey("order_details_id")]
        public int oredr_details_id { get; set; }
        [ForeignKey("product_id")]
        public int product_id { get; set; }
        public int total_price { get; set; }
        public string shipment_address { get; set; }
        public int quantity { get; set; }
        public TimeZone modified_on { get; set; }
        public TimeZone created_on { get; set; }
        public string modified_by { get; set; }
        public string created_by { get; set; }
    }
}
