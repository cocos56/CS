using BookManagementSystem.View;
using BookManagementSystem.Frameworrk;

namespace BookManagementSystem
{	
	class Program
	{
		static void Main(string[] args)
		{
			UIManager.Instance.Open<EnterView>().Enter();
		}
	}
}