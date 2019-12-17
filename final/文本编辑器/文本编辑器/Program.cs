using System;
using System.Windows.Forms;

namespace 文本编辑器
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//C# 文本编辑器
//使用C#开发的简化版文本编辑器， １）主菜单含有三栏：文件、编辑、格式、查看、帮助。 ２）文件菜单栏中含有四个子菜单：新建、打开、保存、退出。 ３）编辑菜单栏中含有五个子菜单：复制、剪切、粘贴、撤消、恢复。 ４）格式菜单栏中含有字体子菜单； ５）查看菜单栏中含有状态栏信息； ６）帮助菜单栏中含...