using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace 期末作业
{
    public partial class Form1 : Form
    {
        private static Goods[] goodlist;        
        private static int indexer = 0; //定义静态变量indexer用于记录商品数量
        
        
        public Form1()
        {
            InitializeComponent();
            goodlist = new Goods[100]; 
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int code = int.Parse(textBox_code.Text.Trim());
            bool flag = false;//用于记录是否查到
            if (indexer != 0)
            {
                for (int i = 0; i < indexer; i++)
                {
                    if (code == goodlist[i].getcode)
                    {
                        listBox_Show.Items.Add("商品名称：" + goodlist[i].getname + ",商品条码：" + goodlist[i].getcode + ", 商品价格：" + goodlist[i].getprice);
                        flag = true;
                    }
                }
                if (!flag)
                    MessageBox.Show("未找到该商品！");
            }
            else
                MessageBox.Show("请先添加商品！");
            
        }
        
        private void 添加商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGood f = new AddGood();
            f.ShowDialog();
            goodlist[indexer] = f.GetGoods();
            indexer++;
        }

        public static void delete(string s, string way)//通过名字或者条码找到商品的indexer并交给deletebyindex方法进行删除
        {
            if (indexer != 0)
            {
                if (way == "code")
                {
                    bool flag = false;//用于记录是否查询到
                    int code = int.Parse(s);
                    for (int i = 0; i < indexer; i++)
                    {
                        if (code == goodlist[i].getcode)
                        {
                            deletebyindex(i);
                        }
                    }
                    if (flag)
                        MessageBox.Show("无法通过条码查询到该商品，请检查输入");
                }
                if (way == "name")
                {
                    bool flag = false;
                    for (int i = 0; i < indexer; i++)
                    {
                        if (s == goodlist[i].getname)
                        {
                            deletebyindex(i);
                        }
                    }
                    if (flag)
                        MessageBox.Show("无法通过名字查询到该商品，请检查输入");
                }
            }
            else
            {
                MessageBox.Show("请先添加商品！");
            }

        }

        private static void deletebyindex(int index)
        {
            for(int i = index; i < goodlist.Length-1; i++)
            {
                goodlist[i] = goodlist[i + 1];
            }
            indexer--;
        }

        private void 删除商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGood f = new DeleteGood();
            f.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < indexer; i++)
            {
                foreach(ListViewItem li in listBox_Show.Items)
                    if (li.Selected)
                    {
                        deletebyindex(li.Index);
                    }
            }
        }

        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            listBox_Show.Items.Clear();//清空listbox
            if (indexer != 0)
            {
                for (int i = 0; i < indexer; i++)
                {
                    listBox_Show.Items.Add("商品名称：" + goodlist[i].getname + ",商品条码：" + goodlist[i].getcode + ", 商品价格：" + goodlist[i].getprice);
                }
            }
            else
                MessageBox.Show("请先添加商品！");
        }

        private void 查看所有商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_ShowAll.PerformClick();//等效于显示全部商品按钮
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < indexer; i++)
            {
                foreach (ListViewItem li in listBox_Show.Items)//!!!!!!!!!!!!!!!
                    if (li.Selected)
                    {
                        EditGood f = new EditGood(goodlist[li.Index].getname, goodlist[li.Index].getcode, goodlist[li.Index].getprice);
                        f.ShowDialog();
						goodlist[li.Index] = f.getchanged();
                    }
            }
        }
    }
}