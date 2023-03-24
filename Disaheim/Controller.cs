using System;
namespace Disaheim
{
	public class Controller
	{

		public ValuableRepository valuableRepo;

		public Controller()
		{
			valuableRepo = new ValuableRepository();
		}

		public void AddtoList(IValueable valueable)
		{
			valuableRepo.AddValuable(valueable);
		}
    }
}

