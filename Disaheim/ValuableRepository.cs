using System;
namespace Disaheim
{
	public class ValuableRepository : IPersistable
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

		public void Save(string fileName = "ValuableRepository.txt")
		{
			List<string> lines = new List<string>();
			foreach (IValueable valueable in valueables)
			{
				if (valueable is Book book)
				{
					string line = $"BOOK;{book.ItemId};{book.Title};{book.Price}";
					lines.Add(line);
				}
				else if (valueable is Amulet amulet)
				{
					string line = $"AMULET;{amulet.ItemId};{amulet.Design};{amulet.Quality}";
					lines.Add(line);
				}
				else if (valueable is Course course)
				{
					string line = $"COURSE;{course.Name};{course.DurationInMinutes}";
					lines.Add(line);
				}

			}
			File.WriteAllLines(fileName, lines);
		}

		public void Load (string fileName = "ValuableRepository.txt")
		{
			if (!File.Exists(fileName))
			{
				Console.WriteLine("no file was found");
			}

			string[] lines = File.ReadAllLines(fileName);

			foreach (string line in lines)
			{
				string[] lineArray = line.Split(";");

				switch (lineArray[0])
				{
					case "BOOK":
						Book book = new Book(
							lineArray[1],
							lineArray[2],
							Convert.ToDouble(lineArray[3])
							);
						this.AddValuable(book);
						break;
					case "AMULET":
						Amulet amulet = new Amulet(
							lineArray[1],
							(Level)Enum.Parse(typeof(Level), lineArray[2]),
							lineArray[3]
							);
						this.AddValuable(amulet);
						break;
					case "COURSE":
						Course course = new Course(
							lineArray[1],
							Convert.ToInt32(lineArray[2])
							);
						this.AddValuable(course);
						break;
					default:
						break;
				}
			}
		}
	}
}

