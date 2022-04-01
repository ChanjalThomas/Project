using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class User
    {
        public int id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool isActive { get; set; }
        public TimeZone modified_on { get; set; }
        public TimeZone created_on { get; set; }
        public string modified_by { get; set; }
        public string created_by { get; set; }
    }
}
