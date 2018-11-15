using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace exe1
{
    public class Order                          //创建订单类
    {
        public string OrderNumber { set; get; }                 //订单号
        public string CustomerName { set; get; }        //顾客名 

    }
    public class OrderDetails : Order              //创建订单详情类
    {
        public string GoodsName { set; get; }           //商品名称
        public int GoodsNumber { set; get; }       //商品数量
        public double GoodsPrice { set; get; }          //商品价格
        public string CustomerPNumber { set; get; }
        public OrderDetails(string OrderNumber, string CustomerName, string GoodsName, int GoodsNumber, double GoodsPrice, string CustomerPNumber)  //重载构造函数 对订单进行初始化
        {
            this.OrderNumber = OrderNumber;
            this.CustomerName = CustomerName;
            this.GoodsName = GoodsName;
            this.GoodsNumber = GoodsNumber;
            this.GoodsPrice = GoodsPrice;
            this.CustomerPNumber = CustomerPNumber;
        }
        public override string ToString() { return $"客户名：{CustomerName}客户手机号：{CustomerPNumber}商品名：{GoodsName}商品数量：{GoodsNumber}订单号：{OrderNumber};"; }
        public OrderDetails() { }

    }
    [Serializable]
    public class OrderService
    {
        public List<OrderDetails> OrderList = new List<OrderDetails>();

        public List<OrderDetails> orderList { get => this.OrderList; }
        //创建储存订单的列表

        public OrderService() { }
        public void AddOrder(OrderDetails first)                        //增加订单
        {
            if (first != null)
                OrderList.Add(first);
        }

        public void DeleteOrderI(string input)                              //根据订单号删除订单
        {
            int count = 0;
            if (input != null)
            {
                for (int i = 0; i < OrderList.Count; i++)
                {
                    if (input == OrderList[i].OrderNumber)
                    {
                        OrderList.Remove(OrderList[i]);
                        count++;
                    }
                }
            }
            if (count == 0)
            { Console.WriteLine("未查到该订单！！删除错误！！！"); Console.WriteLine(); }
        }
        public void DeleteOrderN(string inname)                          //根据商品名称或者顾客名删除订单
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

        public void ChangeOrder(string input, int newNumber, string newName)               //根据订单号修改订单的商品数量
        {
            int count = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (input == OrderList[i].OrderNumber)
                {
                    OrderList[i].GoodsNumber = newNumber;
                    OrderList[i].GoodsName = newName;
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
        public void LookForOrderByLinq(string input)                                   //根据订单号进行查询(Linq语句)
        {
            var selorder = from n in OrderList where n.OrderNumber == input select n;
            foreach (var n in selorder)
            {
                Console.Write(" 商品名称是： " + n.GoodsName + " 商品数量是： " + n.GoodsNumber + " 商品价格是： " + n.GoodsPrice);
            }

        }
        public void LookForOrderByLinqS(string inname)                               //根据客户名或者商品名查找订单（Linq语句）
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
        public OrderDetails LookForOrderI(string input)                             //根据订单号进行查询
        {

            int a = 0;
            if (input == null) return null;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (input == OrderList[i].OrderNumber)
                {
                    a = i;
                }

            }
            return OrderList[a];

        }
        public OrderDetails LookForOrderS(string name)                             //根据订单号进行查询
        {
            int a = 0;
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (name == OrderList[i].CustomerName)
                {
                    a = i;
                }

            }
            return OrderList[a];
        }

        //XML序列化
        public void Export(string filename, object obj)
        {
            XmlSerializer xmler = new XmlSerializer(typeof(List<OrderDetails>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmler.Serialize(fs, obj);
                fs.Close();
            }
        }
        //XML反序列化
        public void Import(string filename)
        {
            XmlSerializer xmler = new XmlSerializer(typeof(List<OrderDetails>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<OrderDetails> ol = (List<OrderDetails>)xmler.Deserialize(fs);
                ol.ForEach(o => Console.WriteLine(o.ToString()));
            }
        }
        public override string ToString()
        {
            string result = " ";
            for (int i = 0; i < orderList.Count; i++)
            {
                result += "订单号： " + orderList[i].OrderNumber + " 客户名： " + orderList[i].CustomerName + " 商品名： " + orderList[i].GoodsName + " 商品数量： " + orderList[i].GoodsNumber + " 商品价格： " + orderList[i].GoodsPrice + "\n";
            }
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails FirstOrder = new OrderDetails("2018/11/13/001", "JX1", "一点点", 1, 1.5, "125-5211-3142");         //初始化订单
            OrderDetails SecondOrder = new OrderDetails("2018/11/13/002", "JX2", "两点点", 2, 2.5, "134-5211-3142");
            OrderDetails ThirdOrder = new OrderDetails("2018/11/13/003", "JX3", "三点点", 3, 3.5, "125-5211-3142");
            OrderDetails FourthOrder = new OrderDetails("2018/11/13/004", "JX4", "四点点", 4, 4.5, "521-5211-3142");

            Regex rx = new Regex("[0-9]{3}-[0-9]{4}-[0-9]{4}");
            string u = "123-1234-1234";
            bool l = rx.IsMatch(u);
            OrderService Oporder = new OrderService();

            Oporder.AddOrder(FirstOrder);                     //添加订单
            Oporder.AddOrder(SecondOrder);
            Oporder.AddOrder(ThirdOrder);
            Oporder.AddOrder(FourthOrder);


            Oporder.Export("a.xml", Oporder.OrderList);

            Oporder.Import("a.xml");

            //Oporder.DeleteOrder(06);                         //删除指定订单
            //Oporder.ChangeOrder("JX1", 5);                   //修改商品数量

            //Oporder.LookForOrder("一点点");                  //查找指定订单

            //for (int i = 0; i < Oporder.OrderList.Count; i++)
            //{
            //    Console.Write(" 商品名称是： " + Oporder.OrderList[i].GoodsName + " 商品数量是： " + Oporder.OrderList[i].GoodsNumber + " 商品价格是： " + Oporder.OrderList[i].GoodsPrice);
            //    Console.WriteLine();
            //}

            Console.WriteLine();
        }
    }
}
