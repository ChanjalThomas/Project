using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Product_Brand
    {
        public int id { get; set; }
        public string brand_name { get; set; }
        public TimeZone modified_on { get; set; }
        public TimeZone created_on { get; set; }
        public string modified_by { get; set; }
        public string created_by { get; set; }
    }
}
