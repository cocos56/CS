namespace BookManagementSystem.Model
{
	public class Manager:Role
	{
		public override string ToString()
		{
			return string.Format("ID:{0} Username:{1} IdentifyType:{2}", ID, Username, IdentifyType.ToString());
		}
	}
}
