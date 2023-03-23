using System;
namespace Disaheim
{
	public class MerchandiseReposity
	{
        private List<Merchandise> Merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            Merchandises.Add(merchandise);
        }

        public Merchandise GetMerchndise(string itemId)
        {
            foreach (Merchandise merchandise in Merchandises)
            {
                if (merchandise.ItemId == itemId)
                    return merchandise;
            }
            return null;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double total = 0;

            foreach (Merchandise merchandise in Merchandises)
            {
                total += utility.GetValueOfMerchandise(merchandise);
            }
            return total;
        }

    }
}

