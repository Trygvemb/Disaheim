using System;
using Disaheim;
namespace UtilityLib
{
	public class Utility
	{
		public double GetValueOfBook(Book book)
		{
			return book.Price;
		}
        public double GetValueOfAmulet(Amulet amulet)
        {
			if (amulet.Quality == Level.low)
			{ return 12.5; }
            if (amulet.Quality == Level.medium)
			{ return 20; }
            if (amulet.Quality == Level.high)
			{ return 27.5; }
			return 0;
        }
		public double GetValueOfCourse(Course course)
		{
			
			int hour = course.DurationInMinutes / 60;
			
			if (course.DurationInMinutes % 60 == 0)
			{
				
				return 875.00 * hour;
			}
			else { return 875.00 * (hour + 1); }

		}
    }
}

