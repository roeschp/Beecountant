using static Accountant.Util.Util;

namespace Accountant.Objects
{
    [Serializable]
    public class ProductObject
    {
        public Product? Name;
        public string? Weight;
        public string? Unit;
        public double? SinglePrice;
        public double? SubTotal;
        public int? Count;
        public Selection? Selection;

        public ProductObject()
        {
            Name = null;
            Weight = null; 
            Unit = null;
            SinglePrice = null;
            SubTotal = null;
            Count = null;
            Selection = null;
        }
    }
}
