using System;

using UIKit;
namespace MPG_Calculator
{
    public class MPG_Calculator
    {
        public MPG_Calculator()
        {
        }

        private static decimal miles, gallons;

        public static decimal MPG(string mile, string gal)
        {
            //if input is valid, but gallons is 0, return the miles
            //need this because can't divide by 0
            if (validator(mile, gal) && gallons == 0) 
                return miles;

            //validate input and return either exception or MPG
            return validator(mile, gal) ? miles / gallons : throw new ArgumentException("Invalid Input");
        }

        //validate that what was entered are numbers and that miles & gallons is
        //greater than 0 (no negatives)
        private static bool validator(string mile, string gal) =>
        (Decimal.TryParse(mile, out miles) && Decimal.TryParse(gal, out gallons)
         && gallons >= 0 && miles >= 0);
    }
}
