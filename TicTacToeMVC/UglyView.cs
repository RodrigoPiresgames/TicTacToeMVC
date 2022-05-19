using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    abstract class UglyView : IView
    {
        private Controller controller;

        public UglyView(Controller controller)
        {
            this.controller = controller;
        }

        public int MainMenu()
        {
            
            return int.Parse(Console.ReadLine());
        }

        public PlayerOrder AskPlayerOrder()
        {
            Console.WriteLine("Player order");
            Console.WriteLine("------------");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByScore}. Order by score");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByName}. Order by name");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByNameReverse}. Order by name (reverse)");
            Console.WriteLine("");
            Console.Write("> ");

            return Enum.Parse<PlayerOrder>(Console.ReadLine());
        }

        public void InvalidOption()
        {
            Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        public (string, int) AskForPlayer()
        {
            string name;
            int score;

            Console.WriteLine();
            Console.WriteLine("Insert player data");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.Write("Name > ");
            name = Console.ReadLine();
            Console.Write("Score > ");
            score = int.Parse(Console.ReadLine());

            return (name, score);
        }

        public abstract int AskForView();
        
    }
}