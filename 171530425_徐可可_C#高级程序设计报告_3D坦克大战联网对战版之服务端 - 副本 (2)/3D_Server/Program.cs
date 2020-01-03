namespace Game
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//连接数据库
			if(!DbManager.Connect(DBConfiguration.db, DBConfiguration.ip, DBConfiguration.port, DBConfiguration.user, DBConfiguration.pw)){
				return;
			}

			//启动程序并监听82端口
			NetManager.StartLoop(82);
		}
	}
}