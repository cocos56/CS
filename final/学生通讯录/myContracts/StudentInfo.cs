using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myContracts
{
    /// <summary>
    /// 学生信息实体类
    /// </summary>
    public class StudentInfo
    {
        public string StudentId { set; get; }//ID
        public string Name { set; get; }//姓名
        public string Sex { set; get; }//性别
        public int Age { set; get; }//年龄
        public DateTime BirthDate { set; get; }//生日
        public string Phone { set;get;}//电话
        public string HomeAddress { set; get; }//地址
        public string Email { set; get; }//邮箱
        public string Profession { set; get; }//专业
    }
}
