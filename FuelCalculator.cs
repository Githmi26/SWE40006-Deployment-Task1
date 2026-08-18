namespace FuelMathLibrary
{
    public static class FuelCalculator
    {
        public static double CalculateFuelRequired(
           double distance,
           double consumption)
        {
            return (distance / 100) * consumption;
        }

        public static double CalculateTotalCost(
            double fuelRequired,
            double fuelPrice)
        {
            return fuelRequired * fuelPrice;
        }

        public static double CalculateCostPerPerson(
            double totalCost,
            int passengers)
        {
            return totalCost / passengers;
        }

    }
}
