using System.Formats.Asn1;

namespace SolidPrinciples.DependencyInversionPrinciple.BadExample
{
    public class FileManager
    {
        private CsvWriter _csvWriter = new CsvWriter();
        public void WriteDataToCsv(string data) { _csvWriter.Write(data); }
    }
}
