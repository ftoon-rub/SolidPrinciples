namespace SolidPrinciples.DependencyInversionPrinciple.GoodExample
{
    public class JsonWriter : IWriter
    {
        public void Write(string data)
        {
            Console.WriteLine("Writing JSON data: " + data);
        }
    }
}
