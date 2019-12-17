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
    public partial class Form1 : Form
    {
        public static int isopt = 0;//标志输入的是否是运算符
        public static int flag = -1;//判断是否连续运算
        public static string numSavd = "";//保存第一个操作数
        public static string optSavd = string.Empty;//保存运算符
        public string save;//用来储存数据
        public Form1()
        {
            InitializeComponent();
        }
        public void focus()
        {
            textBox1.Focus();//获取焦点
            textBox1.SelectionStart = textBox1.Text.Length;//光标置后
        }
        //数字键输入函数
        private void shuru(string shuzi)
        {
            if (textBox1.Text == "0"||isopt==1)//判断第一位是否为零
                textBox1.Text = shuzi;
            else
                textBox1.Text += shuzi;
            isopt = 0;//输入数字
            focus();//光标置后
        }
        private void intputOpt(string opt)
        {
            flag++;//初始值为-1，如果是单次运算则变成1
            if (flag == 0)
            {
                numSavd = textBox1.Text;//当前textBox里面的值
                optSavd = opt;
            }
            else//flag>0, 多次运算
            {
                if (isopt == 1)
                {
                    optSavd = opt;
                }
                else
                {
                    string tempresult = js(numSavd, optSavd, textBox1.Text);
                    textBox1.Text = tempresult;
                    numSavd = textBox1.Text;
                    optSavd = opt;
                }
            }
            label1.Text = numSavd + optSavd;
            isopt = 1;//输入了操作符
            focus();//光标置后
        }
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

  
        private void btn2_Click(object sender, EventArgs e)//数字按钮2
        {
            shuru("2");
        }

        private void btn1_Click(object sender, EventArgs e)//数字按钮1
        {
            shuru("1");
        }

        private void btn3_Click(object sender, EventArgs e)//数字按钮3
        {
            shuru("3");
        }

        private void btn4_Click(object sender, EventArgs e)//数字按钮4
        {
            shuru("4");
        }

        private void btn5_Click(object sender, EventArgs e)//数字按钮5
        {
            shuru("5");
        }

        private void btn6_Click(object sender, EventArgs e)//数字按钮6
        {
            shuru("6");
        }

        private void btn7_Click(object sender, EventArgs e)//数字按钮7
        {
            shuru("7");
        }

        private void btn8_Click(object sender, EventArgs e)//数字按钮8
        {
            shuru("8");
        }

        private void btn9_Click(object sender, EventArgs e)//数字按钮9
        {
            shuru("9");
        }

        private void btn0_Click(object sender, EventArgs e)//数字按钮0
        {
            shuru("0");
        }
        public string js(string num1, string opt, string num2)//计算
        {
            string result = "";
            double d1 = double.Parse(num1);
            double d2 = double.Parse(num2);
            switch (opt)
            {
                case "+": result = (d1 + d2).ToString(); break;
                case "-": result = (d1 - d2).ToString(); break;
                case "*": result = (d1 * d2).ToString(); break;
                case"/":
                    if (d2 == 0)
                        MessageBox.Show("除数不能为0！");
                    else
                        result = (d1 / d2).ToString();
                    break;
            }
            return result;
        }
        //C键功能
        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;//清空textbox1
            label1.Text = string.Empty;//清空label1
            numSavd = string.Empty;//清空numSavd
            optSavd = string.Empty;//清空optSavd
            focus(); //光标置后
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndengyu_Click(object sender, EventArgs e)//等于按钮
        {
            if (textBox1.Text!="0" && textBox1.Text!="")//判断是否为0或者空值
            {
                string numNow = textBox1.Text;
                string result = js(numSavd, optSavd, numNow);
                textBox1.Text = result;
                label1.Text = string.Empty;
                flag = -1;//重置flag
                isopt = 1;//运算符
                focus();//光标置后
            }
        }

        private void btnjia_Click(object sender, EventArgs e)//加 按钮
        {
            intputOpt("+");
        }

        private void btnjian_Click(object sender, EventArgs e)//减 按钮
        {
            intputOpt("-");
        }

        private void btncheng_Click(object sender, EventArgs e)//乘 按钮
        {
            intputOpt("*");
        }

        private void btnchu_Click(object sender, EventArgs e)//除按钮
        {
            intputOpt("/");
        }

        private void btnCE_Click(object sender, EventArgs e)//CE按钮
        {
            textBox1.Text = string.Empty;//清空textbo1
            focus(); //光标置后
        }

        private void btnMC_Click(object sender, EventArgs e)//MC按钮
        {
            save = string.Empty; //清空save
            label2.Text =string.Empty;//清空保存的数据     
        }

        private void btntg_Click(object sender, EventArgs e)//退格按钮
        {
            string str = textBox1.Text;//提取textbox1的内容
            if (str.Length > 0)//判断是否大于0
                textBox1.Text = str.Substring(0, str.Length - 1);//删除最后一位
            focus(); //光标置后
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)//复制按钮
        {
            Clipboard.SetDataObject(textBox1.Text, true, 1, 10);//写入剪切板
            MessageBox.Show("成功复制：" + textBox1.Text);//弹窗提示用户
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)//粘贴按钮
        {
           textBox1.Text = Clipboard.GetText();//将剪切板内容写入textbox1
        }

        private void btnMR_Click(object sender, EventArgs e)//MR按钮
        {
            textBox1.Text = save;//显示保存的数据
        }

        private void btnMS_Click(object sender, EventArgs e)//MS按钮
        {
            label2.Text = "M";//显示M
            save = textBox1.Text;//保存数据
        }

        private void btnMjia_Click(object sender, EventArgs e)//M+按钮
        {
            double num1, num2, sum;//定义三个double型的数
            num1 = Convert.ToDouble(save);//把保存的树转为double型
            num2 = Convert.ToDouble(textBox1.Text);//把计算完的树转为double型
            sum = num1 + num2;//求和
            save = sum.ToString();//转为string型
        }

        private void 关于计算器ToolStripMenuItem_Click(object sender, EventArgs e)//关于计算器按钮
        {
            Form2 f = new Form2();//定义窗体
            f.Show();//显示窗体
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)//说明按钮
        {
            MessageBox.Show("这是一个简易计算器，仅能进行简单的四则运算。","提示:");//弹窗提示
        }

        private void 科学型ToolStripMenuItem_Click(object sender, EventArgs e)//科学型按钮
        {
            Form3 f = new Form3();//定义窗体
            f.Show();//显示窗体
        }

        private void 标准型ToolStripMenuItem_Click(object sender, EventArgs e)//标准型按钮
        {
            MessageBox.Show("已启用标准型，请勿重复操作！","错误提示:");//弹窗提示
        }

        private void btndian_Click(object sender, EventArgs e)//小数点按钮
        {
            if (textBox1.Text == string.Empty)//判断是否为空
                textBox1.Text = "0.";//显示为0.
            else
            {
                if (textBox1.Text.IndexOf('.') == -1)//判断是否含有小数点
                    textBox1.Text += ".";//添加小数点
            }
            isopt = 0;//标志不是运算符
            focus();//光标置后
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//textbox1键盘响应操作
        {
            if (e.KeyChar == (char)8)
            {
                e.Handled=false;
            }
            else
            {
                e.Handled=true;
                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                    shuru(Convert.ToString(e.KeyChar - 48));
                else if (e.KeyChar == '+')
                    intputOpt("+");
                    else  if (e.KeyChar == '-')
                    intputOpt("-");
                else if (e.KeyChar == '*')
                    intputOpt("*");
                else if (e.KeyChar == '/')
                    intputOpt("/");
                else if (e.KeyChar == '.')
                {
                    if (textBox1.Text == string.Empty)//判断是否为空
                        textBox1.Text = "0.";//显示为0.
                    else
                    {
                        if (textBox1.Text.IndexOf('.') == -1)//判断是否含有小数点
                            textBox1.Text += ".";//添加小数点
                    }
                    isopt = 0;//标志不是运算符
                    focus();//光标置后
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//from1窗体响应键盘操作
        {
            if (e.KeyCode == Keys.Escape)//判断键盘是否按下esc
            {
                this.Close();//关闭当前窗体
            }  
        }

        private void btnzf_Click(object sender, EventArgs e)//正负号按钮
        {
            int a;//定义一个a
            a =textBox1.Text.IndexOf('-');//查找textbox1里面有没有负号
            if (textBox1.Text != null)//如果不为空则进行下一步，否则无响应
            {
                if (a == -1)//a=-1代表textbox1里面没有负号
                    textBox1.Text = textBox1.Text.Insert(0, "-");//添加负号
                else textBox1.Text = textBox1.Text.Remove(0, 1);//删除负号
            }
        }

        private void btnsqrt_Click(object sender, EventArgs e)//开方按钮
        {
            label1.Text = "开方(" + textBox1.Text + ")";//在label1上显示开根号的数
            textBox1.Text = "" + Math.Sqrt(Convert.ToDouble(textBox1.Text));//开根号后在textbox1显示
        }

        private void btndaoshu_Click(object sender, EventArgs e)//倒数按钮
        {
            label1.Text = "倒数(" + textBox1.Text + ")";//在label1上显示求倒的数
            textBox1.Text = "" + 1 / (Convert.ToDouble(textBox1.Text));//求倒后的数在textbox1显示
        }

        private void btnbaifenbi_Click(object sender, EventArgs e)
        {
            double b =Convert.ToDouble(textBox1.Text);//定义一个b
            textBox1.Text =( b / 100).ToString();//b除以100
        }

        private void btnMjian_Click(object sender, EventArgs e)//M-键按钮
        {
            double num1, num2, sum;//定义三个double型的数
            num1 = Convert.ToDouble(save);//把保存的树转为double型
            num2 = Convert.ToDouble(textBox1.Text);//把计算完的树转为double型
            sum = num1 - num2;//求和
            save = sum.ToString();//转为string型
        }
    }
}
