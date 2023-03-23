using System;
namespace Disaheim
{
	public class Utility
	{
		private double _lowQualityValue = 12.5;
        private double _mediumQualityValue = 20.0;
        private double _highQualityValue = 27.5;
        private double _courseHourValue = 875.0;

		public double LowQualityValue
		{
			get { return _lowQualityValue; }
			set { _lowQualityValue = value; }
		}
		public double MediumQualityValue
		{
			get { return _mediumQualityValue; }
			set { _mediumQualityValue = value; }
		}
		public double HighQualityValue
		{
			get { return _highQualityValue; }
			set { _highQualityValue = value; }
		}
		public double CourseHourValue
		{
			get { return _courseHourValue; }
			set { _courseHourValue = value; }
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

		public double GetValueOfMerchandise(Merchandise merchandise)
		{
            if (merchandise is Book book)
			{
				return book.Price;
			}
			else if (merchandise is Amulet amulet)
			{
                if (amulet.Quality == Level.low)
                {
					return LowQualityValue;
				}
                if (amulet.Quality == Level.medium)
                {
					return MediumQualityValue;
				}
                if (amulet.Quality == Level.high)
                {
					return HighQualityValue;
				}
                return 0;
            }
			return 0;
        }
    }
}

