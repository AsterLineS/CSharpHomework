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
    public partial class AddForm : Form
    {
        OrderService OpOrder = new OrderService();
        public Order NewOrder = new Order();
        public AddForm()
        {
            InitializeComponent();
            bindingSource1.DataSource = NewOrder;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewOrder != null)
                OpOrder.AddOrder(NewOrder);
            this.Close();
        }
    }
}
