using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade1");

        double  n1, n2, n3, n4,media;
        

        Console.Write("Digite a nota 1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = double.Parse(Console.ReadLine());

        media = (n1 + n2 + n3 + n4) / 4;

        Console.WriteLine(media);
       

        if (media >= 6)
        {
            Console.WriteLine("Você foi aprovado");
        }
        else if (media <= 4)
        {
            Console.WriteLine("Você foi reprovado");
        }
        else 
        {
            Console.WriteLine("Você ficou de recuperação");
        }


        Console.WriteLine("Pressione ENTER para encerrar ");
        Console.ReadLine();
    }
}