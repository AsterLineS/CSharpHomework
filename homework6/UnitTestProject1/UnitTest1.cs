using Microsoft.VisualStudio.TestTools.UnitTesting;
using exe1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestProject1
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService Oporder = new OrderService();
        OrderDetails first = new OrderDetails(3, "C#", "Language", 12, 12);
        OrderDetails second = new OrderDetails(4, "Java", "Class", 21, 21);
        [TestMethod()]
        public void AddOrderTest()
        {
            Oporder.AddOrder(first);
            Oporder.AddOrder(second);
            Assert.IsTrue("C#" == Oporder.OrderList[0].CustomerName);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            Oporder.AddOrder(first);
            Oporder.AddOrder(second);
            Oporder.DeleteOrder(3);
            Assert.IsTrue(1 == Oporder.OrderList.Count);
        }

        [TestMethod()]
        public void DeleteOrderTest1()
        {
            Oporder.AddOrder(first);
            Oporder.AddOrder(second);
            Oporder.DeleteOrder("Java");
            Assert.IsTrue(1 == Oporder.OrderList.Count);
        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            Oporder.AddOrder(first);
            Oporder.AddOrder(second);
            Oporder.ChangeOrder("C#", 3);
            Assert.IsTrue(3 == Oporder.OrderList[0].GoodsNumber);
        }

        [TestMethod()]
        public void ChangeOrderTest1()
        {
            Oporder.AddOrder(first);
            Oporder.AddOrder(second);
            Oporder.ChangeOrder("Language", 3);
            Assert.IsTrue(3 == Oporder.OrderList[0].GoodsNumber);
        }
    }
}