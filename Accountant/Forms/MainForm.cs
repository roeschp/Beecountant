using Accountant.Forms;
using Accountant.Objects;
using Newtonsoft.Json;
using static Accountant.Util.Util;

namespace Accountant
{
    public partial class MainForm : Form
    {
        private List<ufProductSelection> ProductObjectList = new List<ufProductSelection>();
        private List<ProductObject>? ProductList = new List<ProductObject>();
        private int MonthID = 1;

        private JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore,
        };

        public MainForm()
        {
            InitializeComponent();

            FormManager.SelectionClosed += CustomerInputDone;
            ObjectManager.CustomerChanged += ChangeCustomer;

            var aPrivePath = Path.Combine(PathExecutable, PriceListFolder, PriceListName);
            var aCustomerPath = Path.Combine(PathExecutable, CustomerListFolder, CustomerListName);
            var aFolderInfo = new DirectoryInfo(Path.Combine(PathExecutable, "Invoices"));
            
            if(aFolderInfo.Exists)
            {
                var aFiles = aFolderInfo.GetFiles(@$"*{DateTime.Now.Month}-{DateTime.Now.Year}.pdf");
                MonthID = aFiles.Count() + 1;
            }

            var aCustomerList = File.ReadAllText(aCustomerPath);
            var aPriceList = File.ReadAllText(aPrivePath);

            ProductList = JsonConvert.DeserializeObject<List<ProductObject>>(aPriceList, JsonSerializerSettings);

            if(ProductList != null)
            {
                foreach (var aItem in ProductList)
                {
                    if (aItem != null)
                        FormManager.SetProductToList(aItem);
                }
            }

            List<CustomerObject>? aObjectList = JsonConvert.DeserializeObject<List<CustomerObject>>(aCustomerList, JsonSerializerSettings);

            if(aObjectList != null)
            {
                foreach (var aObject in aObjectList)
                {
                    if (aObject != null)
                    {
                        ObjectManager.SetCustomerObject(aObject);

                        if(cbCustomer.Items.Contains(aObject.CompanyName) == false)
                        {
                            cbCustomer.Items.Add(aObject.CompanyName);
                        }
                    }
                }
                if(cbCustomer.Items.Count > 0) 
                    cbCustomer.SelectedIndex = 0;
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (ObjectManager.GetCustomer() == null)
            {
                var aCustomer = new CustomerForm();
                flpProductSelection.Size = new Size(aCustomer.Width, aCustomer.Height);
                flpProductSelection.Controls.Add(aCustomer);
                flpProductSelection.Show();
                btnAddProduct.Enabled = false;
            }
            else
            {
                grpProductTable.Visible = true;
                btnAddCustomer.Enabled = false;
                btnCreate.Visible = true;
                cbCustomer.Enabled = false;

                var aProductSelection = new ufProductSelection();

                Size aSize = new Size(aProductSelection.Width, aProductSelection.Height);

                foreach(var control in flpProductSelection.Controls)
                {
                    aSize.Height += aProductSelection.Height;
                }

                flpProductSelection.Size = aSize;

                ProductObjectList.Add(aProductSelection);
                aProductSelection.RemoveControl += RemoveProduct;

                flpProductSelection.Controls.Add(aProductSelection);
                flpProductSelection.Show();
                flpProductSelection.ClientSize = new Size(flpProductSelection.Width, flpProductSelection.Height + aProductSelection.Height);
            }
        }

        private void ChangeCustomer(string tCustomerName)
        {
            if(!string.IsNullOrEmpty(tCustomerName))
            {
                cbCustomer.Text = tCustomerName;
                
                if(cbCustomer.Items.Contains(tCustomerName) == false)
                {
                    cbCustomer.Items.Add(tCustomerName);
                }
            }
        }

        private void CustomerInputDone(Control tCustomerControl)
        {
            btnAddCustomer.Enabled = true;
            btnAddProduct.Enabled = true;
            cbCustomer.Enabled = true;

            RemoveProduct(tCustomerControl);

            var aCustomer = ObjectManager.GetCustomer();

            lbCompany.Text = aCustomer.CompanyName;
            lbFirstAndLastname.Text = $"{aCustomer.FirstName} {aCustomer.LastName}";
            lbStreetAndHousenumber.Text = $"{aCustomer.Street} {aCustomer.HouseNumber}";
            lbPostalcodeAndCity.Text = $"{aCustomer.PostalCode} {aCustomer.City}";
            gpCustomer.Visible = true;
        }

        private void RemoveProduct(Control tControl)
        {
            if (tControl != null)
            {
                Size size = new Size(flpProductSelection.Width, flpProductSelection.Height);
                size.Height -= tControl.Height;
                flpProductSelection.Size = size;

                flpProductSelection.Controls.Remove(tControl);

                if(flpProductSelection.Controls.Count <= 0)
                {
                    grpProductTable.Visible = false;
                    btnCreate.Visible = false;
                    btnAddCustomer.Enabled = true;
                    cbCustomer.Enabled = true;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OrderObject aOrder = new OrderObject();
            List<ProductObject> aProductList = new List<ProductObject>();
            double? aTotelPrice = 0;

            foreach(var aProduct in ProductObjectList)
            {
                var aObject = aProduct.GetProduct();
                
                if(aObject.Count > 0)
                    aProductList.Add(aObject);
                
                aTotelPrice += aObject.SubTotal;
            }

            if(aTotelPrice != null)
            {
                aOrder.Products = aProductList;
                aOrder.Price = (double)aTotelPrice;
                aOrder.Id = $"{MonthID}-{DateTime.Now.Month.ToString("00")}-{DateTime.Now.Year}";
                ObjectManager.CreateFile(aOrder);
            }
            
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aName = cbCustomer.Text;

            if(!string.IsNullOrEmpty(aName))
                ObjectManager.CustomerCbChanged(aName);

            CustomerObject? aObject = ObjectManager.GetCustomerObject();

            if(aObject != null)
            {
                gpCustomer.Visible = true; 
                lbCompany.Text = aObject.CompanyName;
                lbFirstAndLastname.Text = $"{aObject.FirstName} {aObject.LastName}";
                lbPostalcodeAndCity.Text =$"{aObject.PostalCode} {aObject.City}";
                lbStreetAndHousenumber.Text = $"{aObject.Street} {aObject.HouseNumber}";
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var aCustomer = new CustomerForm();
            
            flpProductSelection.Size = new Size(aCustomer.Width, aCustomer.Height);

            flpProductSelection.Controls.Add(aCustomer);
            flpProductSelection.Show();
            btnAddCustomer.Enabled = false;
            btnAddProduct.Enabled = false;
            cbCustomer.Enabled = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
            btnCreate.Enabled = false;
            btnAddCustomer.Enabled = false;
            cbCustomer.Enabled = false;

            var aSetting = new SettingForm(ProductList);

            flpProductSelection.Controls.Add(aSetting);
            flpProductSelection.Show();
            // Add settings to panel
        }
    }
}
