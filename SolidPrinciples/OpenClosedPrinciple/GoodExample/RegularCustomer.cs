namespace SolidPrinciples.OpenClosedPrinciple.GoodExample
{
    public class RegularCustomer : Customer
    {
        public override double GetDiscount() => 0.1;
    }
}
