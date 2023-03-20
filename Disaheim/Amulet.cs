using System;
namespace Disaheim
{
	public class Amulet : Merchandise
	{
       
        //public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId, Level quality, string design) //: base(itemId)
        {
            base.ItemId = itemId;
            Quality = quality;
			Design = design;
        }
        public Amulet(string itemId, Level quality) : this(itemId, quality, "") { }
        public Amulet(string itemId) : this(itemId, Level.medium, "") { }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}

