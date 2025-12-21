using System;
using System.Collections.Generic;

namespace AgendaTurnos
{
    // Clase Turno (registro simple)
    class Turno
    {
        public string Paciente;
        public string Fecha;

        // Constructor
        public Turno(string paciente, string fecha)
        {
            Paciente = paciente;
            Fecha = fecha;
        }

        // Mostrar datos del turno
        public void Mostrar()
        {
            Console.WriteLine("Paciente: " + Paciente);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("------------------");
        }
    }

    class Program
    {
        // Lista de turnos
        static List<Turno> turnos = new List<Turno>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("AGENDA DE TURNOS");
                Console.WriteLine("1. Agregar turno");
                Console.WriteLine("2. Ver turnos");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcion == 1)
                {
                    AgregarTurno();
                }
                else if (opcion == 2)
                {
                    VerTurnos();
                }

            } while (opcion != 3);

            Console.WriteLine("Programa finalizado.");
        }

        // Método para agregar turnos
        static void AgregarTurno()
        {
            Console.Write("Nombre del paciente: ");
            string paciente = Console.ReadLine();

            Console.Write("Fecha del turno: ");
            string fecha = Console.ReadLine();

            Turno nuevo = new Turno(paciente, fecha);
            turnos.Add(nuevo);

            Console.WriteLine("Turno guardado.\n");
        }

        // Método para mostrar turnos
        static void VerTurnos()
        {
            if (turnos.Count == 0)
            {
                Console.WriteLine("No hay turnos registrados.\n");
            }
            else
            {
                foreach (Turno t in turnos)
                {
                    t.Mostrar();
                }
            }
        }
    }
}
