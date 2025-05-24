using System;

namespace AtividadePatos
{
    public class DancingDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("sou um pato dançarino");
        }

        public void Quack()
        {
            Console.WriteLine("quack com ritmo!");
        }

        public void Dance()
        {
            Console.WriteLine("dançando...");
        }
    }
}