using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork10;

namespace OrderOperation
{
    public partial class MainForm : Form
    {
        OrderService OpOrder = new OrderService();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            LookForOrder();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LookForOrder();
        }
        private void LookForOrder()
        {
            switch (comboBox1.SelectedIndex)
            {

                case 1:
                    bindingSource1.DataSource =
                      OpOrder.LookForOrderI(textBox1.Text);
                    break;
                case 2:
                    bindingSource1.DataSource = OpOrder.LookForOrderN(textBox1.Text);
                    break;
                case 3:
                    bindingSource1.DataSource = OpOrder.LookForOrderN(textBox1.Text);
                    break;
                default:
                    bindingSource1.DataSource = OpOrder.GetAllOrders();
                    break;
            }
            bindingSource1.ResetBindings(false);
            bindingSource2.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                Order order = (Order)bindingSource1.Current;
                OpOrder.DeleteOrder(order.Id);
                LookForOrder();
            }
            else
            {
                MessageBox.Show("未选中订单");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                EditForm editForm = new EditForm((Order)bindingSource1.Current);
                editForm.ShowDialog();
                LookForOrder();
            }
            else
            {
                MessageBox.Show("未选中订单");
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
