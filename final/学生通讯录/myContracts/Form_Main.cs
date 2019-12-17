using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myContracts
{
    public partial class Form_Main : Form
    {

        void initContracts()
        {
            //不存在students.xml,则先行创建
            if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/Students.xml"))
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            else
            {
                StudentInfoBLL.CreateStudentXml();
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            dataGridView1.Columns[0].HeaderText = "学生编号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "学生性别";
            dataGridView1.Columns[3].HeaderText = "学生年龄";
            dataGridView1.Columns[4].HeaderText = "出生日期";
            dataGridView1.Columns[5].HeaderText = "手机号码";
            dataGridView1.Columns[6].HeaderText = "家庭地址";
            dataGridView1.Columns[7].HeaderText = "电子邮箱";
            dataGridView1.Columns[8].HeaderText = "专    业";
        }
        public Form_Main()
        {
            InitializeComponent();
            initContracts();
        }

        private void toolStrip_add_Click_1(object sender, EventArgs e)
        {

            Form_Add formadd = new Form_Add();
            formadd.ShowDialog();
            initContracts();
        }

        private void toolStrip_edit_Click_1(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form_Edit formedit = new Form_Edit();
                formedit.studentid_edit = selectrow;
                formedit.ShowDialog();
                initContracts();
            }
            else
                MessageBox.Show("请选中一行再点击编辑！"); 
        }

        private void toolStrip_delete_Click_1(object sender, EventArgs e)
        {
            //选中某一个学生之后，删除该学生的信息
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("确定删除此学生信息？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    if (StudentInfoBLL.DeleteStudentInfo(selectrow))
                        MessageBox.Show("删除学生信息成功");
                    else
                        MessageBox.Show("删除学生信息失败，请检查是否选中学生信息！");
                    initContracts();
                }
            }
            else
                MessageBox.Show("请选中一行再点击删除按钮");
        }

        private void toolStrip_search_Click_1(object sender, EventArgs e)
        {
        
            Form_Search formsearch = new Form_Search();
            formsearch.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StudentInfo student = new StudentInfo();
            student.Profession = treeView1.SelectedNode.Text;
            if (treeView1.SelectedNode.Text == "全部")
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            else dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(student);

        }
    }
}

