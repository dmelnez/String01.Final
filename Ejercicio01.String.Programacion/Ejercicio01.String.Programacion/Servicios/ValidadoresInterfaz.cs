using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.String.Programacion.Servicios
{
    internal interface ValidadoresInterfaz
    {
        public bool validadorNombre(string nombreCliente, string primerApellidoCliente, string segundoApellidoCliente);


        public bool validadorDNI(long numeroDNI, string letraDniCliene);


        public void validadorProvincia(string codigoPostal);
    }
}
