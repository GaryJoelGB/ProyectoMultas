using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultasVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PropiedadesMultas MultaAmet = new PropiedadesMultas();

            MultaAmet.AvisoMulta();
            Console.WriteLine("***************************************");

            MultaAmet.AvisoMulta("Amet", "Necesita usted pagar 500$", "05/16/2022");
            MultaAmet.MostrarAviso();

            Console.WriteLine();

            Console.WriteLine("Multa de:{0:dd/MM/yyy}", DateTime.Now);





            Console.ReadKey();

        }
    }
}
