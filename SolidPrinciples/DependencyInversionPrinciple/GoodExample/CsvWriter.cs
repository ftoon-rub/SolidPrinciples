namespace SolidPrinciples.DependencyInversionPrinciple.GoodExample
{
    public class CsvWriter : IWriter
    {
        public void Write(string data) { /* Writing CSV logic */ }
    }
}
