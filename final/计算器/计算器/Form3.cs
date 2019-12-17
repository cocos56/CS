using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "calc.exe ";//"calc.exe"为计算器
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)//窗体上的唯一按钮
        {
            this.Close();//关闭窗体
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)//响应键盘操作
        {
            if (e.KeyCode == Keys.Escape)//判断是否按了esc
            {
                this.Close();//关闭窗体
            }  
        }
    }
}
