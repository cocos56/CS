using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        PictureBox[] pictureList = null;

        SortedDictionary<string, Bitmap> pictureLocationDict = new SortedDictionary<string, Bitmap>();

        Point[] pointList = null;

        SortedDictionary<string, PictureBox> pictureBoxLocationDic = new SortedDictionary<string, PictureBox>();

        int second = 0;

        PictureBox currentPictureBox = null;
        PictureBox haveToPictureBox = null;

        Point oldLocation = Point.Empty;
        Point newLocation = Point.Empty;

        Point mouseDownPoint = Point.Empty;

        Rectangle rect = Rectangle.Empty;

        bool isDrag = false;
        public static string originalpicpath;
        /// <summary>
        /// 每个方向上要切割成的块数
        /// </summary>
        private int ImgNumbers
        {
            get
            {
                return (int)this.numericUpDown1.Value;
            }
        }
        /// <summary>
        /// 要切割成的正方形图片边长
        /// </summary>
        private int SideLength
        {
            get
            {
                return 600 / this.ImgNumbers;
            }
        }
        private void InitRandomPictureBox()
        {
            pnl_Picture.Controls.Clear();
            pictureList = new PictureBox[ImgNumbers * ImgNumbers];
            pointList = new Point[ImgNumbers * ImgNumbers];
            for (int i = 0; i < this.ImgNumbers; i++)
            {
                for (int j = 0; j < this.ImgNumbers; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Name = "pictureBox" + (j + i * ImgNumbers + 1).ToString();
                    pic.Location = new Point(j * SideLength, i * SideLength);
                    pic.Size = new Size(SideLength, SideLength);
                    pic.Visible = true;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                    pic.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                    pic.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
                    pnl_Picture.Controls.Add(pic);
                    pictureList[j + i * ImgNumbers] = pic;
                    pointList[j + i * ImgNumbers] = new Point(j * SideLength, i * SideLength);
                }
            }

        }


        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="path"></param>
      public void Flow(string path, bool disorder)
        {
            InitRandomPictureBox();
            Image bm = CutPicture.Resize(path, 600, 600);
            CutPicture.BitMapList = new List<Bitmap>();
            for (int y = 0; y < 600; y += SideLength)
            {
                for (int x = 0; x < 600; x += SideLength)
                {
                    Bitmap temp = CutPicture.Cut(bm, x, y, SideLength, SideLength);
                    CutPicture.BitMapList.Add(temp);
                }
            }
            ImportBitMap(disorder);
        }
        public void ImportBitMap(bool disorder)
        {
            try
            {

                int i = 0;
                foreach (PictureBox item in pictureList)
                {
                    Bitmap temp = CutPicture.BitMapList[i];
                    item.Image = temp;
                    i++;
                }
                if (disorder)
                    ResetPictureLocation();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }



        public PictureBox[] DisOrderArray(PictureBox[] pictureArray)
        {
            PictureBox[] tempArray = pictureArray;
            for(int i=tempArray.Length-1;i>0;i--)
            {
                Random rand = new Random();
                int p = rand.Next(i);
                PictureBox temp = tempArray[i];
                tempArray[i] = temp;
            }
            return tempArray;
        }



    

        public void InitGame()
        {
            pictureList = new PictureBox[9] ;
            pointList = new Point[9] {new Point(0,0), new Point(100, 0), new Point(200, 0), new Point(0, 100), new Point(100, 100),
                new Point(200,100), new Point(0,200),new Point(100,200),new Point(200,200)};
            if (!Directory.Exists(Application.StartupPath.ToString() + "\\Picture"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\Picture");
                Properties.Resources._0.Save(Application.StartupPath.ToString() + "\\Picture\\1.jpg");
                Properties.Resources._1.Save(Application.StartupPath.ToString() + "\\Picture\\2.jpg");
                Properties.Resources._2.Save(Application.StartupPath.ToString() + "\\Picture\\3.jpg");
                Properties.Resources._3.Save(Application.StartupPath.ToString() + "\\Picture\\4.jpg");
                Properties.Resources._4.Save(Application.StartupPath.ToString() + "\\Picture\\5.jpg");
                Properties.Resources._5.Save(Application.StartupPath.ToString() + "\\Picture\\6.jpg");
              

            }
            Random r = new Random();
            int i = r.Next(6);
            originalpicpath = Application.StartupPath.ToString() + "\\Picture\\" + i.ToString() + ".jpg";
            Flow(originalpicpath, true);
        }



        private void  Puzzle_Paint(object sender,PaintEventArgs e)
        {
            if(rect!=Rectangle.Empty)
            {
                if(isDrag)
                {
                    e.Graphics.DrawRectangle(Pens.White, rect);
                }
                else
                {
                    e.Graphics.DrawRectangle(new Pen(this.BackColor), rect);
                }
            }
        }



        /// <summary>
        /// 不好用
        /// </summary>
        /// <returns></returns>
        public PictureBox GetPictureBoxByLocation()
        {
            PictureBox pic = null;
            if(this.ActiveControl.Name.Contains("pictureBox"))
            {
                pic = (PictureBox)this.ActiveControl;
            }
            return pic;
        }
        public PictureBox GetPictureBoxByLocation(MouseEventArgs e)
        {
            PictureBox pic = null;
            foreach (PictureBox item in pictureList)
            {
                if (e.Location.X> item.Location.X && e.Location.Y > item.Location.Y && item.Location.X +
                    SideLength > e.Location.X && item.Location.Y + SideLength > e.Location.Y)
                {
                    pic = item;
                }
            }
            return pic;
        }
        public PictureBox GetPictureBoxByLocation(int x,int y)
        {
            PictureBox pic = null;
            foreach(PictureBox item in pictureList)
            {
                if(x>item.Location.X&&y>item.Location.Y&&item.Location.X+
                    SideLength>x&&item.Location.Y+SideLength>y)
                {
                    pic = item;
                }
            }
            return pic;
        }



        /// <summary>
        /// 通过hashcode获取picture,用mouseeventargs之后获取相对于picture的坐标，不是相对窗体
        /// </summary>
        /// <param name="hascode"></param>
        /// <returns></returns>
        public PictureBox GetPictureBoxByHashCode(string hascode)
        {
            PictureBox pic = null;
            foreach(PictureBox item in pictureList)
            {
                if(hascode==item.GetHashCode().ToString())
                {
                    pic = item;
                }
            }
            return pic;
        }



        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            oldLocation = new Point(e.X, e.Y);
            currentPictureBox = GetPictureBoxByHashCode(sender.GetHashCode().ToString());
            MoseDown(currentPictureBox, sender, e);
        }
        public void MoseDown(PictureBox pic, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldLocation = e.Location;
                rect = pic.Bounds;
            }
        }



        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
                rect.Location = getPointToForm(new Point(e.Location.X - oldLocation.X,
                    e.Location.Y - oldLocation.Y));
                this.Refresh();
            }
        }
        private void reset()
        {
            mouseDownPoint = Point.Empty;
            rect = Rectangle.Empty;
            isDrag = false;
        }


        private Point getPointToForm(Point p)
        {
            return this.PointToClient(pictureList[0].PointToScreen(p));
        }



        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            oldLocation = new Point(currentPictureBox.Location.X, currentPictureBox.Location.Y);
            if (oldLocation.X + e.X > 600 || oldLocation.Y + e.Y > 600 || oldLocation.X + e.X < 0 || oldLocation.Y + e.Y < 0)
            {
                return;
            }
            haveToPictureBox = GetPictureBoxByLocation(oldLocation.X + e.X, oldLocation.Y + e.Y);
            newLocation = new Point(haveToPictureBox.Location.X, haveToPictureBox.Location.Y);
            haveToPictureBox.Location = oldLocation;
            PictureMouseUp(currentPictureBox, sender, e);
            if (Judge())
            {
                lab_result.Text = "成功！";
            }
        }
        public void PictureMouseUp(PictureBox pic, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrag)
                {
                    isDrag = false;
                    pic.Location = newLocation;
                    this.Refresh();
                }
                reset();
            }
        }



        public void ExchangePictureBox(MouseEventArgs e)
        {
        }
       
        /// <summary>
        /// 判断是否拼图成功
        /// </summary>
        /// <returns></returns>
        public bool Judge()
        {
            bool result = true;
            int i = 0;
            foreach (PictureBox item in pictureList)
            {
                if (item.Location != pointList[i])
                {
                    result = false;
                }
                i++;
            }
            return result;
        }




        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog new_picture = new OpenFileDialog();
            if (new_picture.ShowDialog() == DialogResult.OK)
            {
                lab_result.Text = "";
                new_picture.ShowDialog();
                CutPicture.PicturePath = new_picture.FileName;
                Flow(CutPicture.PicturePath, true);
                CountTime();
            }
        }

        public void CountTime()
        {
            lab_time.Text = "0";
            timer1.Start();
        }


        public void ImportBitMap()
        {
            try
            {
                int i = 0;
                foreach(PictureBox item in pictureList)
                {
                    Bitmap temp = CutPicture.BitMapList[i];
                    item.Image = temp;
                    i++;
                }
                ResetPictureLocation();
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
         

        /// <summary>
        /// 打乱列表位置
        /// </summary>
        ///<returns></returns>
        public Point[] DisOrderLocation()
        {
            Point[] tempArray = (Point[])pointList.Clone();
            for (int i = tempArray.Length - 1; i > 0; i--)
            {
                Random rand = new Random();
                int p = rand.Next(i);
                Point temp = tempArray[p];
                tempArray[p] = tempArray[i];
                tempArray[i] = temp;
            } 
                return tempArray;     
        }


        /// <summary>
        /// 重新设置图片位置
        /// </summary>
        public void ResetPictureLocation()
        {
            Point[] temp = DisOrderLocation();
            int i = 0;
            foreach(PictureBox item in pictureList)
            {
                item.Location = temp[i];
                i++;
            }
        }



        private void btn_Originalpic_Click(object sender, EventArgs e)
        {
            Form_Original original = new Form_Original();
           original.ShowDialog();
   
        }

        
        private void btn_Changepic_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(7);
            originalpicpath = Application.StartupPath.ToString() + "\\Picture\\" + i.ToString() + ".jpg";
            Flow(originalpicpath, true);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Flow(originalpicpath,true);
        }

       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_sta_Click(object sender, EventArgs e)
        {
            if(Judge()) Flow(originalpicpath, true);
            second = 0;
            lab_result.Text = "";
            timer1.Start();
            timer2.Start();
        }
        private void lal_res_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitRandomPictureBox();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer2.Enabled = false;
            lab_result.Text = "失败";
            timer1.Enabled = false;
            Flow(originalpicpath, true);
            second = 0;
            lab_time.Text = "0 s";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Judge())
            {
                timer2.Stop();
                timer1.Stop();
            }
            second++;
            lab_time.Text = second.ToString() + " s";
           
        }
    }
}
