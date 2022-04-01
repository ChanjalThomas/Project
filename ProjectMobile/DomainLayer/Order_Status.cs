using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Order_Status
    {
        public int id { get; set; }
        [ForeignKey("order_id")]
        public int order_id { get; set; }
        public enum dispatched { get; set; }
        public enum delivered { get; set; }
        public enum cancelled { get; set; }
        public enum completed { get; set; }
        public TimeZone modified_on { get; set; }
        public TimeZone created_on { get; set; }
        public string modified_by { get; set; }
        public string created_by { get; set; }
    }
}
