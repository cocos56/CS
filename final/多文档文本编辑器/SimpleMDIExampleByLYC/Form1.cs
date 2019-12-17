using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Web;
using System.Web.UI;
using System.IO;

namespace SimpleMDIExampleByLYC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _Num = 1;//本来在FrmDoc.Designer.cs里
        RichTextBox rtb = new RichTextBox();


        private void Form1_Load(object sender, EventArgs e)
        {
            tSCbBoxFontName.DropDownItems.Clear();//书上原来是tSCbBoxFontName.Items.Clear();
            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)
                tSCbBoxFontName.DropDownItems.Add(ff.GetName(1));
            LayoutMdi(MdiLayout.Cascade);
            Text = "多文档文本编辑器";
            WindowState = FormWindowState.Maximized;
        }

        private void 窗口层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            this.窗口层叠ToolStripMenuItem.Checked = true;
            this.垂直平铺ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = false;
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = true;
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = true;
            this.水平平铺ToolStripMenuItem.Checked = false;
        }

        private void NewDoc()
        {
            FrmDoc fd = new FrmDoc();
            fd.MdiParent = this;
            fd.Text = "文档"+_Num;
            fd.Name = "文档" + _Num;  //asfgadgfafaege
            fd.WindowState = FormWindowState.Maximized;
            fd.Show();
            fd.Activate();
            _Num++;
        }

        private void 新建NToolStripButton_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "RTF格式(* .rtf)|* .rtf|文本文件(* .txt)|* .txt|所有文件(* .*)|* .*";       //openfiledialog1.Filter = "RTF格式(* .rtf)|文本文件(* .txt)|* .txt|所有文件(* .*)|* .*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;

                    if (openfiledialog1.FilterIndex == 1)
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.RichText);
                    else
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            openfiledialog1.Dispose();
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (MessageBox.Show("确定要关闭当前文件吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    ((FrmDoc)this.ActiveMdiChild).Close();
            }
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出应用程序？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach (FrmDoc fd in this.MdiChildren)
                    fd.Close();
                Application.Exit();
            }
        }

        private void tSCbBoxFontName_TextChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                RichTextBox tempRTB = new RichTextBox();
                int RtbStart = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionStart;
                int len = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionLength;
                int tempRtbStart = 0;
                Font font = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont;
                if (len <= 0 && null != font)
                {
                    ((FrmDoc)this.ActiveMdiChild).rTBDoc.Font = new Font(tSCbBoxFontName.Text, font.Size, font.Style);
                    return;
                }
                tempRTB.Rtf = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf;
                for (int i = 0; i < len; i++)
                {
                    tempRTB.Select(tempRtbStart + i, 1);
                    tempRTB.SelectionFont = new Font(tSCbBoxFontName.Text, tempRTB.SelectionFont.Size, tempRTB.SelectionFont.Style);
                }
                tempRTB.Select(tempRtbStart, len);
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf = tempRTB.SelectedRtf;
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.Select(RtbStart, len);
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.Focus();
                tempRTB.Dispose();
            }
        }

        private void ChangeRTBFontStyle(RichTextBox rtb, FontStyle style)
        {
            if (style != FontStyle.Bold && style != FontStyle.Italic && style != FontStyle.Underline)
                throw new System.InvalidProgramException("字体格式错误");
            RichTextBox tempRTB = new RichTextBox();
            int curRtbStart = rtb.SelectionStart;
            int len = rtb.SelectionLength;
            int tempRtbStart = 0;
            Font font = rtb.SelectionFont;
            if (len <= 0 && font != null)
            {
                if (style == FontStyle.Bold && font.Bold || style == FontStyle.Italic && font.Italic || style == FontStyle.Underline && font.Underline)
                    rtb.Font = new Font(font, font.Style ^ style);
                else
                    if (style == FontStyle.Bold && !font.Bold || style == FontStyle.Italic && !font.Italic || style == FontStyle.Underline && !font.Underline)
                        rtb.Font = new Font(font, font.Style | style);
                return;
            }
            tempRTB.Rtf = rtb.SelectedRtf;
            tempRTB.Select(len - 1, 1);
            Font tempFont = (Font)tempRTB.SelectionFont.Clone();
            for (int i = 0; i < len; i++)
            {
                tempRTB.Select(tempRtbStart + i, 1);
                if (style == FontStyle.Bold && tempFont.Bold || style == FontStyle.Italic && tempFont.Italic || style == FontStyle.Underline && tempFont.Underline)
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style ^ style);
                else
                    if (style == FontStyle.Bold && !tempFont.Bold || style == FontStyle.Italic && !tempFont.Italic || style == FontStyle.Underline && !tempFont.Underline)
                        tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style | style);
            }
            tempRTB.Select(tempRtbStart, len);
            rtb.SelectedRtf = tempRTB.SelectedRtf;
            rtb.Select(curRtbStart, len);
            rtb.Dispose();
        }

        private void 粗体ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Bold);
        }

        private void 斜体ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Italic);
        }

        private void 下划线ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Underline);
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "RTF格式(* .rtf)|* .rtf|文本文件(* .txt)|* .txt|所有文件(* .*)|* .*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;

                    if (openfiledialog1.FilterIndex == 1)
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.RichText);
                    else
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile
                            (openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch
                {
                    MessageBox.Show("打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            openfiledialog1.Dispose();
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                SaveFileDialog savefiledialog1 = new SaveFileDialog();
                savefiledialog1.Filter = "RTF格式(*.rtf)|*.rtf|文本文件(*.txt)|*.txt";
                if (savefiledialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (savefiledialog1.FilterIndex == 1)
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.RichText);
                        else
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                savefiledialog1.Dispose();
            }
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Count()>0)
            {
                SaveFileDialog savefiledialog1 = new SaveFileDialog();
                savefiledialog1.Filter = "RTF格式(*.rtf)|*.rtf|文本文件(*.txt)|*.txt";
                if(savefiledialog1.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        if (savefiledialog1.FilterIndex == 1)
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.RichText);
                        else
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                savefiledialog1.Dispose();
            }
        }

        private void 复制ToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc;
            if (rtbInfo.SelectedText.Length > 0)
            {
                rtbInfo.Copy();
            }
        }

        private void 粘贴ToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc;
            rtbInfo.Paste();
        }

        private void 撤回ToolStripButton_Click(object sender, EventArgs e)
        {

            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc;
            rtbInfo.Undo();
        }

        private void 剪切ToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc;
            rtbInfo.Cut();
        }

        private void 向左对齐ToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc;
            rtbInfo.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void 向右对齐ToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc;
            rtbInfo.SelectionAlignment = HorizontalAlignment.Right;

            
        }

        private void 居中对齐ToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox rtbInfo = ((FrmDoc)this.ActiveMdiChild).rTBDoc; 
            rtbInfo.SelectionAlignment = HorizontalAlignment.Center;

        }
    }
}
