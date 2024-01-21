using Ejercicio01.String.Programacion.Servicios;


class Program
{

    public static void Main(string[] args)
    {
        OperativaInterfaz op = new OperativaImplementacion();
        ValidadoresInterfaz val = new ValidadoresImplementacion();

        string nombreCliente;
        string primerApellidoCliente;
        string segundoApellidoCliente;

        do
        {

            // Solicitar un nombre

             nombreCliente = op.solicitarNombre();

            // Solicitar un Primer Apellido

            primerApellidoCliente = op.solicitarPrimerApellido();

            // Solicitar un Segundo Apellido

            segundoApellidoCliente = op.solicitarSegundoApellido();
        }


        // Validador de comparativa de string del nombre del cliente con alguno de los apellidos
        while (val.validadorNombre( nombreCliente, primerApellidoCliente, segundoApellidoCliente));

        long numeroDNI;
        string letraDNI;
    

        do
        {
            // Solicitar el Numero del DNI
            numeroDNI = op.solicitarNumeroDNI();


            // Solicitar Letra del DNI
            letraDNI = op.solicitarLetraDNI();

        

        }


        // Validador de la Letra Coincidente con el Numero

        while (val.validadorDNI(numeroDNI, letraDNI));


        // Solicitar el Codigo Postal al Cliente

       string codigoPostal = op.solicitarCodigoPostal();

        // Validar si es de sevilla el cliente Mediante el Codigo Postal

        val.validadorProvincia(codigoPostal);

        // Concatenacion de Nombres es una sola variable

        string nombreCompletoCliente = primerApellidoCliente + " " + segundoApellidoCliente + "," + nombreCliente;

        // Separacion de los elementos mediante el caracter ","

        
        string[] apellidosCliente = nombreCompletoCliente.Split(',');

        foreach (string trozo in apellidosCliente)
        {
            Console.WriteLine(trozo); //Auxiliar para el programador "Eliminar"

        }

        // Calculo del tamaño de la variable contentiente de los apellidos del cliente

       Console.WriteLine( nombreCompletoCliente.Length);

        // Muestra del decimo caracter de la variable con los apellidos del cliente
     
        Console.WriteLine(apellidosCliente[10]);


        // Primera posicion del caracter "a"
        nombreCompletoCliente.IndexOf("a");


        // Primera posicion del caracter "r" apartir de la posicion 3 hasta la 10



        // Separacion de elementos mediante espacios

        string nombreEspaciadoCliente = nombreCliente.PadRight(nombreCliente.Length + 1);


        // Posicion de los caracteres en su conjunto "arc" en la variable del nombre completo del cliente

        nombreCliente.IndexOf("arc");
 


        // ---------------------------------------------




    }



}