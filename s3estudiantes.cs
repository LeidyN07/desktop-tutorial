using System;

namespace RegistroEstudiante
{
    // Clase única que representa al estudiante
    class Estudiante
    {
        static void Main(string[] args)
        {
            // Datos del estudiante
            int id = 1;
            string nombres = "Leidy";
            string apellidos = "Obando";
            string direccion = "Lago Agrio, Ecuador";

            // Array para almacenar los números de teléfono
            string[] telefonos = new string[3];

            Console.WriteLine("==================================");
            Console.WriteLine("     REGISTRO DE ESTUDIANTE");
            Console.WriteLine("==================================");

            // Ingreso de números de teléfono
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write("Ingrese el teléfono " + (i + 1) + ": ");
                telefonos[i] = Console.ReadLine();
            }

            // Mostrar la información del estudiante
            Console.WriteLine("\n----- DATOS REGISTRADOS -----");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Teléfonos:");

            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine("  • " + telefonos[i]);
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Registro completado con éxito 😊");
            Console.ReadKey();
        }
    }
}
