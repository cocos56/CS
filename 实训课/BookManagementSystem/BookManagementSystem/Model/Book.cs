using System;

namespace BookManagementSystem.Model
{
	public class Book
	{
		/// <summary>
		/// id
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// ISBN
		/// </summary>
		public string ISBN { get; set; }

		public string Name { get; set; }

		public string Author { get; set; }

		public int Count { get; set; }

		public override string ToString(){
			Console.WriteLine();
			return string.Format("ID:{0} ISBN:{1} Book Name:{2} Author:{3} Count:{4}",ID,ISBN,Name,Author,Count);
		}
	}
}