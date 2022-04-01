using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public  class Product
    {
        public int id { get; set; }
        [ForeignKey("specification_id")]
        public int specification_id { get; set; }
        public string product_type { get; set; }
        public string product_name { get; set; }
        public int product_price { get; set; }
        public string product_model { get; set; }
        public string image { get; set; }                            
        public string discription { get; set; }
        public bool isActive { get; set; }
        public TimeZone modified_by { get; set; }
        public TimeZone modified_on { get; set; }
        public TimeZone created_on { get; set; }
        public TimeZone created_by { get; set; }
        public TimeZone deleted_by { get; set; }
    }
}
