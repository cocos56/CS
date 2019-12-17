using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supercalculator
{
     public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        string ptr = "";   //算数表达式
        Stack<int> lastlen = new Stack<int>();//添加操作数之前的算术表达式的长度
        Stack<int> lastlenT = new Stack<int>();//添加操作数之前的文本框的长度
        bool start = true;
        string lastAns = "0";//标志初始化
        Stack<double> nums = new Stack<double>();//操作数
        Stack<char> ops = new Stack<char>();//运算符
        private void button1_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "1";
            ptr += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "2";
            ptr += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "3";
            ptr += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "4";
            ptr += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "5";
            ptr += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "6";
            ptr += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "7";
            ptr += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "8";
            ptr += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            } 
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "9";
            ptr += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "0";
            ptr += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length); //没有添加前的算术表达式的长度
            lastlenT.Push(textBox1.Text.Length);
            if (ptr == "")
            {
                textBox1.Text += "+";
                ptr += "0+";    //把单目运算符“+”改成双目运算符
            }
            else
            {
                textBox1.Text += "+";
                ptr += "+";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "-";
            int len = ptr.Length;
            if (len != 0 && (ptr[len - 1] == ')' || (ptr[len - 1] >= '0' && ptr[len - 1] <= '9'))) 
                ptr += "+-";   //把“-”改成单目运算符
            else ptr += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "*";
            ptr += "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "/";
            ptr += "/";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            int len = textBox1.Text.Length;
            if (len == 0 || (textBox1.Text[len - 1] < '0' || textBox1.Text[len - 1] > '9') && textBox1.Text[len - 1] != '.')
            {
                textBox1.Text += "0.";
                ptr += "0.";
            }
            else
            {
                textBox1.Text += ".";
                ptr += ".";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "(";
            ptr += "(";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += ")";
            ptr += ")";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            int len = textBox1.Text.Length;
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            if (len == 0 || textBox1.Text[len - 1] < '0' || textBox1.Text[len - 1] > '9')
            {
                textBox1.Text += lastAns;
                ptr += lastAns;
            }
            else
            {
                textBox1.Text += "*";
                textBox1.Text += lastAns;
                ptr += "*";
                ptr += lastAns;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "%";
            ptr += "%";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            int len = textBox1.Text.Length;
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            if (len > 0 && ((textBox1.Text[len - 1] >= '0' && textBox1.Text[len - 1] <= '9') || textBox1.Text[len - 1] == ')'))
            {
                textBox1.Text += "*";
                ptr += "*";
            }
            textBox1.Text += "sqrt(";
            ptr += "S(";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            int len = textBox1.Text.Length;
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            if (len > 0 && ((textBox1.Text[len - 1] >= '0' && textBox1.Text[len - 1] <= '9') || textBox1.Text[len - 1] == ')'))
            {
                textBox1.Text += "*";
                ptr += "*";
            }
            textBox1.Text += "sin(";
            ptr += "s(";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            int len = textBox1.Text.Length;
            if (len > 0 && ((textBox1.Text[len - 1] >= '0' && textBox1.Text[len - 1] <= '9') || textBox1.Text[len - 1] == ')'))
            {
                textBox1.Text += "*";
                ptr += "*";
            }
            textBox1.Text += "cos(";
            ptr += "c(";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "!";
            ptr += "!";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ptr = "";
                textBox1.Clear();
                start = false;
            }
            lastlen.Push(ptr.Length);
            lastlenT.Push(textBox1.Text.Length);
            textBox1.Text += "^2";
            ptr += "^";
        }
        private bool check(string str)  //检查算术表达式是否匹配
        {
            int jd = 0, num = 0;
            int len = str.Length;
            int st = 0, ed = len - 1;
            while (str[st] == '(' && st < ed) st++;
            while (str[ed] == ')' && ed > 0) ed--;  
            if ((str[st] < '0' || str[st] > '9') && str[st] != '-' && str[st] != 'S' && str[st] != 's' && str[st] != 'c') return false;
            if ((str[ed] < '0' || str[ed] > '9') && str[ed] != '!' && str[ed] != '^') return false;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == '+' || str[i] == '*' || str[i] == '/' || str[i] == '%') jd++;
                if ((str[i] >= '0' && str[i] <= '9') || str[i] == '.') jd = 0;
                if (jd >= 2) return false;
            }
            jd = 0;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == '(') jd++;
                else if (str[i] >= '0' && str[i] <= '9' && jd > 0) num++;
                else if (str[i] == ')')
                {
                    if (jd == 0 || num == 0) return false;
                    jd--;
                }
            }
            if (jd > 0) return false;
            return true;
        }
        private int isp(char op)
        {
            //S 表示sqrt， s 表示sin， c 表示cos
            if (op == '#') return 0;
            if (op == '(') return 1;
            if (op == '*' || op == '/' || op == '%' || op == 'S' || op == 'c' || op == 's') return 5;
            if (op == '+' || op == '-') return 3;
            if (op == ')') return 7;
            return -1;
        }  //返回栈中算符优先级
        private int icp(char op)
        {
            if (op == '#') return 0;
            if (op == '(') return 7;
            if (op == '*' || op == '/' || op == '%') return 4;
            if (op == 'S' || op == 'c' || op == 's') return 6;
            if (op == '+' || op == '-') return 2;
            if (op == ')') return 1;
            return -1;
        }//返回栈外算符优先级
        private double compute(double l, char op, double r)
        {
            if (op == '+') return l + r;
            if (op == '-') return l - r;
            if (op == '*') return l * r;
            if (op == '/') return l / r;
            if (op == '%') return Convert.ToInt64(l) % Convert.ToInt64(r);
            return 0;
        } //计算运算符
        bool isInteger(double x)
        {
            string str = x.ToString();
            long res = -1;
            if (long.TryParse(str, out res)) return true;
            return false;
        }
        private bool trans(ref string str)
        {
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-') num++;
                else break;
            }
            str = str.Substring(num);
            if (num % 2 == 0) return false;
            return true;
        }
        private string Cal(string str)  //用堆栈实现中缀表达式求值
        {
            if (str == "") str = "0";
            if (str == "∞") return str;
            if (!check(str)) return "Syntax Error";
            str += '#';
            nums.Clear();
            ops.Clear();
            ops.Push('#');
            for (int i = 0; i < str.Length; i++)
            {
                bool number = false;
                string tmp = "";
                while ((str[i] >= '0' && str[i] <= '9') || str[i] == '.' || str[i] == '-' || str[i] == 'E')
                {
                    number = true;
                    tmp += str[i];
                    if (str[i] == 'E')
                    {
                        tmp += str[++i];
                    }
                    i++;
                }
                bool flag;
                if (number)
                {
                    flag = trans(ref tmp);
                    double res;
                    bool success = double.TryParse(tmp, out res);
                    if (flag) res = -res;  //把减号转成负号
                    if (success) nums.Push(res);
                    else return "Syntax Error";
                }
                flag = true;
                while (flag)
                {
                    if (str[i] == '!' || str[i] == '^')
                    {
                        if (nums.Count == 0) return "Syntax Error";
                        double l = nums.Pop();
                        double res;
                        if (str[i] == '!')
                        {
                            if (!isInteger(l) || l < 1) return "Math Error";
                            res = 1;
                            for (int j = 1; j <= l; j++) res *= j;
                        }
                        else
                        {
                            res = l * l;
                        }
                        nums.Push(res);
                        break;
                    }
                    else if (icp(str[i]) > isp((char)ops.Peek()))
                    {
                        ops.Push(str[i]);
                        break;
                    }
                    else if(icp(str[i]) < isp((char)ops.Peek()))
                    {
                        double r = nums.Pop();
                        char op = ops.Pop();
                        if (op == 'S')
                        {
                            if (r < 0) return "Math Error";
                            nums.Push(Math.Sqrt(r));
                        }
                        else if (op == 's' || op == 'c')
                        {
                            if (op == 's') nums.Push(Math.Sin(r));
                            else nums.Push(Math.Cos(r));
                        }
                        else
                        {
                            double l = nums.Pop();
                            if (op == '/' && r == 0) return "∞";
                            if (op == '%' && (!isInteger(l) || !isInteger(r) || r == 0)) return "Math Error";
                            nums.Push(compute(l, op, r));
                        }
                    }
                    else
                    {
                        ops.Pop();
                        break;
                    }
                }
            }
            if (nums.Count > 1) return "Syntax Error";
            lastAns = nums.Pop().ToString();
            return lastAns;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string ans = Cal(ptr);  //调用求值算法
            lastlen.Clear();
            lastlenT.Clear();
            lastlen.Push(0);
            lastlenT.Push(0);
            textBox1.Text += ans;
            ptr = ans;
            double result;
            bool flag = double.TryParse(ans, out result);
            if (!flag || ans == "0") start = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ptr = "";
            lastlenT.Clear();
            lastlen.Clear();
            start = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (str == "Syntax Error" || str == "∞" || str == "Math Error" || str == "Too big")
            {
                textBox1.Text = "0";
                start = true;
                return;
            }
            textBox1.Text = textBox1.Text.Substring(0, lastlenT.Pop());
            if (ptr.Length != 0)
            {
                ptr = ptr.Substring(0, lastlen.Pop());
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
                lastlenT.Push(0);
                start = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string ans = Cal(ptr);
            textBox1.Clear();
            double res;
            ptr = ans;
            lastlen.Clear();
            lastlenT.Clear();
            lastlen.Push(0);
            lastlenT.Push(0);
            bool flag = double.TryParse(ptr, out res);
            if (flag)
            {
                if (res == 0)
                {
                    textBox1.Text += "ERROR";
                    ptr = "ERROR";
                    start = true;
                }
                else
                {
                    res = 1.0 / res;
                    textBox1.Text += res;
                    ptr = res.ToString();
                    lastAns = ans;
                }
            }
            else
            {
                if (ans == "∞")
                {
                    ans = "0";
                    lastAns = ans;
                    }
                textBox1.Text += ans;
                ptr = "0";
                start = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.FromArgb(245, 212, 217);
        }
    }
}