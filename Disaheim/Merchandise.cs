using System;
namespace Disaheim
{
	public abstract class Merchandise : IValueable
	{
        public string ItemId { get; set; }

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }


        public double GetValue()
        {
                if (this is Book book)
                {
                    return book.Price;
                }
                else if (this is Amulet amulet)
                {
                    if (amulet.Quality == Level.low)
                    {
                        return Amulet.LowQualityValue;
                    }
                    if (amulet.Quality == Level.medium)
                    {
                        return Amulet.MediumQualityValue;
                    }
                    if (amulet.Quality == Level.high)
                    {
                        return Amulet.HighQualityValue;
                    }
                    return 0;
                }
                return 0;
        }

    }
}

