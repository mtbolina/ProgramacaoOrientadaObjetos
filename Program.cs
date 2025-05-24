using System;
using System.Collections.Generic;

namespace AtividadePatos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new RedHeadDuck(),
                new MallardDuck(),
                new RubberDuck(),
                new RocketDuck(),
                new MuteDuck(),
                new DancingDuck()
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha um pato:");
                for (int i = 0; i < ducks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {ducks[i].GetType().Name}");
                }
                Console.WriteLine("0. Sair");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > ducks.Count)
                {
                    Console.WriteLine("Escolha inválida.");
                    continue;
                }

                if (choice == 0) break;

                Duck selectedDuck = ducks[choice - 1];
                Console.Clear();
                selectedDuck.Display();
                selectedDuck.Swim();

                if (selectedDuck is IFlyable flyable)
                {
                    Console.WriteLine("Deseja voar? (s/n)");
                    if (Console.ReadLine().ToLower() == "s") flyable.Fly();
                }

                if (selectedDuck is IQuackable quackable)
                {
                    Console.WriteLine("Deseja grasnar? (s/n)");
                    if (Console.ReadLine().ToLower() == "s") quackable.Quack();
                }

                if (selectedDuck is DancingDuck dancingDuck)
                {
                    Console.WriteLine("Deseja dançar? (s/n)");
                    if (Console.ReadLine().ToLower() == "s") dancingDuck.Dance();
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}