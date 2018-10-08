using System;


namespace ConversionLibrary
{
    public class ConversionMethods
    {
        public double toOunces(double grams)
        {
            const double conversion = 28.34952;
            return grams / conversion;
        }

        public double toGrams(double ounces)
        {
            const double conversion = 28.34952;
            return ounces * conversion;
        }
    }
}
