namespace SolidPrinciples.DependencyInversionPrinciple.GoodExample
{
    public class FileManager
    {
        private readonly IWriter _writer;
        public FileManager(IWriter writer)
        {
            _writer = writer;
        }

        public void WriteDataToFile(string data) { _writer.Write(data); }
    }
}
