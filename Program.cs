﻿internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("--------------------");
        Console.Write("Selecione uma opção: ");
        short opcao = short.Parse(Console.ReadLine());

        switch(opcao){
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Soma(){
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = n1 + n2;
        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao(){
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = n1 - n2;
        Console.WriteLine($"O resultado da subtração é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao(){
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine());

        if(n2 == 0){
            Console.WriteLine("\nNão é possível dividir por zero. Informe um valor válido!");

            Console.WriteLine("");
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            float resultado = n1/v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }
        else{
            Console.WriteLine("");

            float resultado = n1/n2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao(){
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = n1 * n2;
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Console.ReadKey();
        Menu();
    }

}