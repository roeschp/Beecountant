using Accountant.Forms;
using Accountant.Objects;
using System.Data;
using System.Reflection;
using System.Text;
using static Accountant.Util.Util;

namespace Accountant
{
    public partial class ufProductSelection : UserControl
    {
        public Action<Control>? RemoveControl;

        private ProductObject CurrentProduct;

        public ufProductSelection()
        {
            InitializeComponent();

            var aList = Enum.GetValues(typeof(Product)).Cast<Product>().ToList();

            foreach (var aProduct in aList)
            {
                cbProducts.Items.Add(aProduct);
            }

            if(cbProducts.Items.Count > 0)
                cbProducts.SelectedIndex = 0;
        }

        public ProductObject GetProduct()
        {
            if(Enum.TryParse(cbProducts.Text, true, out Product aProduct))
            {
                CurrentProduct.Name = aProduct;
                CurrentProduct.Weight = cbUnit.Text;
                CurrentProduct.Unit = lbUnit.Text;
                CurrentProduct.Count = Convert.ToInt16(nrProductCount.Value);
                CurrentProduct.SinglePrice = Convert.ToDouble(txtSingleProductPrice.Text);
                CurrentProduct.SubTotal = Convert.ToDouble(txtTotalProductPrice.Text);
            };

            return CurrentProduct;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveControl?.Invoke(this);
        }

        private bool CreateCurrentProductObject()
        {
            if (Enum.TryParse(cbProducts.Text, true, out Product aProduct))
            {
                var aObjectList = ObjectManager.GetCurrentProductList();

                foreach (var aObject in aObjectList)
                {
                    if (aProduct == aObject.Name)
                    {
                        CurrentProduct = aObject;
                        return true;
                    }
                }
            }
            return false;
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selection aSelection = ObjectManager.GetSelectionState(cbProducts.Text);
            nrProductCount.Value = 1;
            
            switch(aSelection)
            {
                case Selection.Multi:
                    {
                        Capacity capa = new Capacity();
                        Type aStructType = typeof(Capacity);
                        var aFields = aStructType.GetFields();

                        cbUnit.Items.Clear();

                        foreach (var aField in aFields)
                        {
                            cbUnit.Items.Add(string.Format($"{aField.GetValue(capa)}"));
                        }

                        if (cbUnit.Items.Count > 0)
                            cbUnit.SelectedIndex = 0;

                        if(CurrentProduct != null)
                            lbUnit.Text = CurrentProduct.Unit;

                        break;
                    }
                case Selection.Single:
                    {
                        LoadSingleContent();
                        break;
                    }
            }
        }

        private void LoadSingleContent()
        {
            if(CreateCurrentProductObject())
            {
                cbUnit.Items.Clear();

                if (CurrentProduct.SinglePrice != null)
                    txtSingleProductPrice.Text = CurrentProduct.SinglePrice.ToString();

                if (CurrentProduct.Weight != null)
                {
                    cbUnit.Items.Add(CurrentProduct.Weight.ToString());
                    cbUnit.SelectedIndex = 0;
                }

                if (CurrentProduct.Unit != null)
                    lbUnit.Text = CurrentProduct.Unit.ToString();
            }
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CreateCurrentProductObject())
            {
                var aObjectList = ObjectManager.GetCurrentProductList();

                var aProduct = aObjectList.SingleOrDefault(Product => Product.Name == CurrentProduct.Name && Product.Weight == cbUnit.Text);
                
                if (aProduct != null)
                {
                    txtSingleProductPrice.Text = Math.Round((double)aProduct.SinglePrice, 2).ToString();
                    txtTotalProductPrice.Text = Math.Round((double)aProduct.SinglePrice, 2).ToString();
                }
            }

        }

        private void nrProductCount_ValueChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSingleProductPrice.Text) == false)
            {
                double aProductPrice = Convert.ToDouble(txtSingleProductPrice.Text);
                var aTotalProductPrice = aProductPrice * (int)nrProductCount.Value;
                txtTotalProductPrice.Text = Math.Round((double)aTotalProductPrice, 2).ToString();
            }
        }
    }
}
