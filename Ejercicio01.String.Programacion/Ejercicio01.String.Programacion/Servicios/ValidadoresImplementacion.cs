using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.String.Programacion.Servicios
{
    internal class ValidadoresImplementacion : ValidadoresInterfaz
    {

        public bool validadorNombre(string nombreCliente, string primerApellidoCliente, string segundoApellidoCliente)
        {
            bool validadorOperacional = false;

            if (nombreCliente.Equals(primerApellidoCliente) & nombreCliente.Equals(segundoApellidoCliente))
            {
                Console.WriteLine("El nombre no puede ser coincidente con el apellido"); // No debe de aparecer "Eliminar"

                 validadorOperacional = true;


            }


            return validadorOperacional;

        }


        public bool validadorDNI(long numeroDNI, string letraDniCliene)
        {
            bool dniValidador = false;

            long restoDni = numeroDNI % 23;


            switch (restoDni)
            {
                case 0:
                    dniValidador = letraDniCliene.Equals("T");
                   

                    break;

                case 1:
                    dniValidador = letraDniCliene.Equals("R");
                    break;

                case 2:
                    dniValidador = letraDniCliene.Equals("W");
                    break;

                case 3:
                    dniValidador = letraDniCliene.Equals("A");
                    break;

                case 4:
                    dniValidador = letraDniCliene.Equals("G");
                    break;

                case 5:
                    dniValidador = letraDniCliene.Equals("M");
                    break;

                case 6:
                    dniValidador = letraDniCliene.Equals("Y");

                    break;

                case 7:
                    dniValidador = letraDniCliene.Equals("F");
                    break;

                case 8:
                    dniValidador = letraDniCliene.Equals("P");
                    break;

                case 9:
                    dniValidador = letraDniCliene.Equals("D");
                    break;

                case 10:
                    dniValidador = letraDniCliene.Equals("X");
                    break;

                case 11:
                    dniValidador = letraDniCliene.Equals("B");
                    break;

                case 12:
                    dniValidador = letraDniCliene.Equals("N");
                    break;

                case 13:
                    dniValidador = letraDniCliene.Equals("J");
                    break;

                case 14:
                    dniValidador = letraDniCliene.Equals("Z");
                    break;

                case 15:
                    dniValidador = letraDniCliene.Equals("S");
                    break;

                case 16:
                    dniValidador = letraDniCliene.Equals("Q");
                    break;

                case 17:
                    dniValidador = letraDniCliene.Equals("V");
                    break;

                case 18:
                    dniValidador = letraDniCliene.Equals("H");
                    break;

                case 19:
                    dniValidador = letraDniCliene.Equals("L");
                    break;

                case 20:
                    dniValidador = letraDniCliene.Equals("C");
                    break;

                case 21:
                    dniValidador = letraDniCliene.Equals("K");
                    break;

                case 22:
                    dniValidador = letraDniCliene.Equals("E");
                    break;

                default:
                    Console.WriteLine("La letra del DNI, no es coincidente con el Numero de DNI");
                    break;



            }


            if (dniValidador == true)
            {
                dniValidador = false;

            }

            else
            {
                dniValidador = true;
            }
            return dniValidador;




        }



        public void validadorProvincia(string codigoPostal)
        {
            string postalAuxiliar = "410";
            

            if (codigoPostal.ElementAt(0) == postalAuxiliar.ElementAt(0) & codigoPostal.ElementAt(1) == postalAuxiliar.ElementAt(1) & codigoPostal.ElementAt(2) == postalAuxiliar.ElementAt(2))
            {
                        Console.WriteLine("El cliente es de Sevilla"); // Validador de Programacion "Eliminar"

            }

            else
            {
                Console.WriteLine("El cliente no es de Sevilla");
            }




        }



    }
}
