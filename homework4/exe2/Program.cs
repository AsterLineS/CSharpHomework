using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe2
{
    using System;
    public class OrderService       //订单服务
    {
        public string No;  //订单号
        public string Name; //客户
        public string Num;  //数目
        public string Item; //商品名称
        public double Price; //商品价格

        public OrderService() { }
        public OrderService(string no, string name, string num, string item, double price)
        {
            No = no;
            Name = name;
            Num = num;
            Item = item;
            Price = price;
        }
        public static List<OrderService> orderData = new List<OrderService>();

    }

  
    public class Order : OrderService
    {
        public void AddOld(OrderService temp)
        {
            orderData.Add(temp);
        }
        public void AddNew()
        {
            string no, name, item, num, str;
            double price;
            Console.WriteLine("请输入：订单号、客户、商品名称、数量、价格");
            no = Console.ReadLine();
            name = Console.ReadLine();
            item = Console.ReadLine();
            num = Console.ReadLine();
            str = Console.ReadLine();
            price = Convert.ToDouble(str);
            OrderService temp = new OrderService(no, name, item, num, price);
            orderData.Add(temp);
            Console.WriteLine("添加成功！");
        }      //添加
        public void Remove(string temp)
        {
            bool iSearch = false;
            for (int i = 0; i < orderData.Count; i++)
            {
                if ((temp == orderData[i].No) || (temp == orderData[i].Name) || (temp == orderData[i].Item))
                {
                    iSearch = true;
                    orderData.RemoveAt(i);
                    Console.WriteLine("删除成功！");
                }
            }
            if (false == iSearch)
            {
                Console.WriteLine("没有找到要删除的元素！");
            }
        }     //删除
        public void Revise(string str1, string str2)
        {
            bool iSearch = false;
            for (int i = 0; i < orderData.Count; i++)
            {
                if (str1 == orderData[i].Name)
                {
                    orderData[i].Name = str2;
                    iSearch = true;
                }
                else if (str1 == orderData[i].Num)
                {
                    orderData[i].Num = str2;
                    iSearch = true;
                }
                else if (str1 == orderData[i].Item)
                {
                    orderData[i].Item = str2;
                    iSearch = true;
                }
            }
            if (false == iSearch)
            {
                Console.WriteLine("找不到要更改的数据！");
            }
            else
            {
                Console.WriteLine("更改成功！");
            }
        }  //修改
        public void Search(string temp)
        {
            bool iSearch = false;
            for (int i = 0; i < orderData.Count; i++)
            {
                if ((temp == orderData[i].No) || (temp == orderData[i].Name) || (temp == orderData[i].Item))
                {
                    iSearch = true;
                    Console.WriteLine("查找成功！");
                    Console.WriteLine(orderData[i].No + "\t" + orderData[i].Name + "\t" + orderData[i].Item
                        + "\t" + orderData[i].Num + "\t" + orderData[i].Price);
                }
            }
            if (false == iSearch)
            {
                Console.WriteLine("没有找到需查询的数据！");
            }
        }   //查找
    }

    
    public class OrderDetails : OrderService
    {
        public OrderDetails() { }
        public OrderDetails(string temp)
        {
            bool iSearch = false;
            for (int i = 0; i <= orderData.Count; i++)
            {
                if ((temp == orderData[i].No) || (temp == orderData[i].Name) || (temp == orderData[i].Item))
                {
                    Console.WriteLine(orderData[i].Item + "\t" + orderData[i].Num + "\t" + orderData[i].Price);
                    iSearch = true;
                }
            }
            if (false == iSearch)
            {
                Console.WriteLine("没有此条订单！");
            }
        }
        public void ShowOrder()
        {
            Console.WriteLine("以下是所有订单：");
            for (int i = 0; i < orderData.Count; i++)
            {
                Console.WriteLine(orderData[i].No + "\t" + orderData[i].Name + "\t" + orderData[i].Item
                    + "\t" + orderData[i].Num + "\t" + orderData[i].Price);
            }
        }
    }
    public class program
    {
        public static void Main(string[] args)
        {

            OrderService p1 = new OrderService("2412322", "asd", "1", "iphoneX", 5687);
            OrderService p2 = new OrderService("5623523", "qwe", "2", "iphoneXS", 12345);
            Order temp1 = new Order();
            OrderDetails temp2 = new OrderDetails();

            temp1.AddOld(p1);  //添加已有订单
            temp1.AddOld(p2);
            temp2.ShowOrder();         //显示全部订单

            string temp3 = "qwe";
            temp1.Remove(temp3);        //删除订单
            temp2.ShowOrder();         //显示全部订单

            temp1.AddNew();        //添加新订单
            temp2.ShowOrder();         //显示全部订单

            string temp4 = "rqw";
            string temp5 = "asdfg";
            temp1.Revise(temp4, temp5);   //修改订单
            temp2.ShowOrder();         //显示全部订单

            temp1.Search(temp3);
        }
    }
}