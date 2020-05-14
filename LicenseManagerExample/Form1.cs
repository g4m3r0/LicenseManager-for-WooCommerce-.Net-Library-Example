using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseManager;

namespace LicenseManagerExample
{
    public partial class Form1 : Form
    {
        private readonly LicenseManager.ApiHelper lcManager;
        public Form1()
        {
            InitializeComponent();

            const string host ="https://domain.com"; //Your wordpress host address
            const string consumerKey = "ck_bfab6fdddc6bcd6892b8320d3f204d6547dd9c93"; //Your licensemanager.at consumer api key
            const string consumerSecret = "cs_1dc161350edf85d795d8ee476eca54674573c947"; //Your licensemanager.at consumer api secret

            lcManager = new LicenseManager.ApiHelper(host, consumerKey, consumerSecret, false);
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            var activated = lcManager.ActivateLicense(txtLicense.Text, txtProductId.Text);
            MessageBox.Show(activated.ToString(), @"Activated?");
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var validated = lcManager.ValidateLicense(txtLicense.Text, txtProductId.Text);
            MessageBox.Show(validated.ToString(), @"Activated?");
        }
    }
}
