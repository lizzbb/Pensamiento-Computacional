namespace FINAL;

public class Leccion
{
    //Propiedades del objeto de leccion
    private string tipo { get; set; }
    private string dia;
    private string horario { get; set; }
    private string instructor { get; set; }
    public Leccion[] lecciones { get; set; }

    //Asignación de propiedades
    public void GetTipo(string tipo)
    {
        this.tipo = tipo;
    }

    public void GetDia(string dia)
    {
        this.dia = dia;
    }

    public void GetHorario(string horario)
    {
        this.horario = horario;
    }

    public void GetInstructor(string instructor)
    {
        this.instructor = instructor;
    }

    //Ingreso de los datos de la leccion
    public void GetLeccion(Leccion[] lec)
    {
        for(int i = 0; i < lec.Length; i++)
        {
            Console.WriteLine($"Ingrese el tipo de la leccion no. {i+1}: ");
            string tipoLeccion = Console.ReadLine();

            Console.WriteLine($"Ingrese el dia de la leccion no. {i+1}: \n1. Lunes \n2. Martes \n3. Miercoles \n4. Jueves \n5. Viernes \n6. Sabado \n7. Domingo");
            string diaLeccion = Console.ReadLine();

            Console.WriteLine($"Ingrese el horario de la leccion no. {i+1} (formato 00:00-23:59): ");
            string horarioLeccion = Console.ReadLine();

            Console.WriteLine($"Ingrese el nombre del instructor de la leccion no. {i+1}: ");
            string instructorLeccion = Console.ReadLine();

            lec[i] = new Leccion(tipoLeccion, diaLeccion, horarioLeccion, instructorLeccion);
            lecciones = lec;

        }
    }

    public Leccion[] SetLecciones()
    {
        return lecciones;
    }

    //Catalogo de lecciones que se creen
    public void Catalogo()
    {
        SetLecciones(); 
        for(int i = 0; i < lecciones.Length; i++)
        {
            Console.WriteLine($"Leccion No. {i+1}: ");
            Console.WriteLine($"    Tipo: {lecciones[i].tipo}");
            Console.WriteLine($"    Día: {lecciones[i].dia}");
            Console.WriteLine($"    Horario: {lecciones[i].horario}");
            Console.WriteLine($"    Instructor: {lecciones[i].instructor}");
            Console.WriteLine();
        }
    }

    //Constructor para utilizar metodos y funciones
    public Leccion()
    {

    }

    //Constructor para la creacion de objetos de leccion
    public Leccion(string tipo, string dia, string horario, string instructor)
    {
        GetTipo(tipo);
        GetDia(dia);
        GetHorario(horario);
        GetInstructor(instructor);

    }

}
