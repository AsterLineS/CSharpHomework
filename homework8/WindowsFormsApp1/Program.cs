using exe1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// 
        /// 
        /// 
        /// </summary>


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

    }

    public partial class FormMain : Form
    {
        OrderService Oporder;
        BindingSource fieldsBS = new BindingSource();
        public FormMain()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {

            OrderDetails FirstOrder = new OrderDetails("2018/11/13/001", "JX1", "一点点", 1, 1.5, "125-2111-3142");         //初始化订单
            OrderDetails SecondOrder = new OrderDetails("2018/11/13/002", "JX2", "两点点", 2, 2.5, "134-5211-3142");
            OrderDetails ThirdOrder = new OrderDetails("2018/11/13/003", "JX3", "三点点", 3, 3.5, "125-5211-3142");
            OrderDetails FourthOrder = new OrderDetails("2018/11/13/004", "JX4", "四点点", 4, 4.5, "521-5211-3142");
            Oporder = new OrderService();

            Oporder.AddOrder(FirstOrder);
            Oporder.AddOrder(SecondOrder);
            Oporder.AddOrder(ThirdOrder);
            Oporder.AddOrder(FourthOrder);

        }

        private void AddOrder()
        {
            AddOrder addform = new AddOrder();
            addform.ShowDialog();
            OrderDetails newOdetail = addform.GetOrderI();
            if (newOdetail != null)
            {
                Oporder.OrderList.Add(newOdetail);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddOrder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void ChangeOrder()           //修改订单
        {
            ChangeOrder changeform = new ChangeOrder();
            changeform.ShowDialog();
            OrderDetails newOdetail = changeform.GetOrderI();
            for (int i = 0; i < Oporder.OrderList.Count; i++)
            {
                if (newOdetail != null && newOdetail.OrderNumber == Oporder.OrderList[i].OrderNumber)
                {
                    Oporder.OrderList[i] = newOdetail;
                }
            }
        }
        private void LookForOrder()          //查找订单
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    OrderDetailbindingSource1.DataSource = Oporder.OrderList;
                    break;
                case 1:
                    OrderDetailbindingSource1.DataSource = Oporder.LookForOrderI(textBox2.Text);
                    break;
                case 2:
                    OrderDetailbindingSource1.DataSource = Oporder.LookForOrderS(textBox2.Text);
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)      //查找订单信息
        {
            LookForOrder();
        }
        private void button7_Click(object sender, EventArgs e)      //删除订单
        {
            panel1.Visible = false;
            string delete = textBox3.Text;
            Oporder.DeleteOrderI(delete);
        }
        private void button4_Click(object sender, EventArgs e)      //修改订单
        {
            ChangeOrder();
        }

        public ArrayList JudgePNumber()                          //验证客户手机号是否正确
        {
            ArrayList Array = new ArrayList();
            Regex rx = new Regex("[0-9]{3}-[0-9]{4}-[0-9]{4}");
            for (int i = 0; i < Oporder.OrderList.Count; i++)
            {
                bool ok = rx.IsMatch(Oporder.OrderList[i].CustomerPNumber);
                if (ok == false)
                {
                    int j = i + 1;
                    Array.Add(j);
                }
            }
            return Array;
        }
        public ArrayList JudgeOrderNumber()                     //验证订单号是否正确
        {
            ArrayList Array = new ArrayList();
            Regex rx = new Regex("[0-9]{4}/[0-9]{2}/[0-9]{2}/[0-9]{3}");
            for (int i = 0; i < Oporder.OrderList.Count; i++)
            {
                bool ok = rx.IsMatch(Oporder.OrderList[i].OrderNumber);
                if (ok == false)
                {
                    int j = i + 1;
                    Array.Add(j);
                }
            }
            return Array;
        }
        private void button6_Click(object sender, EventArgs e) //生成html文件按钮
        {
            ExportHTML();
        }
        public void ExportHTML()                               //输出成html文件
        {
            Oporder.Export("a.xml", Oporder.OrderList);
            XslCompiledTransform trans = new XslCompiledTransform();
            trans.Load(@"G:\virsual studio\C#source\homework7\WindowsFormsApp1\XSLTFile1.xslt");
            trans.Transform(@"G:\virsual studio\C#source\homework7\exe1\bin\Debug\a.xml", @"G:\virsual studio\C#source\homework7\exe1\bin\Debug\out.html");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList h1 = JudgePNumber();
            ArrayList h2 = JudgeOrderNumber();

            if (h1.Count != 0)
            {
                textBox1.Visible = true;
                for (int i = 0; i < h1.Count; i++)
                {
                    textBox1.Text += "第" + h1[i] + "个订单的手机号出现了问题！！！！" + "\n";
                }
                if (h2.Count != 0)
                {
                    for (int j = 0; j < h2.Count; j++)
                    {
                        textBox1.Text += "第" + h2[j] + "个订单的订单号出现了问题！！！！";
                    }
                }
            }
            else if (h2.Count != 0)
            {
                textBox1.Visible = true;
                for (int j = 0; j < h2.Count; j++)
                {
                    textBox1.Text += "第" + h2[j] + "个订单的订单号出现了问题！！！！";
                }
            }
            else
            {
                textBox1.Text = "所有订单的订单号及手机号均正确！！！";
                textBox1.Visible = true;
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public partial class ChangeOrder : Form
    {
        OrderDetails changeOrder = null;
        public ChangeOrder()
        {
            InitializeComponent();
        }
        public OrderDetails GetOrderI()
        {
            if (changeOrder != null)
                return changeOrder;
            else
                return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string OrderNum = textBox1.Text;
            string Goodsname = textBox2.Text;
            string CustomerName = textBox5.Text;
            string GoodsNum = textBox3.Text;
            int goodnum = int.Parse(GoodsNum);
            string CustomerPNumber = textBox4.Text;
            double a = 1.00;
            changeOrder = new OrderDetails(OrderNum, CustomerName, Goodsname, goodnum, a, CustomerPNumber);
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public partial class AddOrder : Form
    {
        OrderDetails newO = null;

        public AddOrder()
        {
            InitializeComponent();
        }
        public OrderDetails GetOrderI()
        {

            return newO;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GoodsName = textBox1.Text;
            string s2 = textBox2.Text;
            int GoodsNumber = int.Parse(s2);
            string s3 = textBox3.Text;
            double GoodsPrice = double.Parse(s3);
            string CustomerName = textBox4.Text;
            string s4 = textBox5.Text;
            string s5 = textBox6.Text;
            newO = new OrderDetails(s4, CustomerName, GoodsName, GoodsNumber, GoodsPrice, s5);

            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }
    }
}