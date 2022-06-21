using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseManager;

namespace LicenseManagerExample
{
    public partial class Form1 : Form
    {
        private readonly LicenseManagerApi _licenseManager;
        public Form1()
        {
            InitializeComponent();

            const string host ="https://domain.com"; //Your wordpress host address
            const string consumerKey = "ck_3e68d6156f48ddb61b1748ca548f632b1d19d446"; //Your licensemanager.at consumer api key
            const string consumerSecret = "cs_6a74509a3c4127bf19340ef873fd9349eca07g78"; //Your licensemanager.at consumer api secret

            _licenseManager = new(host, consumerKey, consumerSecret);
        }

        private async Task ActivateLicense()
        {
            var licenseKey = txtLicense.Text;
            var productId = txtProductId.Text;

            var (success, errorMessage) = await _licenseManager.ActivateLicenseAsync(licenseKey, productId);

            MessageBox.Show(success
                ? $"License {licenseKey} was successfully activated for product {productId}."
                : $"Something went wrong: {errorMessage}");
        }

        private async Task ValidateLicense()
        {
            var licenseKey = txtLicense.Text;
            var productId = txtProductId.Text;

            var (success, errorMessage) = await _licenseManager.ValidateLicenseAsync(licenseKey, productId);

            MessageBox.Show(success
                ? $"License {licenseKey} was successfully validated for product {productId}."
                : $"Something went wrong: {errorMessage}");
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            Task.Run(ActivateLicense);
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            Task.Run(ValidateLicense);
        }
    }
}
