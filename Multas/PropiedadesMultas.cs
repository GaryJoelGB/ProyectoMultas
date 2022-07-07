using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultasVarios
{
    class PropiedadesMultas : IMultasInf
    {

        public void AvisoMulta()
        {
            Remitente = "Amet";

              Mensaje = "Por exceso de velocidad, ha obtenido una multa de 500$ peso dominicano, por favor dirigirse a un establecimiento del AMET mas cercanos.";
            Console.WriteLine(Mensaje);

            Fechas = "";
        }

        public void AvisoMulta(string Remitente, String Mensaje, String Fechas)
        {

            this.Remitente = Remitente;
            this.Mensaje = Mensaje;
            this.Fechas = Fechas;  

        }

         public void MostrarAviso()
        {
            Console.WriteLine("El departamento de {0} le ha colocado {1} en la fecha actual {2}, por favor de pagar a tiempo", Remitente, Mensaje, Fechas);


        }

        public string GetFecha()
        {

            return "05/16/2022";

        }




        private string Remitente;

        private string Mensaje;

        private string Fechas;


    }
}
