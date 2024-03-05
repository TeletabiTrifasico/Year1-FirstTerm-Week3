using System.Globalization;

namespace assignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            const int price = 12;

            string ageInput = txtbxAge.Text;
            int age = Convert.ToInt32(ageInput);

            double finalPrice;

            if (age < 5) 
            {
                finalPrice = 0;
            }
            else if (age < 10)
            {
                finalPrice = price / 2;
            }
            else if (age < 55) 
            {
                finalPrice = price;
            }
            else 
            {
                finalPrice = 0;
            }

            txtPrice.Text = ($"€ {finalPrice.ToString("0.00")}");
        }
    }
}