namespace SolidPrinciples.OpenClosedPrinciple.BadExample
{
    public class DiscountCalculator
    {
        public double CalculateDiscount(string customerType)
        {
            if (customerType == "Regular") return 0.1;
            if (customerType == "Premium") return 0.2;
            return 0;
        }
    }
}
