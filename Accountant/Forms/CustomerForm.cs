using Accountant.Objects;

namespace Accountant.Forms
{
    public partial class CustomerForm : UserControl
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompany.Text))
            {
                lbCompany.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                lbFirstName.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                lbLastName.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(txtStreet.Text))
            {
                lbStreet.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(txtHouseNumber.Text))
            {
                lbHouseNumber.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                lbPostelCode.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(txtCity.Text))
            {
                lbStreet.ForeColor = Color.Red;
                return;
            }

            var aNewCustomerObject = new CustomerObject();

            if (rdB2B.Checked)
                aNewCustomerObject.Relation = Util.Util.BusinessRelation.B2B;
            else
                aNewCustomerObject.Relation = Util.Util.BusinessRelation.B2C;

            aNewCustomerObject.CompanyName = txtCompany.Text;
            aNewCustomerObject.FirstName = txtFirstName.Text;
            aNewCustomerObject.LastName = txtLastName.Text;
            aNewCustomerObject.Street = txtStreet.Text;
            aNewCustomerObject.HouseNumber = txtHouseNumber.Text;
            aNewCustomerObject.PostalCode = txtPostalCode.Text;
            aNewCustomerObject.City = txtCity.Text;

            // Add new customer to JSON file and 

            ObjectManager.SetCustomerObject(aNewCustomerObject);
            FormManager.CustomerInputClosed(this);
        }

        

        private void txtCompany_Enter(object sender, EventArgs e)
        {
            lbCompany.ForeColor = Color.Black;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            lbFirstName.ForeColor = Color.Black;
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            lbLastName.ForeColor = Color.Black;
        }

        private void txtStreet_Enter(object sender, EventArgs e)
        {
            lbStreet.ForeColor = Color.Black;
        }

        private void txtHouseNumber_Enter(object sender, EventArgs e)
        {
            lbHouseNumber.ForeColor = Color.Black;
        }

        private void txtPostalCode_Enter(object sender, EventArgs e)
        {
            lbPostelCode.ForeColor = Color.Black;
        }

        private void txtCity_Enter(object sender, EventArgs e)
        {
            lbCity.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormManager.CustomerInputClosed(this);
        }
    }
}
