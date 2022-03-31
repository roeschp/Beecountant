using Accountant.Forms;
using Accountant.Objects;
using Newtonsoft.Json;
using static Accountant.Util.Util;

namespace Accountant
{
    public partial class MainForm : Form
    {
        private List<ufProductSelection> ProductObjectList = new List<ufProductSelection>();

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

            var aCustomerList = File.ReadAllLines(aCustomerPath);
            var aPriceList = File.ReadAllLines(aPrivePath);

            foreach(var aPrice in aPriceList)
            {
                ProductObject? aItem = JsonConvert.DeserializeObject<ProductObject>(aPrice, JsonSerializerSettings);
                
                if(aItem != null)
                    FormManager.SetProductToList(aItem);
            }

            foreach(var aCustomer in aCustomerList)
            {
                CustomerObject? aObject = JsonConvert.DeserializeObject<CustomerObject>(aCustomer, JsonSerializerSettings);

                if (aObject != null)
                    ObjectManager.SetCustomerObject(aObject);
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            //if (ObjectManager.GetCustomer() == null)
            //{
            //    var aCustomer = new CustomerForm();

            //    flpProductSelection.Controls.Add(aCustomer);
            //    flpProductSelection.Show();
            //    btnAddProduct.Enabled = false;
            //}
            //else
            //{
                var aProductSelection = new ufProductSelection();
                ProductObjectList.Add(aProductSelection);
                aProductSelection.RemoveControl += RemoveProduct;

                flpProductSelection.Controls.Add(aProductSelection);
                flpProductSelection.Show();
                flpProductSelection.ClientSize = new Size(flpProductSelection.Width, flpProductSelection.Height + aProductSelection.Height);
        }

        private void ChangeCustomer(string tCustomerName)
        {
            if(!string.IsNullOrEmpty(tCustomerName))
            {
                cbCustomer.Text = tCustomerName;
            }
        }

        private void CustomerInputDone(Control tCustomerControl)
        {
            btnAddProduct.Enabled = true;
            RemoveProduct(tCustomerControl);

            var aCustomer = ObjectManager.GetCustomer();

            lbCompany.Text = aCustomer.CompanyName;
            lbFirstAndLastname.Text = $"{aCustomer.FirstName} {aCustomer.LastName}";
            lbStreetAndHousenumber.Text = $"{aCustomer.Street} {aCustomer.HouseNumber}";
            lbPostalcodeAndCity.Text = $"{aCustomer.PostalCode} {aCustomer.City}";
            gpCustomer.Visible = true;
            btnCreate.Visible = true;
        }

        private void RemoveProduct(Control tControl)
        {
            if (tControl != null)
            {
                flpProductSelection.Controls.Remove(tControl);
                //ProductObjectList.Remove((ufProductSelection)tControl);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<ProductObject> aProductList = new List<ProductObject>();

            foreach(var aProduct in ProductObjectList)
            {
                aProductList.Add(aProduct.GetProduct());
            }

            ObjectManager.CreateFile(aProductList);
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aName = cbCustomer.Text;

            if(!string.IsNullOrEmpty(aName))
                ObjectManager.CustomerCbChanged(aName);
        }
    }
}
