using System;

namespace Tarea04_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random alea = new Random();
            int num1 = 0;
            int num2 = 0;
            int repeticiones = 100;

            for (int i= 0; i < repeticiones; i++)
            {
                num1 = alea.Next(0,100);
                num2 = alea.Next(0,100);
                Console.WriteLine("Números aleatorios: número 1 = {0}, número 2 = {1}", num1, num2);
                if (num1 > num2)
                {
                    Console.WriteLine("{0} es mayor que {1}", num1, num2);
                }else if (num1 == num2)
                {
                    Console.WriteLine("Ambos número son iguales.");
                }
                else
                {
                    Console.WriteLine("{0} es mayor que {1}", num2, num1);
                }
            }
        }
    }
}
