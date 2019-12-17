using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 电子商务;


namespace 登录窗体
{
    public partial class Form1 : Form
    {
        Service service = new Service();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = t1.Text;
            string psw = t2.Text;
           
           bool b =  service.Login(name, psw);
           if (b)
           {
               MessageBox.Show("登录成功");
           }
           else
           {
               MessageBox.Show("登录失败");
           }
           
        }
    }
}
