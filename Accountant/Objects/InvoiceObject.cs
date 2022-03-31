namespace Accountant.Objects
{
    public class InvoiceObject
    {
        public CustomerObject Customer;
        public List<ProductObject> Products;

        public InvoiceObject()
        {
            Products = new List<ProductObject>();
            Customer = new CustomerObject();
        }
    }
}
