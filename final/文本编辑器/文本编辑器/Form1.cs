using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace 文本编辑器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            toolStripStatusLabel1.Text = "                                  ";
            toolStripStatusLabel2.Text = "";
        }


        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt|c#文件(*.cs)|*.cs|所有文件(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream s = new FileStream(openFileDialog1.FileName,
                    FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(s, System.Text.Encoding.GetEncoding("gb2312"));
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                s.Close();
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "")
                return;
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|c#文件(*.cs)|*.cs|所有文件(*.*)|*.*";

            string FileName = this.saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("文件已成功保存");
            }
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("文本中存在内容，是否保存后新建?", "新建", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //确定按钮的方法
                    saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|c#文件(*.cs)|*.cs|所有文件(*.*)|*.*";

                    string FileName = this.saveFileDialog1.FileName;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK && FileName.Length > 0)
                    {
                        // Save the contents of the RichTextBox into the file.
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("文件已成功保存");
                    }
                    richTextBox1.Text = string.Empty;
                }
                else
                {
                    //取消按钮的方法
                    richTextBox1.Text = string.Empty;
                }             
            }
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("文本中存在内容，是否保存后退出?", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //确定按钮的方法
                    saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|c#文件(*.cs)|*.cs|所有文件(*.*)|*.*";

                    string FileName = this.saveFileDialog1.FileName;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK && FileName.Length > 0)
                    {
                        // Save the contents of the RichTextBox into the file.
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("文件已成功保存");
                    }
                    richTextBox1.Text = string.Empty;
                }
                else
                {
                    //取消按钮的方法
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void 复制CToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴PToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 剪切TToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 撤销ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 重复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 删除LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = string.Empty;
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 自动换行WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(自动换行WToolStripMenuItem.Text == "取消换行(&W)")
            {
                richTextBox1.WordWrap = !richTextBox1.WordWrap;
                自动换行WToolStripMenuItem.Text = "自动换行(&W)";
            }
            else
            {
                richTextBox1.WordWrap = !richTextBox1.WordWrap;
                自动换行WToolStripMenuItem.Text = "取消换行(&W)";
            }
                
        }

        private void 颜色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.Length > 0)
                {
                    this.richTextBox1.SelectionColor = this.colorDialog1.Color;
                }         
            }
        }

        private void 字体FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.Length > 0)
                {
                    this.richTextBox1.SelectionFont = this.fontDialog1.Font;
                    this.richTextBox1.SelectionColor = this.fontDialog1.Color;
                }
                else
                {
                    this.richTextBox1.Font = this.fontDialog1.Font;
                }
            }
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 重复ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 状态栏MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(状态栏MToolStripMenuItem.Text == "状态栏(显示)")
            {
                timer1.Enabled = true;
                timer1.Interval = 1000;
                toolStripStatusLabel2.Text = "版本号：1.0";
                状态栏MToolStripMenuItem.Text = "状态栏(关闭)";
            }
            else
            {
                toolStripStatusLabel1.Text = "                                  ";
                toolStripStatusLabel2.Text = "";
                timer1.Enabled = false;
                状态栏MToolStripMenuItem.Text = "状态栏(显示)";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString() + "    ";       
        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者：徐可可\n学号：171530425\n版本号：1.0");
        }

        private void 新建NToolStripButton_Click(object sender, EventArgs e)
        {
            新建NToolStripMenuItem_Click(sender, e);
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            打开OToolStripMenuItem_Click(sender, e);
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            保存SToolStripMenuItem_Click(sender, e);
        }

        private void 剪切UToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 复制CToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴PToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 居中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment != HorizontalAlignment.Center)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }     
        }

        private void 左对齐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment != HorizontalAlignment.Left)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            } 
        }

        private void 右对齐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment != HorizontalAlignment.Right)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            } 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment != HorizontalAlignment.Left)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            } 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment != HorizontalAlignment.Center)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment != HorizontalAlignment.Right)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            } 
        }

        Point Now_Point, Start_Point;  
        bool draw = false;
        int myc1, myc2, myc3;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (draw == false)
            {
                draw = true;
                MessageBox.Show("开启绘画");
                richTextBox1.Visible = false;
            }
            else
            {
                draw = false;
                MessageBox.Show("关闭绘画");
                richTextBox1.Visible = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Start_Point.Equals(Point.Empty))
                {
                    Start_Point = new Point(e.X, e.Y);
                }
                if (draw)
                {
                    Now_Point = new Point(e.X, e.Y);
                    Graphics g = this.CreateGraphics();
                    Pen pen = new Pen(Color.Red, 3);
                    g.DrawLine(pen, Start_Point, Now_Point);
                }
                Start_Point = new Point(e.X, e.Y);
            }
            else
            {
                Start_Point = new Point(e.X, e.Y);
            }
        }
    }
}