using System;

namespace ConsoleApp1
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
            Array.Sort(NUMEROS);
            Array.Reverse(NUMEROS);
            foreach (int NUMERO in NUMEROS) 
            {
                Console.Write(NUMERO + "/");
            
            
            }


            Console.ReadLine();








        }
    }
}
