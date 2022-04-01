using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Specification
    {
        public int id { get; set; }
        [ForeignKey("product_storageid")]
        public int product_storageid { get; set; }
        [ForeignKey("product_brandid")]
        public int product_brandid { get; set; }
        [ForeignKey("product_simtyeid")]
        public int product_simtyeid { get; set; }
        [ForeignKey("product_colorid")]
        public int product_colorid { get; set; }
        [ForeignKey("product_modelnameid")]
        public int product_modelnameid { get; set; }
        [ForeignKey("product_ramid")]
        public int product_ramid { get; set; }
        [ForeignKey("product_imageid")]
        public int product_imageid { get; set; }
        public TimeZone modified_on { get; set; }
        public TimeZone created_on { get; set; }
        public string modified_by { get; set; }
        public string created_by { get; set; }
    }
}
