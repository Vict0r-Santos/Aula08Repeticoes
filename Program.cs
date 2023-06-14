using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Loop
{
    class Program
    {

        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();

            nomes.Add("Stella");
            nomes.Add("Willian");
            nomes.Add("Luis");
            nomes.Add("Amiltom");
            nomes.Add("Victor");
            nomes.Add("Mccree");

            int contador = 0;

            while (contador < nomes.Count)
            {
                Console.WriteLine(" O nome é " + nomes[contador]);
                contador++;
            }

            Console.ReadKey();

        }

        void repeticao()
        {
            //Repetições (loop)

            int contador = 0;

            while (contador < 5)
            {

                Console.WriteLine($"OH MAH GOD!");

                // Para acumular valores em uma variavel
                contador = contador + 1;

                // contador += 1; acrescenta valor a uma variavel existente
                // contador++ --> acrescenta 1
                // contador -= 1
                // contador /= 1
                // contador *= 1
            }
        }
    }
}
