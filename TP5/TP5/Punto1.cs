using System;
using System.Collections.Generic;
using System.Text;

namespace TP5
{
    class Punto1
    {
        static void Main(string[] args)
        {
            int numero, aux, inverso=0;
            Console.WriteLine("Ingrese numero a invertir: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                while (numero > 0)
                {
                    aux = numero % 10;
                    numero = numero / 10;
                    inverso = inverso * 10 + aux;
                }

                Console.WriteLine("El numero ingresado al invertirlo queda como: " + inverso);
            }
            else
            {
                Console.WriteLine("El numero ingresado es cero o menor que cero, no se invertira.");
            }
        }
    }
}
