using System;

namespace AtividadePatos
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("sou um pato de borracha");
        }

        public void Quack()
        {
            Console.WriteLine("squeak");
        }
    }
}