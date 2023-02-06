using Accountant.Objects;
using System.Text.RegularExpressions;

namespace Accountant.Forms
{
    public partial class SettingForm : UserControl
    {
        private List<ProductObject> products;
        private List<ProductObject> productBackup;
        private ProductObject? ProductObj;

        public SettingForm()
        {
            InitializeComponent();

            products = new List<ProductObject>();
            productBackup = new List<ProductObject>();


            var aTaxes = Math.Round((Util.Util.TaxesFactor - 1) * 100, 2);
            txtTaxes.Text = aTaxes.ToString();

            rdB2B.Checked = true;
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
                txtCapacity.Text = tProduct?.Weight?.ToString();
                txtUnit.Text = tProduct?.Unit?.ToString();
            }
        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            if (ProductObj == null)
                return;

            var aTaxes = Convert.ToDouble(txtTaxes.Text);
            Util.Util.TaxesFactor = Math.Round((aTaxes / 100) + 1, 4);

            Properties.Settings.Default.TaxValue = Convert.ToString(Util.Util.TaxesFactor);
            Properties.Settings.Default.Save();

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                lbPrice.ForeColor = Color.Red;
                return;
            }

            var aChangeList = productBackup.Where(c => products.Any(d => c.SinglePrice != d.SinglePrice && c.Name == d.Name && c.Weight == d.Weight)).ToList();


            if (aChangeList.Count >= 0)
            {

                foreach (var aBackup in aChangeList)
                {
                    var aChangeBack = products.Find(c => c.Name == aBackup.Name && c.Weight == aBackup.Weight);

                    if (aChangeBack != null)
                    {
                        DialogResult aResult = MessageBox.Show($"Möchtest du wirklich das Produkt \'{aChangeBack?.Name}\' ändern auf \'{aChangeBack?.SinglePrice}€\'?", "Preisänderung", MessageBoxButtons.YesNo);

                        if (aResult == DialogResult.No)
                        {
                            aChangeBack.SinglePrice = aBackup.SinglePrice;
                        }
                    }
                }

                if (rdB2B.Checked)
                {
                    ObjectManager.AddProductList(products, Util.Util.BusinessRelation.B2B);
                    ObjectManager.SafeProductList(Util.Util.BusinessRelation.B2B);
                }
                else
                {
                    ObjectManager.AddProductList(products, Util.Util.BusinessRelation.B2C);
                    ObjectManager.SafeProductList(Util.Util.BusinessRelation.B2C);
                }
            }

            FormManager.CustomerInputClosed(this);
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

        private void rdB2C_CheckedChanged(object sender, EventArgs e)
        {
            var aListB2C = ObjectManager.GetProductListB2C();

            if (aListB2C != null)
            {
                products = aListB2C;

                productBackup = new List<ProductObject>();

                productBackup = Util.Util.DeepCopy(products);


                cbProduct.Items.Clear();

                foreach (ProductObject aProduct in aListB2C)
                {
                    cbProduct.Items.Add($"{aProduct.Name}_{aProduct.Weight}");
                    cbProduct.SelectedIndex = 0;
                }
            }
        }


        private void rdB2B_CheckedChanged(object sender, EventArgs e)
        {
            var aListB2B = ObjectManager.GetProductListB2B();

            if (aListB2B != null)
            {
                products = aListB2B;
                productBackup = new List<ProductObject>();

                productBackup = Util.Util.DeepCopy(products);

                cbProduct.Items.Clear();

                foreach (ProductObject aProduct in aListB2B)
                {
                    cbProduct.Items.Add($"{aProduct.Name}_{aProduct.Weight}");
                    cbProduct.SelectedIndex = 0;
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            var aChange = txtPrice.Text;

            if (string.IsNullOrEmpty(aChange) == false && ProductObj != null)
            {
                var aChangeProduct = products.SingleOrDefault(p => p.Name == ProductObj.Name && p.Weight == ProductObj.Weight);

                if (aChangeProduct != null)
                    aChangeProduct.SinglePrice = Convert.ToDouble(aChange);
            }
        }
    }
}
