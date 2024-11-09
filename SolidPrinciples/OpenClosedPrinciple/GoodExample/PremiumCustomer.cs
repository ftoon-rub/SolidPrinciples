namespace SolidPrinciples.OpenClosedPrinciple.GoodExample
{
    public class PremiumCustomer : Customer
    {
        public override double GetDiscount() => 0.2;
    }
}
