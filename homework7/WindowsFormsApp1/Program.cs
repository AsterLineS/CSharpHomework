using exe1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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
            OrderDetails FirstOrder = new OrderDetails(01, "123", "iphone6", 1, 5000);         //初始化订单
            OrderDetails SecondOrder = new OrderDetails(02, "124", "iphone7", 2, 6000);
            OrderDetails ThirdOrder = new OrderDetails(03, "125", "iphone8", 3, 7000);
            OrderDetails FourthOrder = new OrderDetails(04, "126", "iphonex", 4, 8000);



            OrderService OList = new OrderService();

            OList.OrderList.Add(FirstOrder);                                                //添加订单
            OList.OrderList.Add(SecondOrder);
            OList.OrderList.Add(ThirdOrder);
            OList.OrderList.Add(FourthOrder);

            Form form1 = new Form();

            ///创建各种控件
            Panel panel1 = new System.Windows.Forms.Panel();
            Label label4 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            Button button1 = new System.Windows.Forms.Button();
            TextBox textBox4 = new System.Windows.Forms.TextBox();
            TextBox textBox3 = new System.Windows.Forms.TextBox();
            TextBox textBox2 = new System.Windows.Forms.TextBox();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            Button button2 = new System.Windows.Forms.Button();
            Button button3 = new System.Windows.Forms.Button();
            TextBox textBox5 = new System.Windows.Forms.TextBox();
            Button button4 = new System.Windows.Forms.Button();
            Button button5 = new System.Windows.Forms.Button();
            Label box = new System.Windows.Forms.Label();
            Label label5 = new System.Windows.Forms.Label();
            TextBox textBox6 = new System.Windows.Forms.TextBox();
            Label label6 = new System.Windows.Forms.Label();
            Label label7 = new System.Windows.Forms.Label();
            Button button6 = new System.Windows.Forms.Button();
            TextBox textBox7 = new System.Windows.Forms.TextBox();
            TextBox textBox8 = new System.Windows.Forms.TextBox();
            Panel panel3 = new System.Windows.Forms.Panel();
            Label label8 = new System.Windows.Forms.Label();
            TextBox textBox9 = new System.Windows.Forms.TextBox();
            Button button7 = new System.Windows.Forms.Button();
            Panel panel2 = new System.Windows.Forms.Panel();

            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            form1.SuspendLayout();

            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new System.Drawing.Point(117, 46);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(376, 218);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "商品价格：";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 123);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "客户名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 15);
            label2.TabIndex = 6;
            label2.Text = "商品数量：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "商品名字：";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(33, 161);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 39);
            button1.TabIndex = 4;
            button1.Text = "完成添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(91, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(91, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(91, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 25);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(91, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox6);
            panel2.Location = new System.Drawing.Point(102, 496);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(391, 208);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            panel2.Paint += new System.Windows.Forms.PaintEventHandler(panel2_Paint);
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            button2.Location = new System.Drawing.Point(117, 283);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(183, 61);
            button2.TabIndex = 2;
            button2.Text = "添加订单";
            button2.FlatStyle = FlatStyle.Flat;//样式
            button2.FlatAppearance.BorderSize = 0;//去边线
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;//鼠标经过
            button2.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;//鼠标按下
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            button3.Location = new System.Drawing.Point(335, 283);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(193, 61);
            button3.TabIndex = 3;
            button3.Text = "显示订单信息";
            button3.FlatStyle = FlatStyle.Flat;//样式
            button3.FlatAppearance.BorderSize = 0;//去边线
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;//鼠标经过
            button3.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;//鼠标按下

            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);

            // 
            // textBox5
            // 
            textBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            textBox5.Location = new System.Drawing.Point(569, 242);
            textBox5.Name = "textBox5";
            textBox5.Multiline = true;
            textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox5.Size = new System.Drawing.Size(648, 354);
            textBox5.TabIndex = 4;
            textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox5.TextChanged += new System.EventHandler(textBox5_TextChanged);
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            button4.Location = new System.Drawing.Point(117, 415);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(193, 61);
            button4.TabIndex = 5;
            button4.FlatStyle = FlatStyle.Flat;//样式
            button4.FlatAppearance.BorderSize = 0;//去边线
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;//鼠标经过
            button4.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;//鼠标按下
            button4.Text = "删除订单";
            button4.Click += new System.EventHandler(button4_Click);
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            button5.Location = new System.Drawing.Point(335, 415);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(183, 61);
            button5.TabIndex = 6;
            button5.FlatStyle = FlatStyle.Flat;//样式
            button5.FlatAppearance.BorderSize = 0;//去边线
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;//鼠标经过
            button5.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;//鼠标按下
            button5.Text = "修改订单";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(button5_Click);
            // 
            // 显示框
            // 
            box.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            box.Location = new System.Drawing.Point(564, 167);
            box.Name = "显示框";
            box.Size = new System.Drawing.Size(176, 61);
            box.TabIndex = 7;
            box.Text = "显示框：";
            box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            box.Click += new System.EventHandler(显示框_Click);
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label5.Location = new System.Drawing.Point(-2, 20);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label5.Size = new System.Drawing.Size(280, 50);
            label5.TabIndex = 0;
            label5.Text = "请输入想要修改的订单号：";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(276, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(100, 25);
            textBox6.TabIndex = 1;
            textBox6.TextChanged += new System.EventHandler(textBox6_TextChanged);
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(136, 70);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(170, 35);
            label6.TabIndex = 2;
            label6.Text = "商品改为：";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label7.Location = new System.Drawing.Point(105, 110);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(190, 40);
            label7.TabIndex = 3;
            label7.Text = "商品数量改为：";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(266, 162);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(110, 39);
            button6.TabIndex = 4;
            button6.Text = "完成修改";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(button6_Click);
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(276, 74);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(100, 25);
            textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(276, 121);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(100, 25);
            textBox8.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(button7);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(label8);
            panel3.Location = new System.Drawing.Point(117, 496);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(391, 100);
            panel3.TabIndex = 8;
            panel3.Visible = false;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label8.Location = new System.Drawing.Point(-20, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(315, 43);
            label8.TabIndex = 0;
            label8.Text = "请输入你想要删除的订单号：";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(263, 22);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(100, 25);
            textBox9.TabIndex = 1;
            // 
            // button7
            // 
            button7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            button7.Location = new System.Drawing.Point(128, 62);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(97, 38);
            button7.TabIndex = 2;
            button7.Text = "确认删除";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(button7_Click);
            // 
            // Form1
            // 
            form1.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            form1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form1.AutoScroll = true;
            form1.ClientSize = new System.Drawing.Size(1311, 758);
            form1.Controls.Add(panel3);
            form1.Controls.Add(box);
            form1.Controls.Add(button5);
            form1.Controls.Add(button4);
            form1.Controls.Add(textBox5);
            form1.Controls.Add(button3);
            form1.Controls.Add(button2);
            form1.Controls.Add(panel2);
            form1.Controls.Add(panel1);
            form1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));



            form1.Name = "Form1";
            form1.Text = "Form1";
            form1.Load += new System.EventHandler(Form1_Load);

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();

            form1.ResumeLayout(false);
            form1.PerformLayout();


            void ShowOlist(TextBox text1)                   //显示所有订单数据的函数
            {
                for (int i = 0; i < OList.OrderList.Count; i++)
                {
                    text1.Text += "订单号是： " + OList.OrderList[i].OrderNumber + " 商品名称是： " + OList.OrderList[i].GoodsName + " 商品数量是： " + OList.OrderList[i].GoodsNumber + " 商品价格是： " + OList.OrderList[i].GoodsPrice + "\r\n";
                }
                text1.Text += "\r\n";
            }

            void Form1_Load(object sender, EventArgs e)
            {

            }

            void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            void button1_Click(object sender, EventArgs e)       //如果按钮1被点击 即确定添加订单
            {
                //读取文本框中的各项数据 并且进行转换
                try
                {
                    string GoodsName = textBox1.Text;
                    string s2 = textBox2.Text;
                    int GoodsNumber = int.Parse(s2);
                    string s3 = textBox3.Text;
                    double GoodsPrice = double.Parse(s3);
                    string CustomerName = textBox4.Text;
                    int b = OList.OrderList.Count - 1;
                    int a = OList.OrderList[b].OrderNumber + 1;
                    //调用OrderService的函数
                    OrderDetails newOrder = new OrderDetails(a, CustomerName, GoodsName, GoodsNumber, GoodsPrice);
                    OList.OrderList.Add(newOrder);
                }
                catch
                {
                    textBox5.Text = "输入错误！！！请重新输入！！！";
                }

                //更改panel的可视化
                panel1.Visible = false;
            }


            void button2_Click(object sender, EventArgs e)      //如果按钮2被点击 即添加订单的功能 则此时显示出添加订单的页面
            {
                panel1.Visible = true;
            }

            void button3_Click(object sender, EventArgs e)       //如果显示订单按钮被点击 则会调用showOlist的函数 显示订单的详细数据
            {
                ShowOlist(textBox5);
            }
            void button4_Click(object sender, EventArgs e)      //如果删除订单按钮被点击 则会显示出删除订单的panel
            {
                panel3.Visible = true;
            }
            void button7_Click(object sender, EventArgs e)      //点击确认删除按钮 则会调用DeleteOrder函数
            {
                try
                {
                    string s1 = textBox9.Text;
                    int OrderNum = int.Parse(s1);
                    OList.DeleteOrder(OrderNum);
                }
                catch
                {
                    textBox5.Text = "输入错误！！！请重新输入！！！";
                }
                panel3.Visible = false;
            }
            void button5_Click(object sender, EventArgs e)      //点击修改订单功能按钮 会弹出修改订单的panel
            {
                panel2.Visible = true;
            }
            void button6_Click(object sender, EventArgs e)      //点击确认修改按钮 则会调用ChangeOrder函数
            {
                try
                {
                    string s1 = textBox6.Text;
                    int OrderNum = int.Parse(s1);
                    string GoodsName = textBox7.Text;
                    string s2 = textBox8.Text;
                    int NewNum = int.Parse(s2);
                    OList.ChangeOrder(OrderNum, NewNum, GoodsName);
                }
                catch
                {
                    textBox5.Text = "输入错误！！！请重新输入！！！";
                }
                panel2.Visible = false;
            }
            void textBox5_TextChanged(object sender, EventArgs e)
            {

            }
            void 显示框_Click(object sender, EventArgs e)
            {

            }
            void textBox6_TextChanged(object sender, EventArgs e)
            {

            }
            void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
            void textBox2_TextChanged(object sender, EventArgs e)
            {

            }
            void panel2_Paint(object sender, PaintEventArgs e)
            {

            }
            form1.ShowDialog();

        }

    }
}