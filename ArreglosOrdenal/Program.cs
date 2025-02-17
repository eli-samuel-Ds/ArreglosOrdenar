using System;

namespace ArreglosOrdenar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordenal numeros del 1 al 10\n");
            Int64[] OrdenarNumeros = new Int64[10];
            int cont = 0;

            for (int i = 0; i < OrdenarNumeros.Length; i++)
            {
                Console.Write($"{cont + 1}. Ingrese un numero: ");
                Int64 NumIngrese = Int64.Parse(Console.ReadLine());
                OrdenarNumeros[i] = NumIngrese;
                cont++;
            }

            Console.WriteLine();
            Array.Sort(OrdenarNumeros);
            Console.WriteLine("Números ordenados: " + string.Join(", ", OrdenarNumeros));
        }
    }
}
