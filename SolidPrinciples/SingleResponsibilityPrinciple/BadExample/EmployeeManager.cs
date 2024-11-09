namespace SolidPrinciples.SingleResponsibilityPrinciple.BadExample
{
    public class EmployeeManager
    {
        public void AddEmployee(string name) 
        {
            Console.WriteLine("bad example where the add empleyee and generate there report in the same class");
        }
        public void GenerateEmployeeReport()
        {
            Console.WriteLine("bad example where the add empleyee and generate there report in the same class");
        }
    }
}
