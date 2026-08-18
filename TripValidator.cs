namespace TripValidationLibrary
{
    public static class TripValidator
    {
        public static bool ArePositiveValues(
            double distance,
            double consumption,
            double fuelPrice)
        {
            return distance > 0 &&
                   consumption > 0 &&
                   fuelPrice > 0;
        }

        public static bool IsPassengerCountValid(int passengers)
        {
            return passengers > 0;
        }
    }
}