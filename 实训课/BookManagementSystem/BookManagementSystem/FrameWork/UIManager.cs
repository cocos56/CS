using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.View;

namespace BookManagementSystem.FrameWork
{
	class UIManager:Singleton<UIManager>
	{
		Dictionary<string, BaseView> viewDict = new Dictionary<string, BaseView>();
		/// <summary>
		/// 打开界面
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public T Open<T>() where T : BaseView, new()
		{
			string viewName = typeof(T).Name;
			Console.WriteLine(viewName);
			if (! viewDict.ContainsKey(viewName))
			{
				T t = new T();
				viewDict.Add(viewName, t);
			}
			return viewDict[viewName] as T;
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
