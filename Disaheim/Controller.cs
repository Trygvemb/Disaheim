using System;
namespace Disaheim
{
	public class Controller
	{
		//public List<Book> Books { get; set; }
		//public List<Amulet> Amulets { get; set; }
		//public List<Course> Courses { get; set; }

		private BookRepository bookRepo;
		private AmuletRepository amuletRepo;
		private CourseRepository courseRepo;

		public Controller()
		{
			bookRepo = new BookRepository();
			amuletRepo = new AmuletRepository();
			courseRepo = new CourseRepository();
		}

		public void AddToList(Book book)
		{
			bookRepo.AddBook(book);
		}
        public void AddToList(Amulet amulet)
        {
            amuletRepo.AddAmulet(amulet);
        }
		public void AddToList(Course course)
		{
			courseRepo.AddCourse(course);
		}
    }
}

