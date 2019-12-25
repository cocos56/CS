using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16EventHandler
{
   public class Bridegroom
	{
		//EventHandler只用来处理不包含事件处理的事件。
	   //如果我们想在这种方式定义的事件中包含事件数据，则可以通过派生EventArgs来实现。
		public event EventHandler MarryEvent;
		public void onMarriageComing(string msg)
		{
			if (MarryEvent != null)
			{
				//触发事件				
				MarryEvent(this, new EventArgs());		   
			}
		}

	}
}
