﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança ");

        int mes = 1;
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

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
            mes+=1;//incremento com valor maior de 1 se usa += 
            // mes = mes + 1

        }

        Console.WriteLine("Pressione ENTER para encerrar ");
        Console.ReadLine();
    }
}