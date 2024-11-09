namespace SolidPrinciples.InterfaceSegregationPrinciple.BadExample
{
    public class Robot : IWorker
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
