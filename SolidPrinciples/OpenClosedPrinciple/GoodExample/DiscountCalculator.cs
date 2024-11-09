namespace SolidPrinciples.OpenClosedPrinciple.GoodExample
{
    public class DiscountCalculator
    {
        public double CalculateDiscount(Customer customer) => customer.GetDiscount();
    }
}
