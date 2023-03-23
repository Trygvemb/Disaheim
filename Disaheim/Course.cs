﻿using System;
namespace Disaheim
{
	public class Course
	{
		public string Name { get; set; }
		public int DurationInMinutes { get; set; }

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
    }
}

