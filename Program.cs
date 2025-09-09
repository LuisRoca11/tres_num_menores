// Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, 
// imprimir en pantalla la leyenda "Todos los números son menores a diez".

using System;

namespace tres_num_menores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero 3: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1<10 && num2<10 && num3<10)
            {
                Console.WriteLine("Todos los números son menores a diez");
            }
            Console.ReadKey();
        }
    }
}