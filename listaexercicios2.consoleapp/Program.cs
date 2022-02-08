using System;

namespace listaexercicios2.consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NUMEROS = new int[3];
            
            
            
            Console.WriteLine("Digite o Primeiro numero");
            NUMEROS[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero");
            NUMEROS[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Terceiro numero");
            NUMEROS[2] = int.Parse(Console.ReadLine());

            if (NUMEROS[0] + NUMEROS[1] < NUMEROS[2])

                Console.WriteLine("A soma dos dois primeiros numeros é menor que o terceiro!!");

            else Console.WriteLine("A soma dos dois primeiros numeros é maior ou igual que o terceiro!!");
            Console.ReadLine();
            

                
























        }
    }
}
