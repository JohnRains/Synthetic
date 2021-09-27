using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<__Person> testData = GenerateSynthetic.FakeData.Generate(1).ToList();
            txtId.Text = testData[0].Id.ToString();
            txtRid.Text = testData[0].RandomId.ToString();
            txtGender.Text = testData[0].Gender;
            txtTitle.Text = testData[0].Title;
            txtFname.Text = testData[0].FirstName;
            txtMname.Text = testData[0].MiddleName;
            txtLname.Text = testData[0].LastName;
            txtStreet.Text = testData[0].StreetAddress;
            txtCity.Text = testData[0].City;
            txtState.Text = testData[0].State;
            txtZip.Text = testData[0].ZipCode;
            txtPhone.Text = testData[0].Phone;
            txtEmail.Text = testData[0].Email;
            txtSsn.Text = testData[0].SSN;
            txtDob.Text = testData[0].DOB.ToString();

            //var address = __Person.StreetAddress;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
