using System;

namespace AtividadePatos
{
    public class RocketDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("sou um pato foguete");
        }

        public void Fly()
        {
            Console.WriteLine("voando com foguetes!");
        }

        public void Quack()
        {
            Console.WriteLine("quack supersônico!");
        }
    }
}