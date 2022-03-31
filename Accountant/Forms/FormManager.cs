using Accountant.Objects;
using static Accountant.Util.Util;

namespace Accountant.Forms
{
    public static class FormManager
    {
        public static Action<Control>? SelectionClosed;

        private static List<ProductObject> ProductList = new List<ProductObject>();

        public static void CustomerInputClosed(Control tControl)
        {
            SelectionClosed?.Invoke(tControl);
        }

        public static void SetProductToList(ProductObject tObject)
        {
            if (tObject != null)
            {
                ProductList.Add(tObject);
            }
        }

        public static Selection GetSelectionState (string tProduct)
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

        public static List<ProductObject> GetProductList()
        {
            return ProductList;
        }
    }
}
