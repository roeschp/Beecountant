
using Accountant.Util;
using Newtonsoft.Json;
using static Accountant.Util.Util;

namespace Accountant.Objects
{
    public static class ObjectManager
    {
        public static Action<string>? CustomerChanged;
        private static List<ProductObject> CurrentProductList;
        private static List<ProductObject> ProductListB2C;
        private static List<ProductObject> ProductListB2B;
        private static List<CustomerObject> CustomerList = new List<CustomerObject>();
        private static CustomerObject Customer;

        public static void SetCustomerObject(CustomerObject tCustomer)
        {
            if (tCustomer != null)
            {
                Customer = tCustomer;
                ChangeProductList(tCustomer.Relation);

                if (CustomerList.Contains(tCustomer) == false)
                {
                    CustomerList.Add(tCustomer);
                    CustomerListChanged();
                }

                if (!string.IsNullOrEmpty(tCustomer.CompanyName))
                    CustomerChanged?.Invoke(tCustomer.CompanyName);
            }
        }

        public static CustomerObject? GetCustomerObject()
        {
            if (Customer != null)
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
            if (!string.IsNullOrEmpty(tCustomerName))
            {
                var aObject = CustomerList.FirstOrDefault(C => C.CompanyName == tCustomerName);

                if (aObject != null)
                {
                    Customer = aObject;
                    ChangeProductList(aObject.Relation);
                }
            }
        }

        private static void ChangeProductList(BusinessRelation tRelation)
        {
            switch (tRelation)
            {
                case BusinessRelation.B2B:
                    {
                        CurrentProductList = ProductListB2B;
                        break;
                    }
                case BusinessRelation.B2C:
                    {
                        CurrentProductList = ProductListB2C;
                        break;
                    }
            }
        }

        private static void CustomerListChanged()
        {
            string aPath = Path.Combine(PathExecutable, CustomerListFolder, CustomerListName);

            if (File.Exists(aPath))
            {
                string aJson = JsonConvert.SerializeObject(CustomerList, Formatting.None);

                if (!string.IsNullOrEmpty(aJson))
                    File.WriteAllText(aPath, aJson);
            }
        }


        public static void AddProductList(List<ProductObject> tProductList, BusinessRelation tRelation)
        {
            if (tProductList == null)
                return;

            switch (tRelation)
            {
                case BusinessRelation.B2C:
                    {
                        ProductListB2C = new List<ProductObject>();

                        foreach (var tProduct in tProductList)
                        {
                            if (tProduct != null)
                            {
                                ProductListB2C.Add(tProduct);
                            }
                        }
                        break;
                    }
                case BusinessRelation.B2B:
                    {
                        ProductListB2B = new List<ProductObject>();

                        foreach (var tProduct in tProductList)
                        {
                            if (tProduct != null)
                            {
                                ProductListB2B.Add(tProduct);
                            }
                        }
                        break;
                    }
            }
        }

        public static void SafeProductList(BusinessRelation tRelation)
        {
            switch (tRelation)
            {
                case BusinessRelation.B2C:
                    {
                        var aContent = JsonConvert.SerializeObject(ProductListB2C, Formatting.Indented);
                        File.WriteAllText(Path.Combine(Util.Util.PathExecutable, Util.Util.PriceListFolder, Util.Util.PriceListB2C), aContent);
                        break;
                    }
                case BusinessRelation.B2B:
                    {
                        var aContent = JsonConvert.SerializeObject(ProductListB2B, Formatting.Indented);
                        File.WriteAllText(Path.Combine(Util.Util.PathExecutable, Util.Util.PriceListFolder, Util.Util.PriceListB2B), aContent);
                        break;
                    }
            }
        }

        public static CustomerObject GetCustomer()
        {
            if (CustomerList.Count > 0)
            {
                return CustomerList[0];
            }
            else
            {
                return null;
            }
        }

        public static List<ProductObject> GetCurrentProductList()
        {
            return CurrentProductList;
        }

        public static List<ProductObject> GetProductListB2C()
        {
            return ProductListB2C;
        }

        public static List<ProductObject> GetProductListB2B()
        {
            return ProductListB2B;
        }

        public static Selection GetSelectionState(string tProduct)
        {
            Enum.TryParse(tProduct, true, out Product aProduct);

            var aObject = CurrentProductList.Where(p => CurrentProductList.Any(l => p.Name == aProduct)).ToList();

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
            if (Customer != null)
            {
                WordCreater.CreateWord(Customer, tOrderObject);
            }
        }
    }
}
