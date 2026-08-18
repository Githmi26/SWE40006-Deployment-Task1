using System.Globalization;

namespace FuelTripEstimator

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool distanceValid = double.TryParse(
        txtDistance.Text,
        NumberStyles.Float,
        CultureInfo.InvariantCulture,
        out double distance);

            bool consumptionValid = double.TryParse(
                txtConsumption.Text,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out double consumption);

            bool fuelPriceValid = double.TryParse(
                txtFuelPrice.Text,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out double fuelPrice);

            if (distanceValid && consumptionValid && fuelPriceValid)
            {
                if (distance <= 0 || consumption <= 0 || fuelPrice <= 0)
                {
                    lblStatus.Text = "Please enter values greater than zero.";
                    return;
                }

                int passengers = (int)numPassengers.Value;

                double fuelRequired = (distance / 100) * consumption;
                double totalCost = fuelRequired * fuelPrice;
                double costPerPerson = totalCost / passengers;

                lblFuelRequiredResult.Text = $"{fuelRequired:F2} L";
                lblTotalCostResult.Text = $"${totalCost:F2}";
                lblCostPerPersonResult.Text = $"${costPerPerson:F2}";

                lblStatus.Text = "Trip cost calculated successfully.";
            }
            else
            {
                lblStatus.Text = "Please enter valid numeric values.";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistance.Clear();
            txtConsumption.Clear();
            txtFuelPrice.Clear();

            numPassengers.Value = 1;

            lblFuelRequiredResult.Text = "-";
            lblTotalCostResult.Text = "-";
            lblCostPerPersonResult.Text = "-";

            lblStatus.Text = "";

            txtDistance.Focus();
        }
    }
}
