

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myContracts
{
    public partial class Form_Edit : Form
    {
        public int studentid_edit = 0;  //要编辑学生编号，用于在主窗体和编辑窗体传递
     
        public Form_Edit()
        {
            InitializeComponent();
        }

        private void Form_Edit_Load(object sender, EventArgs e)
        {
         
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            studentinfo.StudentId = txt_studengid.Text;
            studentinfo.Name= txt_name.Text;
            if (rb_man.Checked)
                studentinfo.Sex = "男";
            else if (rb_woman.Checked)
                studentinfo.Sex = "女";
            studentinfo.Age = Int32.Parse(txt_age.Text);
            studentinfo.BirthDate = DateTime.Parse(dt_birthdate.Text);
            studentinfo.Phone = txt_phone.Text;
            studentinfo.Email = txt_email.Text;
            studentinfo.HomeAddress = txt_homeaddress.Text;
            studentinfo.Profession = txt_profession.Text;
            if (StudentInfoBLL.UpdateStudentInfo(studentinfo))
                MessageBox.Show("修改学生信息成功！");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_studengid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            if (studentinfo != null)
            {
                txt_studengid.Text = studentinfo.StudentId.ToString();
                txt_name.Text = studentinfo.Name;
                if (studentinfo.Sex == "男")
                {
                    rb_man.Checked = true;
                    rb_woman.Checked = false;
                }
                else
                {
                    rb_man.Checked = false;
                    rb_woman.Checked = true;
                }
                txt_age.Text = studentinfo.Age.ToString();
                dt_birthdate.Text = studentinfo.BirthDate.ToString();
                txt_phone.Text = studentinfo.Phone;
                txt_email.Text = studentinfo.Email;
                txt_homeaddress.Text = studentinfo.HomeAddress;
                txt_profession.Text = studentinfo.Profession;
            }
        }

        private void rb_man_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
