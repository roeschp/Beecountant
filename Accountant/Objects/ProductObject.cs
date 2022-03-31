using static Accountant.Util.Util;

namespace Accountant.Objects
{
    public class ProductObject
    {
        public Product? Name;
        public string? Weight;
        public string? Unit;
        public double? Price;
        public Selection? Selection;

        public ProductObject()
        {
            Name = null;
            Weight = null; 
            Unit = null;
            Price = null;
            Selection = null;
        }
    }
}
