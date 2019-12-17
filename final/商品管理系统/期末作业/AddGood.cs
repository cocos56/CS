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
    public partial class AddGood : Form
    {
        private int code;
        private string name;
        private int price;

        private Goods G;
        public AddGood()
        {
            InitializeComponent();
        }
        public Goods GetGoods()
        {
            return G;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            code = int.Parse(textBox_code.Text.Trim());
            name = textBox_name.Text.Trim();
            price = int.Parse(textBox_price.Text.Trim());

            G = new Goods(code, name, price);
            this.Close();
        }
    }
}
