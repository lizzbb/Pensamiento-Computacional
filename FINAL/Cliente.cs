namespace FINAL;

public class Cliente
{
    //Propiedades del objeto de cliente
    public bool membresia = false;
    private string nombre { get; set; }
    public Cliente[] clientes { get; set; }

    //Asignación de propiedades
    public void GetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    //Ingreso de los datos del cliente
    public void GetClientes(Cliente[] cl)
    {

        for (int i = 0; i < cl.Length; i++)
        {
            Console.WriteLine($"Ingrese el nombre del cliente no. {i+1}");
            string nombre = Console.ReadLine();

            cl[i] = new Cliente(nombre);

            Console.WriteLine("¿Cuenta con membresia activa? \n1. Sí \n2. No");
            string m = Console.ReadLine();

            if (m == "1")
            {
                cl[i].membresia = true;
            }

        }
        clientes = cl;
    }
    public Cliente[] SetCliente()
    {
        return clientes;
    }

    //Lista de clientes con una membresía activa
    public void ListaClientesActivos()
    {
        SetCliente();
        for(int i = 0; i < clientes.Length; i++)
        {
            if(clientes[i].membresia == true)
            {
                Console.WriteLine($"  {i+1}." + clientes[i].nombre);
            }
        }
    }

    //Constructor para utilizar metodos y funciones
    public Cliente()
    {

    }

    //Constructor para la creacion de objetos de cliente
    public Cliente(string nombre)
    {
        GetNombre(nombre); 
    }



}
