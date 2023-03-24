using System;
namespace Disaheim
{
	public class ValuableRepository
	{
		private List<IValueable> valueables = new List<IValueable>();

		public void AddValuable(IValueable valueable)
		{
			valueables.Add(valueable);
		}

		public IValueable GetValuable(string itemId)
		{
			foreach(IValueable valueable in valueables)
			{
				if (valueable is Course course)
				{
					if (course.Name == itemId)
						return course;
				}
				else if (valueable is Merchandise merchandise)
				{
					if (merchandise.ItemId == itemId)
						return merchandise;
				}
			}
			return null;
		}

		public double GetTotalValue()
		{
			double sum = 0;

			foreach (IValueable valueable in valueables)
			{
				sum += valueable.GetValue();
			}
			return sum;
		}

		public int Count()
		{
			int count = 0;

			foreach (IValueable valueable in valueables)
			{
				count++;
			}
			return count;
		}
	}
}

