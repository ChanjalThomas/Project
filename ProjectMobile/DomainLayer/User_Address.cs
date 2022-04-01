using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class User_Address
    {
        public int id { get; set; }
        [ForeignKey("user_id")]
        public int user_id { get; set; }
        public string address_line { get; set; }
        public int postal_code { get; set; }
        public string country { get; set; }
        public int mobile_number { get; set; }
        public TimeZone modified_on { get; set; }
        public TimeZone created_on { get; set; }
        public string modified_by { get; set; }
        public string created_by { get; set; }
    }
}
