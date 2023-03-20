using System;
namespace Disaheim
{
	public class Merchandise
	{
        public virtual string ItemId { get; set; }

        public Merchandise(string itemId)
        { ItemId = itemId; }

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }

    }
}

