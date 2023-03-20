using System;
namespace Disaheim
{
	public abstract class Merchandise
	{
        public string ItemId { get; set; }

        //public Merchandise(string itemId)
        //{
        //    ItemId = itemId;
        //}

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }

    }
}

