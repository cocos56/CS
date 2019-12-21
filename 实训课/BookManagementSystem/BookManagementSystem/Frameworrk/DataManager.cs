using BookManagementSystem.Model;

namespace BookManagementSystem.Frameworrk
{
	public class DataManager:Singleton<DataManager>
	{
		public IdentifyType CurrentIdentifyType;

		public Role CurrentRole;
	}
}