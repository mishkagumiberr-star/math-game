using System;
namespace Game;
class GameLogic
{
    Random random = new Random();
    public float number1;
    public float number2;
    public float number3;
    public void Plus()
    {
        number1 = random.Next(1, 101);
        number2 = random.Next(1, 101);
        number3 = number1 + number2;
        Console.Write($"{number1} + {number2} = ");
    }
    public void Minus()
    {
        number1 = random.Next(1, 101);
        number2 = random.Next(1, 101);
        number3 = number1 - number2;
        Console.Write($"{number1} - {number2} = ");
    }
    public void Multi()
    {
        number1 = random.Next(1, 51);
        number2 = random.Next(1, 51);
        number3 = number1 * number2;
        Console.Write($"{number1} * {number2} = ");
    }    
    public void Divis()
    {
       number1 = random.Next(1, 51);
       number2 = random.Next(1, 51);
       number3 = number1 / number2;
       Console.Write($"{number1} / {number2} = ");
    }
}