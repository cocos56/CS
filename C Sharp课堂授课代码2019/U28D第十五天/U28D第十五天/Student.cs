namespace U28D第十五天
{
    //接下来在“U28D第十五天”项目上鼠标右键添加“Student”类
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Grade { set; get; }
        public Student(int id,string name,string sex,int grade)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.Grade = grade;
        }
        public Student()
        {

        }
    }
}