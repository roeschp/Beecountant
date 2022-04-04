
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

        public static void AddProductList(List<ProductObject> tProductList)
        {
            if (tProductList == null)
                return;

            ProductList = new List<ProductObject>();

            foreach (var tProduct in tProductList)
            {
                if(tProduct != null)
                {
                    ProductList.Add(tProduct);
                }
            }
        }

        public static CustomerObject GetCustomer()
        {
            if(CustomerList.Count > 0)
            {
                return CustomerList[0];
            }
            else
            {
                return null;
            }
            
        }
        
        public static List<ProductObject> GetProductList()
        {
            return ProductList;
        }

        public static Selection GetSelectionState(string tProduct)
        {
            Enum.TryParse(tProduct, true, out Product aProduct);

            var aObject = ProductList.Where(p => ProductList.Any(l => p.Name == aProduct)).ToList();

            if (aObject.Count > 1)
            {
                return Selection.Multi;
            }
            else
            {
                return Selection.Single;
            }

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
