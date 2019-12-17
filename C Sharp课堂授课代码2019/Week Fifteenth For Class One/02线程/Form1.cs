using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _02线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //Test();
            //创建一个线程去执行这个方法
            th = new Thread(Test);
            th.IsBackground = true;
            th.Start();
            //th.Abort();
            //th.Start();

        }
        private void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(i);
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗体的时候要判断线程是否存在
            if (th!=null)
            {
                th.Abort();//结束这个线程
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
