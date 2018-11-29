using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
   public class OrderService
    {
        public void AddOrder(Order order)                  //添加订单
        {
            using (var db = new DataBase())
            {
                db.Order.Add(order);
                db.Configuration.ValidateOnSaveEnabled = false;
                int count = db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public void DeleteOrder(String orderId)             //删除订单
        {
            using (var db = new DataBase())
            {
                var order = db.Order.Include("Details").SingleOrDefault(o => o.Id == orderId);
                db.OrderDetails.RemoveRange(order.Details);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }

        public void ChangeOrder(Order neworder)              //修改订单
        {
            using (var db = new DataBase())
            {
                db.Order.Attach(neworder);
                db.Entry(neworder).State = EntityState.Modified;
                neworder.Details.ForEach(item => db.Entry(item).State = EntityState.Modified);
                db.SaveChanges();
            }
        }

        public Order LookForOrderI(String Id)                //根据订单号查询订单
        {
            using (var db = new DataBase())
            {
                return db.Order.Include("Details").
                SingleOrDefault(o => o.Id == Id);
            }
        }

        public Order LookForOrderN(String name)              //根据客户名查询订单
        {
            using (var db = new DataBase())
            {
                return db.Order.Include("Details").
                SingleOrDefault(o => o.CustomerName == name);
            }
        }
        public List<Order> GetAllOrders()                    //获取所有订单信息
        {
            using (var db = new DataBase())
            {
                return db.Order.Include("Details").ToList<Order>();
            }
        }
    }
}
