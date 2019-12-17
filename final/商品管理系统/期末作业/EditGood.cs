using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末作业
{
    public partial class EditGood : Form
    {
        private int code;
        private string name;
        private int price;
        private Goods changed;
        public EditGood(string name, int code, int price)//构造函数以适应listbox多选
        {
            InitializeComponent();
            this.name = name;
            this.code = code;
            this.price = price;
            textBox_goodname.Text = name;
            textBox_goodcode.Text = code.ToString();
            textBox_goodprice.Text = price.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox_goodname.Text;
            code = int.Parse(textBox_goodcode.Text);
            price = int.Parse(textBox_goodprice.Text);
            changed = new Goods(code, name, price);
        }
        public Goods getchanged()
        {
            return changed;
        }
    }
}
