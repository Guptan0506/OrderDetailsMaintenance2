using OrderDetailsMaintenance.Models.DataLayer;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        private NorthwindContext _context = new NorthwindContext();
        
        //Navya Gupta
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        //Navya Gupta

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = _context.Customers.Find(id);

            if (customer == null)
            {
                MessageBox.Show($"Not found");
                return;
            }

            customer.ContactName = txtContact.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtAddress.Text;
            customer.Country = txtCountry.Text;

            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        //Navya Gupta

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Navya Gupta

        private void btnFind_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = _context.Customers.Find(id);

            if (customer == null)
            {
                MessageBox.Show($"Not found");
                return;
            }

            txtCustomerId.Text = customer.CustomerId;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
        }
    }
}