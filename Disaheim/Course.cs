using System;
namespace Disaheim
{
	public class Course : IValueable
	{
		public string Name { get; set; }
		public int DurationInMinutes { get; set; }

		
		public static double _courseHourValue = 875.0;
        public static double CourseHourValue
        {
            get { return CourseHourValue; }
            set { _courseHourValue = value; }
        }

        public Course(string name, int durationInMinutes)
		{
			Name = name;
			DurationInMinutes = durationInMinutes;
		}

		public Course(string name) : this(name, 0) { }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }

        public double GetValue() 
        {

            int hour = DurationInMinutes / 60;

            if (DurationInMinutes % 60 == 0)
            {
                return CourseHourValue * hour;
            }
            else { return CourseHourValue * (hour + 1); }

        }

        //public double GetValue()
        //{
        //    // Påbegyndte timer
        //    int hours = DurationInMinutes / 60;
        //    // Minuter i overskud.
        //    double remaingMinutes = DurationInMinutes % 60;

        //    if (remaingMinutes > 0) { return (hours + 1) * CourseHourValue; }
        //    else { return hours * CourseHourValue; }
        //}
    }
}

