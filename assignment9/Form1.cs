using System.Globalization;

namespace assignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            string ageInput = txtbxAge.Text;
            double age = Convert.ToDouble(ageInput);
            string membershipDurationInput = txtbxMembership.Text;
            double membershipDuration = Convert.ToDouble(membershipDurationInput);
            double totalToPay;

            if (rbtnFootball.Checked == true)
            {
                totalToPay = (175);
                if (age > 40) 
                {
                    totalToPay -= 25;
                }
                if (membershipDuration > 10)
                {
                    totalToPay -= 20;
                }
            }
            else
            {
                totalToPay = (225);
                if (age > 40)
                {
                    totalToPay -= 25;
                }
                if (membershipDuration > 10)
                {
                    totalToPay -= 20;
                }
            }

            txtFee.Text = ($"€ {totalToPay:0.00}");
        }
    }
}