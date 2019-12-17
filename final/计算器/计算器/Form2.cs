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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//窗体上的唯一按钮
        {
            this.Close();//关闭窗体
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)//响应键盘操作
        {
            if (e.KeyCode == Keys.Escape)//判断是否按了 esc
            {
                this.Close();//关闭窗体
            }  
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
