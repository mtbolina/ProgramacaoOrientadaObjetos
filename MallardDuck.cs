using System;

namespace AtividadePatos
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("sou um pato selvagem");
        }

        public void Fly()
        {
            Console.WriteLine("voando como um pato selvagem...");
        }

        public void Quack()
        {
            Console.WriteLine("quack! quack!");
        }
    }
}