using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe1
{
    public class Order                          //创建订单类
    {
        public int OrderNumber;                 //订单号
        public string CustomerName;             //顾客名 
    }

    public class OrderDetails : Order              //创建订单详情类
    {
        public string GoodsName { get; }           //商品名称
        public int GoodsNumber { set; get; }       //商品数量
        public double GoodsPrice { get; }          //商品价格
        public OrderDetails(int OrderNumber, string CustomerName, string GoodsName, int GoodsNumber, double GoodsPrice)  //重载构造函数 对订单进行初始化
        {
            this.OrderNumber = OrderNumber;
            this.CustomerName = CustomerName;
            this.GoodsName = GoodsName;
            this.GoodsNumber = GoodsNumber;
            this.GoodsPrice = GoodsPrice;
        }

    }

    public class OrderService
    {
        List<OrderDetails> OrderList = new List<OrderDetails>();        //创建储存订单的列表

        public void AddOrder(OrderDetails first)                        //增加订单
        {
            OrderList.Add(first);
        }

        public void DeleteOrder(int input)                              //根据订单号删除订单
        {
            int count = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (input == OrderList[i].OrderNumber)
                {
                    OrderList.Remove(OrderList[i]);
                    count++;
                }
            }
            if (count == 0)
            { Console.WriteLine("未查到该订单！！删除错误！！！"); Console.WriteLine(); }
        }
        public void DeleteOrder(string inname)                          //根据商品名称或者顾客名删除订单
        {
            int count = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (inname == OrderList[i].CustomerName || inname == OrderList[i].GoodsName)
                {
                    OrderList.Remove(OrderList[i]);
                    count++;
                }
            }
            if (count == 0)
            { Console.WriteLine("未查到该订单！！删除错误！！！"); Console.WriteLine(); }
        }

        public void ChangeOrder(int input, int newNumber)               //根据订单号修改订单的商品数量
        {
            int count = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (input == OrderList[i].OrderNumber)
                {
                    OrderList[i].GoodsNumber = newNumber;
                    count++;
                }
            }
            if (count == 0)
            { Console.WriteLine("未查找到该商品！！修改错误！！！"); Console.WriteLine(); }
        }
        public void ChangeOrder(string input, int newNumber)            //根据客户名或者商品名修改订单的商品数量
        {
            int count = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (input == OrderList[i].CustomerName || input == OrderList[i].GoodsName)
                {
                    OrderList[i].GoodsNumber = newNumber;
                    count++;
                }
            }
            if (count == 0)
            { Console.WriteLine("未查找到该商品！！修改错误！！！"); Console.WriteLine(); }
        }

        //    Homework5      用Linq实现订单查询功能   
        public void LookForOrderByLinq(int input)                                   //根据订单号进行查询(Linq语句)
        {
            var selorder = from n in OrderList where n.OrderNumber == input select n;
            foreach (var n in selorder)
            {
                Console.Write(" 商品名称是： " + n.GoodsName + " 商品数量是： " + n.GoodsNumber + " 商品价格是： " + n.GoodsPrice);
            }

        }
        public void LookForOrderByLinq(string inname)                               //根据客户名或者商品名查找订单（Linq语句）
        {
            var selorder = from n in OrderList where n.CustomerName == inname || n.GoodsName == inname select n;
            foreach (var n in selorder)
            {
                Console.Write(" 商品名称是： " + n.GoodsName + " 商品数量是： " + n.GoodsNumber + " 商品价格是： " + n.GoodsPrice);
            }

        }
        public void LookOrByLinq()
        {
            var selorder = from n in OrderList where n.GoodsNumber * n.GoodsPrice > 10000 select n;          //订单价格大于一万（Linq语句）
            foreach (var n in selorder)
            {
                Console.Write(" 商品名称是： " + n.GoodsName + " 商品数量是： " + n.GoodsNumber + " 商品价格是： " + n.GoodsPrice);
            }
        }

        //HomeWork5 用Linq实现相关功能*/
        public void LookForOrder(string inname)                         //根据客户名或者商品名查找订单
        {
            int count = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (inname == OrderList[i].CustomerName || inname == OrderList[i].GoodsName)
                {
                    Console.Write(" 商品名称是： " + OrderList[i].GoodsName + " 商品数量是： " + OrderList[i].GoodsNumber + " 商品价格是： " + OrderList[i].GoodsPrice);
                    Console.WriteLine();
                    count++;
                }
            }
            if (count == 0)
            { Console.WriteLine("未找到该订单！！"); Console.WriteLine(); }

        }
        public void LookForOrder(int input)                             //根据订单号进行查询
        {
            int count = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (input == OrderList[i].OrderNumber)
                {
                    Console.Write(" 商品名称是： " + OrderList[i].GoodsName + " 商品数量是： " + OrderList[i].GoodsNumber + " 商品价格是： " + OrderList[i].GoodsPrice);
                    Console.WriteLine();
                    count++;
                }
            }
            if (count == 0)
            { Console.WriteLine("未找到该订单！！"); Console.WriteLine(); }
        }
        static void Main()
        {
            OrderDetails FirstOrder = new OrderDetails(01, "123", "iphone6", 1, 5000);         //初始化订单
            OrderDetails SecondOrder = new OrderDetails(02, "124", "iphone7", 2, 6000);
            OrderDetails ThirdOrder = new OrderDetails(03, "125", "iphone8", 3, 7000);
            OrderDetails FourthOrder = new OrderDetails(04, "126", "iphonex", 4, 8000);


            OrderService Oporder = new OrderService();

            Oporder.AddOrder(FirstOrder);                     //添加订单
            Oporder.AddOrder(SecondOrder);
            Oporder.AddOrder(ThirdOrder);
            Oporder.AddOrder(FourthOrder);

            Oporder.DeleteOrder(06);                         //删除指定订单


            Oporder.ChangeOrder("123", 5);                   //修改商品数量

            Oporder.LookForOrder("iphonex");                  //查找指定订单

            for (int i = 0; i < Oporder.OrderList.Count; i++)
            {
                Console.Write(" 商品名称是： " + Oporder.OrderList[i].GoodsName + " 商品数量是： " + Oporder.OrderList[i].GoodsNumber + " 商品价格是： " + Oporder.OrderList[i].GoodsPrice);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}