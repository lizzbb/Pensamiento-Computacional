using FINAL; 

class Program
{
    static void Main(string[] args)
    {
        string opcionM = "";
        //creacion de objetos para utilizar metodos y funciones
        Cliente objCliente = new Cliente();
        Leccion objLeccion = new Leccion();
        Instalacion objInstalacion = new Instalacion();

        //Menú principal
        do
        {
            Console.WriteLine("Menú de Gestión de Gimnasio \n1. Ingresar datos \n2. Mostrar datos \n3. Salir");
            opcionM = Console.ReadLine();

            string opciones = "";
            int N = 0;
            int C = 0;
            int S = 0;

            switch (opcionM)
            {
                case "1":
                    Console.WriteLine("Ingreso de datos: \n1. Cliente \n2. Clase (leccion) \n3. Instalacion (sede) \n4. Regresar");
                    opciones = Console.ReadLine();

                    
                    //Menú para ingresar datos
                    switch (opciones)
                    {

                        case "1":
                        Console.WriteLine("Cantidad de clientes a ingresar:");
                        N = int.Parse(Console.ReadLine());

                        //Creación de los objetos de cliente y sus datos
                        Cliente[] clientes = new Cliente[N];
                        objCliente.GetClientes(clientes);

                            break;

                        case "2":
                        Console.WriteLine("Cantidad de clases (lecciones) a ingresar:");
                        C = int.Parse(Console.ReadLine());

                        //Creación de los objetos de lecciones y sus datos
                        Leccion[] lecciones = new Leccion[C];
                        objLeccion.GetLeccion(lecciones);
                            break;

                        case "3":
                            Console.WriteLine("Cantidad de instalaciones (sedes) a ingresar: ");
                            S = int.Parse(Console.ReadLine());

                            //Creación de los objetos de instalaciones y sus datos
                            Instalacion[] instalaciones = new Instalacion[S];
                            objInstalacion.GetInstalaciones(instalaciones, S);
                            break;

                        case "4":
                            break;
                    }

                    break;

                //Menú para mostrar datos
                case "2":
                    Console.WriteLine("Mostrar datos: \n1. Clientes con membresia activa \n2. Catalogo de clases (lecciones) \n3. Lista de instalaciones (sedes) \n4. Regresar");
                    opciones = Console.ReadLine();


                    switch (opciones)
                    {
                        case "1":
                        Console.WriteLine("Clientes con membresia activa:");
                        objCliente.ListaClientesActivos();
                            break;

                        case "2":
                        Console.WriteLine("Catalogo de clases (lecciones):");
                        objLeccion.Catalogo();
                            break;

                        case "3":
                        Console.WriteLine("Lista de instalaciones (sedes) disponibles: ");
                        objInstalacion.ListaInstalaciones();
                            break;

                        case "4":
                            break;
                    }
                    

                    break;

                    case "3":
                    Console.WriteLine("Fin del programa.");
                        break;
                    
                    default: 
                        Console.WriteLine("Opcion invalida.");
                        break;
            }
        } 
        while (opcionM != "3");

    }
}
