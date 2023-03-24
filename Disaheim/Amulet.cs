using System;
namespace Disaheim
{
	public class Amulet : Merchandise
	{
       
        //public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        public static double _lowQualityValue = 12.5;
        public static double LowQualityValue
        {
            get { return _lowQualityValue; }
            set { _lowQualityValue = value; }
        }
        public static double _mediumQualityValue = 20.0;
        public static double MediumQualityValue
        {
            get { return _mediumQualityValue; }
            set { _mediumQualityValue = value; }
        }
        public static double _highQualityValue = 27.5;
        public static double HighQualityValue
        {
            get { return _highQualityValue; }
            set { _highQualityValue = value; }
        }

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

