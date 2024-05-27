using System;

namespace Vogal
{
  class Show
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma letra");
        string letra = Console.ReadLine();

        switch (letra)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
            Console.WriteLine("vogal");
            break;

            default:
            Console.WriteLine("Não é uma vogal");
            break;
        }
    }
  }
}



