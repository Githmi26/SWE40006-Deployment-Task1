using System.Globalization;
using FuelMathLibrary;
using TripValidationLibrary;

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

            // First check that all entered values are valid numbers
            if (distanceValid && consumptionValid && fuelPriceValid)
            {
                int passengers = (int)numPassengers.Value;

                // Validation is now handled by TripValidationLibrary.dll
                if (!TripValidator.ArePositiveValues(
                        distance,
                        consumption,
                        fuelPrice) ||
                    !TripValidator.IsPassengerCountValid(passengers))
                {
                    lblStatus.Text = "Please enter valid positive values.";
                    return;
                }

                // Calculations are now handled by FuelMathLibrary.dll
                double fuelRequired =
                    FuelCalculator.CalculateFuelRequired(
                        distance,
                        consumption);

                double totalCost =
                    FuelCalculator.CalculateTotalCost(
                        fuelRequired,
                        fuelPrice);

                double costPerPerson =
                    FuelCalculator.CalculateCostPerPerson(
                        totalCost,
                        passengers);

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