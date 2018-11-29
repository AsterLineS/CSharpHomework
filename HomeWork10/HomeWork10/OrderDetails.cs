using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class OrderDetails
    {
        [Key]
        public string Id { get; set; }
        public string GoodsName { get; set; }
        public double GoodPrice { get; set; }
        public int GoodsNumber { get; set; }


        public OrderDetails()
        {
            Id = Guid.NewGuid().ToString();
        }

        public OrderDetails(string id, string name, double price, int number)
        {
            Id = id;
            GoodsName = name;
            GoodPrice = price;
            GoodsNumber = number;
        }
    }
}
