using Accountant.Forms;
using Accountant.Objects;
using Newtonsoft.Json;
using static Accountant.Util.Util;

namespace Accountant
{
    public partial class MainForm : Form
    {
        private List<ufProductSelection> ProductObjectList = new List<ufProductSelection>();
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

            Util.Util.TaxesFactor = Convert.ToDouble(Properties.Settings.Default.TaxValue);

            var aPricePathB2C = Path.Combine(PathExecutable, PriceListFolder, PriceListB2C);
            var aPricePathB2B = Path.Combine(PathExecutable, PriceListFolder, PriceListB2B);
            var aCustomerPath = Path.Combine(PathExecutable, CustomerListFolder, CustomerListName);
            var aFolderInfo = new DirectoryInfo(Path.Combine(PathExecutable, "Invoices"));
            
            if(aFolderInfo.Exists)
            {
                var aFiles = aFolderInfo.GetFiles(@$"*{DateTime.Now.Month}-{DateTime.Now.Year}.pdf");
                MonthID = aFiles.Count() + 1;
            }

            ValidatePath(aPricePathB2C);
            ValidatePath(aPricePathB2B);
            ValidatePath(aCustomerPath);

            try
            {
                var aCustomerList = File.ReadAllText(aCustomerPath);
                var aPriceListB2C = File.ReadAllText(aPricePathB2C);
                var aPriceListB2B = File.ReadAllText(aPricePathB2B);

                List<ProductObject>? ProductListB2C = JsonConvert.DeserializeObject<List<ProductObject>>(aPriceListB2C, JsonSerializerSettings);
                List<ProductObject>? ProductListB2B = JsonConvert.DeserializeObject<List<ProductObject>>(aPriceListB2B, JsonSerializerSettings);

                if (ProductListB2C != null && ProductListB2B != null)
                {
                    ObjectManager.AddProductList(ProductListB2C, BusinessRelation.B2C);
                    ObjectManager.AddProductList(ProductListB2B, BusinessRelation.B2B);
                }
                else
                {
                    MessageBox.Show("Please set a valid products and pricelist to the working directory!");
                    return;
                }

                List<CustomerObject>? aObjectList = JsonConvert.DeserializeObject<List<CustomerObject>>(aCustomerList, JsonSerializerSettings);

                if (aObjectList != null)
                {
                    foreach (var aObject in aObjectList)
                    {
                        if (aObject != null)
                        {
                            ObjectManager.SetCustomerObject(aObject);

                            if (cbCustomer.Items.Contains(aObject.CompanyName) == false)
                            {
                                cbCustomer.Items.Add(aObject.CompanyName);
                            }
                        }
                    }
                    if (cbCustomer.Items.Count > 0)
                        cbCustomer.SelectedIndex = 0;
                }
            }
            catch
            {
                MessageBox.Show("Failed to read Files for customer and pricelist - please try again");
                Application.Exit();
            }

            
        }

        private void ValidatePath(string tPath)
        {
            try
            {
                if(!File.Exists(tPath))
                {
                    File.Create(tPath);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Failed to create working directory");
                Application.Exit();
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (ObjectManager.GetCustomer() == null)
            {
                btnAddCustomer_Click(sender, e);
            }
            else
            {
                grpProductTable.Visible = true;
                btnAddCustomer.Enabled = false;
                btnSettings.Enabled = false;
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
                ProductObjectList = new List<ufProductSelection>();

                if (cbCustomer.Items.Contains(tCustomerName) == false)
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
            gpCustomer.Visible = true;

            RemoveProduct(tCustomerControl);

            var aCustomer = ObjectManager.GetCustomer();

            if (aCustomer != null)
            {
                lbCompany.Text = aCustomer.CompanyName;
                lbFirstAndLastname.Text = $"{aCustomer.FirstName} {aCustomer.LastName}";
                lbStreetAndHousenumber.Text = $"{aCustomer.Street} {aCustomer.HouseNumber}";
                lbPostalcodeAndCity.Text = $"{aCustomer.PostalCode} {aCustomer.City}";
            }
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
                    btnSettings.Enabled = true;
                    cbCustomer.Enabled = true;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OrderObject aOrder = new OrderObject();
            List<ProductObject> aProductList = new List<ProductObject>();
            double? aTotelPrice = 0;

            SetInput(false);

            foreach (var aProduct in ProductObjectList)
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

            SetInput(true);
            ProductObjectList = new List<ufProductSelection>();
        }

        private void SetInput(bool tSet)
        {
            if(tSet)
            {
                btnCreate.Enabled = true;
                btnCreate.Visible = false;
                flpProductSelection.Controls.Clear();
            }
            else
            {
                btnCreate.Enabled = tSet;
            }

            btnSettings.Enabled = tSet;
            btnAddCustomer.Enabled = tSet;
            btnAddProduct.Enabled = tSet;
            cbCustomer.Enabled = tSet;
            flpProductSelection.Enabled = tSet;
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
                lbCustomerSelection.Text = aObject.Relation.ToString();

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
            btnAddProduct.Enabled = false;
            btnAddCustomer.Enabled = false;
            cbCustomer.Enabled = false;
            btnSettings.Enabled = false;

            var aSetting = new SettingForm();

            flpProductSelection.Size = new Size(aSetting.Width, aSetting.Height);
            flpProductSelection.Controls.Add(aSetting);
            flpProductSelection.Show();
        }
    }
}
