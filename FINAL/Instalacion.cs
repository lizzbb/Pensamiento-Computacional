namespace FINAL;

public class Instalacion
{
    //Propiedades del objeto de instalacion
    private string ubicacion { get; set; }
    public bool disponibilidad = false;
    public Instalacion[] instalaciones { get; set; }

    //Asignación de propiedades
    public void GetUbicacion(string ubi)
    {
        ubicacion = ubi;
    }

    //Ingreso de los datos de la instalación
    public void GetInstalaciones(Instalacion[] ins, int S)
    {
        for(int i = 0; i < ins.Length; i++)
        {
            Console.WriteLine($"Ingrese la ubicación de la instalacion no. {i+1}");
            string ubicacionIns = Console.ReadLine();

            ins[i] = new Instalacion(ubicacion);

            Console.WriteLine("Disponibilidad: \n1. Disponible \n2. No disponible");
            string disp = Console.ReadLine();

            if(disp == "1")
            {
                ins[i].disponibilidad = true;
            }
        }

        instalaciones = ins;
    }

    public Instalacion[] SetInstalaciones()
    {
        return instalaciones;
    }

    //Lista de instalaciones disponibles
    public void ListaInstalaciones()
    {
        SetInstalaciones();
        for(int i = 0; i < instalaciones.Length; i++)
        {
            if(instalaciones[i].disponibilidad == true)
            {
            Console.WriteLine($"{i+1}. {instalaciones[i].ubicacion}");
            }
        }
    }

    //Constructor para utilizar metodos y funciones
    public Instalacion()
    {

    }

    //Constructor para la creacion de objetos de instalación
    public Instalacion(string ubicacion)
    {
        GetUbicacion(ubicacion);
    }
}
