using System;
namespace Disaheim
{
	public class Controller
	{
		//public List<Book> Books { get; set; }
		//public List<Amulet> Amulets { get; set; }
		//public List<Course> Courses { get; set; }

		//private BookRepository bookRepo;
		private MerchandiseReposity merchandiseRepo;
		private CourseRepository courseRepo;

		public Controller()
		{
            //bookRepo = new BookRepository();
            merchandiseRepo = new MerchandiseReposity();
			courseRepo = new CourseRepository();
		}


		public void AddToList(Merchandise merchandise)
		{
			{
				merchandiseRepo.AddMerchandise(merchandise);
			}	
		}
		//public void AddToList(Book book)
		//{
		//	bookRepo.AddBook(book);
		//}
		//public void AddToList(Amulet amulet)
		//{
		//  amuletRepo.AddAmulet(amulet);
		//}
		public void AddToList(Course course)
		{
			courseRepo.AddCourse(course);
		}
    }
}

