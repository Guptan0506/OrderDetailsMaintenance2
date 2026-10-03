using OrderDetailsMaintenance.Models.DataLayer;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        private NorthwindContext _context = new NorthwindContext();

        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = _context.Customers.Find(id);

            customer.ContactName = txtContact.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtAddress.Text;
            customer.Country = txtCountry.Text;

            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = _context.Customers.Find(id);
            txtCustomerId.Text = customer.CustomerId;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
        }
    }
}