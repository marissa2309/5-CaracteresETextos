using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança ");

        
        double investimento = 1000;
        // rendimento de 0,5% (0,005) ao mês

        //mês 1
        //investimento = investimento + investimento * 0.005;
        // Console.WriteLine(investimento);

        // mês 2
        // investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        // mês 3
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        for(int mes = 1;mes <=12;mes++)
        {
           // investimento = investimento + investimento * 0.005;
            investimento *= 1.005;
            Console.WriteLine("No mes " + mes + " você tem R$ " + investimento );
        }
        Console.WriteLine("Pressione ENTER para encerrar ");
        Console.ReadLine();
    }
}
