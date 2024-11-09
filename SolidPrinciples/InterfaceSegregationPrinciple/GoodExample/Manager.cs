namespace SolidPrinciples.InterfaceSegregationPrinciple.GoodExample
{
    public class Manager : IWorkable, IFeedable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
