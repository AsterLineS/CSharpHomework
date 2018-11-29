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
    public partial class EditForm : Form
    {
        OrderService OpOrder = new OrderService();
        public Order CurOrder { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(Order inOrder):this()
        {
            if (inOrder != null)
            {
                CurOrder = inOrder;
                bindingSource1.DataSource = CurOrder;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpOrder.ChangeOrder(CurOrder);
            this.Close();
        }
        
    }
}
