using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.Write("(divisao) digite um numerador: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("agora digite o denominador: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z;
            if ( y == 0)
            {
                Console.WriteLine("nao e possivel dividir por 0 ");
            }
            else 
            {
                 z = x / y;
                Console.WriteLine($"{x} dividido por {y} é {z}");
            }
        }
    }
}
