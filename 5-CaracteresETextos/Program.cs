using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 05 - Caracteres e Textos");

        char letra = 'a';
       

        letra = (char)77;
        Console.Write(letra);

        letra = (char)97;
        Console.Write(letra);

        letra = (char)114;
        Console.Write(letra);

        letra = (char)105;
        Console.Write(letra);

        letra = (char)115;
        Console.Write(letra);

        letra = (char)115;
        Console.Write(letra);

        letra = (char)97;
        Console.Write(letra);


        letra = (char)77;
        Console.WriteLine(letra);

        letra = (char)97;
        Console.WriteLine(letra);

        letra = (char)114;
        Console.WriteLine(letra);

        letra = (char)105;
        Console.WriteLine(letra);

        letra = (char)115;
        Console.WriteLine(letra);

        letra = (char)115;
        Console.WriteLine(letra);

        letra = (char)97;
        Console.WriteLine(letra);

        string primeiraFrase = "SENAI - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.Write (vazia);

        letra = ' ';

        string cursos = @" Cursos Disponiveis:

 - C 
 - C++ 
 - HTML 
 - Csharp";

        Console.WriteLine(cursos);


        Console.WriteLine("Pressione ENTER para encerrar ");
        Console.ReadLine();
    }
}
