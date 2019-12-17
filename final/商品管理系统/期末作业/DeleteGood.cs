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
    public partial class DeleteGood : Form
    {
        public delegate void delete(string s, string way);// 声明委托 
        public DeleteGood()
        {
            InitializeComponent();
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            delete delete = new delete(Form1.delete);//委托指向form1中的具体函数(指向静态方法)

            if(comboBox_WaysToDelete.SelectedItem.ToString() == "通过查询商品名字删除")
            {
                delete(textBox_DeleteName.Text.Trim(), "name");
            }
            else if (comboBox_WaysToDelete.SelectedItem.ToString() == "通过查询商品条码删除")
            {
                delete(textBox_DeleteCode.Text.Trim(), "code");
            }
            else
            {
                MessageBox.Show("选择删除方式！");
            }
            this.Close();
        }

        private void comboBox_WaysToDelete_SelectedIndexChanged(object sender, EventArgs e)//当combox下拉改变时触发
        {
            if(comboBox_WaysToDelete.SelectedItem.ToString() == "通过查询商品名字删除")
                {
                    groupBox_theCodeWay.Visible = false; //隐藏codeway对话框，显示nameway对话框
                    groupBox_theNameWay.Visible = true;
                }
            if(comboBox_WaysToDelete.SelectedItem.ToString() == "通过查询商品条码删除")
                {
                    groupBox_theNameWay.Visible = false;
                    groupBox_theCodeWay.Visible = true;
                }
        }
    }
}
