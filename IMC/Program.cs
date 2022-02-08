using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] NUMEROS = new double[2];

            Console.WriteLine("Digite seu peso!");
            NUMEROS[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura!");
            NUMEROS[1] = double.Parse(Console.ReadLine());
            double altura = NUMEROS[1] * NUMEROS[1];
            double IMC = NUMEROS[0] / altura;

            if (IMC < 18.5
                )

                Console.WriteLine("Você esta abaixo do peso!!!");


            if (IMC <= 25 && IMC >= 18.5
                )

                Console.WriteLine("Parabens você esta no peso certo!!");

            if (IMC > 25 && IMC < 30)
            

                Console.WriteLine("Você esta um pouco acima do peso!!");
            
            if (IMC > 30
                ) 

            Console.WriteLine("Você é obeso!!");






            Console.ReadLine();









        }
    }
}
