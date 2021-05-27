using System;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero: ");
            double numeroA = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Valor absoluto del numero ingresado: " + Math.Abs(numeroA));
            Console.WriteLine("Potencia al cuadrado del numero ingresado: " + Math.Pow(numeroA, 2));
            Console.WriteLine("Raiz cuadrada del numero ingresado: " + Math.Sqrt(numeroA));
            Console.WriteLine("Seno del numero ingresado: " + Math.Sin(numeroA * Math.PI / 180));
            Console.WriteLine("Coseno del numero ingresado: " + Math.Cos(numeroA * Math.PI / 180));
            //Console.WriteLine("Parte entera del numero ingresado: " + Math.Truncate(18.78));

            Console.WriteLine("Ahora va a ingresar 2 numeros, ingrese el primer numero: ");
            int numeroB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            int numeroC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero MAXIMO entre los dos numeros ingresados: " + Math.Max(numeroB, numeroC));
            Console.WriteLine("Numero MINIMO entre los dos numeros ingresados: " + Math.Min(numeroB, numeroC));
        }
    }
}
