using System;

namespace AtividadePatos
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("pato de cabeça vermelha");
        }

        public void Fly()
        {
            Console.WriteLine("voar...");
        }

        public void Quack()
        {
            Console.WriteLine("quaaaa!!!!...");
        }
    }
}