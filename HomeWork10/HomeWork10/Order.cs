using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Order
    {
        [Key]
        public String Id { get; set; }
        public String CustomerName { get; set; }
        public DateTime DateTime { get; set; }
        public List<OrderDetails> Details { get; set; }

        public Order()
        {
            Details = new List<OrderDetails>();
        }

        public Order(string id, string customer, DateTime createTime, List<OrderDetails> items)
        {
            this.Id = id;
            this.CustomerName = customer;
            this.DateTime = createTime;
            this.Details = items;
        }
    }
}
