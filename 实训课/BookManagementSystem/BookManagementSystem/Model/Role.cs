namespace BookManagementSystem.Model
{
	public class Role
	{
		public int ID { get; set; }
		public string Username { get; set; }
		public string Passsword { get; set; }

		public IdentifyType IdentifyType { get; set; }
	}
}