using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;

namespace BookManagementSystem.View
{
	public class BorrowBookView : BaseView
	{
		public void BorrowBookByID()
		{
			int bookId = Utils.InputInt("请输入借书ID：");
			int count = Utils.InputInt("请输入借书数量：");
			User user = DataManager.Instance.CurrentRole as User;
			//BorrowAndReturnBookController.Instance.AddUserBook(user, count, bookId);
		}
	}
}