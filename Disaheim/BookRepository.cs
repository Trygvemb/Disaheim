using System;
namespace Disaheim
{
	public class BookRepository
	{
		private List<Book> books = new List<Book>();

		public void AddBook(Book book)
		{
			books.Add(book);
		}

		public Book GetBook(string itemId) //: base(itemId)
		{
			foreach (Book book in books)
			{
				if (book.ItemId == itemId)
				return book; 
			}
			return null;
		}

		public double GetTotalValue()
		{
			Utility utility = new Utility();
			double total = 0;

			foreach (Book book in books)
			{
				total += utility.GetValueOfBook(book);
				
			}
			return total;
		}

    }
}

