using System;
namespace Disaheim
{
	public class Utility
	{
		public double GetValueOfBook(Book book)
		{
			return book.Price;
		}
        public double GetValueOfAmulet(Amulet amulet)
        {
			if (amulet.Quality == Level.low) { return 12.5; }
            if (amulet.Quality == Level.medium) { return 20; }
            if (amulet.Quality == Level.high){ return 27.5; }
			return 0;
        }
    }
}

