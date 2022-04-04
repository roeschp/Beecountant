using Accountant.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Accountant.Util.Util;

namespace Accountant.Forms
{
    public partial class SettingForm : UserControl
    {
        List<ProductObject> products;

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

            if (!String.IsNullOrEmpty(aString))
            {
                var aRegex = Regex.Match(aString, @"(?<product>.*)_(?<weight>.*)");

                if (aRegex.Success)
                {
                    var aResult = products.SingleOrDefault(p => p.Name.ToString() == aRegex.Groups["product"].Value && p.Weight == aRegex.Groups["weight"].Value);
                
                }
            }
        }

        private void SetValues(ProductObject tProduct)
        {
            if (products != null)
            {
                txtPrice.Text = tProduct.SinglePrice.ToString();

                switch(tProduct.Selection)
                {
                    case Selection.Single:
                        {

                            break;
                        }
                    case Selection.Multi:
                        {

                            break;
                        }
                }
            }
        }
    }
}
