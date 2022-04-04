
using Accountant.Util;
using Newtonsoft.Json;
using static Accountant.Util.Util;

namespace Accountant.Objects
{
    public static class ObjectManager
    {
        public static Action<string>? CustomerChanged;
        private static List<ProductObject> ProductList;
        private static List<CustomerObject> CustomerList = new List<CustomerObject>();
        private static CustomerObject Customer;

        public static void SetCustomerObject(CustomerObject tCustomer)
        {
            if (tCustomer != null)
            {
                Customer = tCustomer;

                if (CustomerList.Contains(tCustomer) == false)
                {
                    CustomerList.Add(tCustomer);
                    CustomerListChanged();
                }

                if(!string.IsNullOrEmpty(tCustomer.CompanyName))
                    CustomerChanged?.Invoke(tCustomer.CompanyName);
            }
        }

        public static CustomerObject? GetCustomerObject()
        {
            if(Customer != null)
            {
                return Customer;
            }
            else
            {
                return null;
            }
        }

        public static void CustomerCbChanged(string tCustomerName)
        {
            if(!string.IsNullOrEmpty(tCustomerName))
            {
                var aObject = CustomerList.FirstOrDefault(C => C.CompanyName == tCustomerName);

                if (aObject != null)
                {
                    Customer = aObject;
                }
            }
        }

        private static void CustomerListChanged()
        {
            string aPath = Path.Combine(PathExecutable, CustomerListFolder, CustomerListName);

            if (File.Exists(aPath))
            {
                string aJson = JsonConvert.SerializeObject(CustomerList, Formatting.None);
                
                if(!string.IsNullOrEmpty(aJson))
                    File.WriteAllText(aPath, aJson);
            }
        }

        public static void AddProduct(ProductObject tProduct)
        {
            if(tProduct != null)
                ProductList.Add(tProduct);
        }

        public static CustomerObject GetCustomer()
        {
            return CustomerList[0];
        }
        
        public static List<ProductObject> GetProductList()
        {
            return ProductList;
        }

        public static void CreateFile(OrderObject tOrderObject)
        {
            if(Customer != null)
            {
                WordCreater.CreateWord(Customer, tOrderObject);
            }
        }
    }
}
