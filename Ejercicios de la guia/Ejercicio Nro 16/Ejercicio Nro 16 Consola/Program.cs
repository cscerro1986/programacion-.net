using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Nro_16;


namespace Ejercicio_Nro_16_Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno nuevoAlumno = new Alumno("Cerro", 1231,"Santiago");
            Alumno nuevoAlumno2 = new Alumno("Cisneros", 1231,"Pedro");
            Alumno nuevoAlumno3 = new Alumno("Valle", 1231,"Juana");

            
            nuevoAlumno.Estudiar(1, 5);
            nuevoAlumno2.Estudiar(6, 8);
            nuevoAlumno3.Estudiar(9, 10);

            nuevoAlumno.CalcularFinal();
            nuevoAlumno2.CalcularFinal();
            nuevoAlumno3.CalcularFinal();

            Console.WriteLine(   nuevoAlumno.Mostrar());
            Console.WriteLine(  nuevoAlumno2.Mostrar());
            Console.WriteLine(  nuevoAlumno3.Mostrar());

            Console.ReadKey();

            
        }
    }
}
