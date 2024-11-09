namespace SolidPrinciples.LiskovSubstitutionPrinciple.BadExample
{
    public class Ostrich : Bird
    {
        public override void Fly() 
        { 
            Console.WriteLine("Ostriches can't fly!"); 
        }
    }
}
