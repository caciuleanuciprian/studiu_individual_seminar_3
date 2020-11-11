using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiuIndividualProblema3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarare variabile
            int n, a, b, nrEl = 0;

            //Citire n, a, b
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            //Declarare vector 1
            int[] array = new int[n];

            //Citire vector 1
            int i = 0;

            Console.WriteLine("Elementele vecotrului: ");
            while (i < n)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < a || array[i] > b)
                {
                    nrEl++;
                }

                i++;
            }

            //Declarare vector 2
            int[] array2 = new int[n];

            //Reinitializare i
            i = 0;

            //Popularea vectorului 2 + afisare elemente din vectorul 2
            Console.WriteLine("Elementele celui de-al doilea vector: ");
            while(i < n)
            {
                if (array[i] < a || array[i] > b)
                {
                    array2[i] = array[i];
                    Console.WriteLine(array2[i]);
                }

                i++;
            }

            //Afisare numar elemente din vectorul 2
            Console.WriteLine("Nr el din vectorul2");
            Console.WriteLine(nrEl);

            Console.ReadLine();




        }
    }
}
