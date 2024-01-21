using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.String.Programacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public string solicitarNombre()
        {
            Console.WriteLine("Introduzca su Nombre: ");
            string nombreCliente = Console.ReadLine();
            return nombreCliente;

        }
         public string solicitarPrimerApellido()
        {
            Console.WriteLine("Introduzca su Primer Apellido: ");
            string primerApellidoCliente = Console.ReadLine();
            return primerApellidoCliente;

        }
         public string solicitarSegundoApellido()
        {
            Console.WriteLine("Introduzca su Segundo Apellido: ");
            string segundoApellidoCliente = Console.ReadLine();
            return segundoApellidoCliente;

        }


        public long solicitarNumeroDNI()
        {

            Console.WriteLine("Introduzca el Numero de su DNI");
            long numeroDNI = Convert.ToInt64(Console.ReadLine());
            return numeroDNI;


        }
        public string solicitarLetraDNI()
        {
            Console.WriteLine("Introduzca la Letra de su DNI");
            string letraDNI = Console.ReadLine();
            return letraDNI;

        }

        public string solicitarCodigoPostal()
        {

            Console.WriteLine("Introduzca su codigo Postal");
            string CodigoPostal = Console.ReadLine();

            return CodigoPostal;
        }



    }
}
