using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("atvidade3 - Multiplos de 3");

        for (int multiplosDe3 = 3;multiplosDe3 <= 100;multiplosDe3+=3) 
        {
            Console.WriteLine(multiplosDe3);
        }
      

        Console.WriteLine("Pressione ENTER para encerrar ");
        Console.ReadLine();
    }
}
