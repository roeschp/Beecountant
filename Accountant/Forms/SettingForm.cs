using Accountant.Objects;
using System.Text.RegularExpressions;

namespace Accountant.Forms
{
    public partial class SettingForm : UserControl
    {
        private List<ProductObject> products;
        private ProductObject? ProductObj;

        public SettingForm(List<ProductObject> tProductList)
        {
            InitializeComponent();

            if(tProductList != null)
            {
                products = tProductList;

                foreach (ProductObject aProduct in tProductList)
                {
                    cbProduct.Items.Add($"{aProduct.Name}_{aProduct.Weight}");
                    cbProduct.SelectedIndex = 0;
                }
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aString = cbProduct.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(aString))
            {
                var aRegex = Regex.Match(aString, @"(?<product>.*)_(?<weight>.*)");

                if (aRegex.Success)
                {
                    ProductObj = products.SingleOrDefault(p => p.Name.ToString() == aRegex.Groups["product"].Value && p.Weight == aRegex.Groups["weight"].Value);

                    if (ProductObj != null)
                    {
                        SetValues(ProductObj);
                    }
                }
            }
        }

        private void SetValues(ProductObject tProduct)
        {
            if (products != null)
            {
                txtPrice.Text = tProduct.SinglePrice.ToString();
                txtCapacity.Text = tProduct.Weight.ToString();
                txtUnit.Text = tProduct.Unit.ToString();
            }
        }

        private bool ChangeProduct(ProductObject newProduct)
        {
            if (newProduct == null)
                return false;

            var lastProduct = products.SingleOrDefault(p => p.Name == newProduct.Name && p.Weight == newProduct.Weight);

            if (lastProduct != null)
            {
                products.Remove(lastProduct);
                products.Add(newProduct);
                return true;
            }

            return false;
        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            if (ProductObj == null)
                return;

            if(string.IsNullOrEmpty(txtPrice.Text))
            {
                lbPrice.ForeColor = Color.Red;
                return;
            }

            if(string.IsNullOrEmpty(txtCapacity.Text))
            {
                lbCapacity.ForeColor = Color.Red;
                return;
            }

            ProductObject ProductChange = ProductObj;
            ProductChange.SinglePrice = Convert.ToDouble(txtPrice.Text);
            ProductChange.Weight = txtCapacity.Text;
            ProductChange.Unit = txtUnit.Text;

            if((ProductChange.SinglePrice != ProductObj.SinglePrice)
                || (ProductChange.Weight != ProductObj.Weight)
                || (ProductChange.Unit != ProductObj.Unit))
            {
                DialogResult aResult = MessageBox.Show($"Möchtest du wirklich das Produkt {ProductChange.Name} ändern?", "Einstellungsänderung", MessageBoxButtons.YesNoCancel);

                if (aResult == DialogResult.Yes)
                {
                    if(ChangeProduct(ProductChange))
                    {
                        ObjectManager.AddProductList(products);
                    }
                }
                return;
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            lbPrice.ForeColor = Color.Black;
        }

        private void txtCapacity_Enter(object sender, EventArgs e)
        {
            lbCapacity.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormManager.CustomerInputClosed(this);
        }
    }
}
