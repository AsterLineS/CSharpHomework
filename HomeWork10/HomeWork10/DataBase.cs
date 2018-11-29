using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class DataBase : DbContext
    {
        public DataBase() : base("OrderData")
        {
        }
        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
