using System;

namespace AtividadePatos
{
    public abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("nadando...");
        }

        public abstract void Display();
    }
}