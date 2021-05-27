using System;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a, b, resultado;
            do
            {
                Console.WriteLine("Ingrese el numero de la opracion que desea realizar(Suma-1,Resta-2,Multiplicacion-3,Division-4): ");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num < 1 || num > 4);

            Console.WriteLine("Ingrese el primer numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    resultado = a + b;
                    Console.WriteLine("Resultado de la suma: " + resultado);
                    break;

                case 2:
                    resultado = a - b;
                    Console.WriteLine("Resultado de la resta: " + resultado);
                    break;

                case 3:
                    resultado = a * b;
                    Console.WriteLine("Resultado de la multiplicacion: " + resultado);
                    break;

                case 4:
                    if (b > 0)
                    {
                        resultado = a / b;
                        Console.WriteLine("Resultado de la division: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir en 0.");
                    }
                    break;
            }


        }
    }
}
