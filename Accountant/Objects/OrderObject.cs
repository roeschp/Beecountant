namespace Accountant.Objects
{
    public class OrderObject
    {
        public string Id;
        public double Price;
        public List<ProductObject> Products;

        public OrderObject()
        {
            Id = string.Empty;
            Price = 0;
            Products = new List<ProductObject>();
        }
    }
}
