using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public class WinInOut : Form
{
    TextBox txt1 = new TextBox();
    TextBox txt2 = new TextBox();
    Button btn = new Button();
    Label lbl = new Label();

    public void init()
    {
        this.Controls.Add(txt1);
        this.Controls.Add(txt2);
        this.Controls.Add(btn);
        this.Controls.Add(lbl);
        txt1.Dock = System.Windows.Forms.DockStyle.Right;
        txt2.Dock = System.Windows.Forms.DockStyle.Left;
        btn.Dock = System.Windows.Forms.DockStyle.Fill;
        lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
        btn.Text = "求两个数乘积";
        lbl.Text = "用于显示结果的标签";
        this.Size = new Size(300, 120);
        btn.Click += new System.EventHandler(this.button1_Click);
    }
    public void button1_Click(object sender, EventArgs e)
    {
        string s1 = txt1.Text;
        string s2 = txt2.Text;
        double a = double.Parse(s1);
        double b = double.Parse(s2);
        lbl.Text = a + "*" + b + "=" + a * b;
    }
    static void Main()
    {
        WinInOut f = new WinInOut();
        f.Text = "WinInOut";
        f.init();
        Application.Run(f);
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // WinInOut
        // 
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Name = "WinInOut";
        this.Load += new System.EventHandler(this.WinInOut_Load);
        this.ResumeLayout(false);

    }

    private void WinInOut_Load(object sender, EventArgs e)
    {

    }
}