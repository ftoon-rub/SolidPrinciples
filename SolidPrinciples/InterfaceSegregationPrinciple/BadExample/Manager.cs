﻿namespace SolidPrinciples.InterfaceSegregationPrinciple.BadExample
{
    public class Manager : IWorker
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
