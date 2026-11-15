using System;
namespace Game;
class Program
{
    static void Main()
    {
        Random random = new Random();
        GameLogic amam1 = new GameLogic();
        while (true)
        {
            int random1 = random.Next(1, 5);
            if (random1 == 1)
            {
                amam1.Plus();
            }
            else if (random1 == 2)
            {
                amam1.Minus();
            }
            else if (random1 == 3)
            {
                amam1.Multi();
            }
            else if (random1 == 4)
            {
                amam1.Divis();
            }
            if (!float.TryParse(Console.ReadLine(), out float result))
            {
                Console.Clear();
                Console.WriteLine("skip");
                continue;
            }
            if (result == amam1.number3)
            {
                Console.Clear();
                Console.WriteLine($"yes, correct answear is {amam1.number3}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"nuh uh, correct answear is {amam1.number3}");
            }
        }
    }
}
