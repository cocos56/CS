using BookManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Frameworrk
{
    public class UIManager:Singleton<UIManager>
    {
        Dictionary<string, BaseView> viewDict = new Dictionary<string, BaseView>();

        List<string> list = new List<string>();
        // select * from student where id = 2000;
        /// <summary>
        /// 打开界面
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Open<T>() where T : BaseView, new()
        {
            string viewname = typeof(T).Name;
            if (!viewDict.ContainsKey(viewname))
            {
                T t = new T();
                viewDict.Add(viewname, t);
            }
            return viewDict[viewname] as T;
        }

        /// <summary>
        /// 关闭界面
        /// </summary>
        public void Close()
        {
            Console.Clear();
        }
    }
}
