namespace _15Event事件
{
	public class Bridegroom
	{
		//自定义委托
		public delegate void MarryHandler(string msg);

		//使用自定义委托定义事件，事件名为MarryEvent
		public event MarryHandler MarryEvent;

		public void onMarriageComing(string msg)
		{
			if (MarryEvent != null)
			{
				//触发事件				
				MarryEvent(msg);
			}
		}
	}
}
