using System;
using System.Collections.Generic;

// Esta clase representa un turno médico
class Turno
{
    public string NombrePaciente;
    public string NombreDoctor;
    public string FechaTurno;
}

class Program
{
    static void Main()
    {
        List<Turno> listaTurnos = new List<Turno>();
        int opcion;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("   BIENVENIDO A LA AGENDA CLÍNICA");
        Console.WriteLine("------------------------------------");

        do
        {
            Console.WriteLine("\n¿Qué deseas hacer?");
            Console.WriteLine("1. Registrar un nuevo turno");
            Console.WriteLine("2. Ver los turnos registrados");
            Console.WriteLine("3. Salir del sistema");
            Console.Write("Escribe el número de la opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Turno turnoNuevo = new Turno();

                Console.Write("\nIngresa el nombre del paciente: ");
                turnoNuevo.NombrePaciente = Console.ReadLine();

                Console.Write("Ingresa el nombre del doctor: ");
                turnoNuevo.NombreDoctor = Console.ReadLine();

                Console.Write("Ingresa la fecha del turno: ");
                turnoNuevo.FechaTurno = Console.ReadLine();

                listaTurnos.Add(turnoNuevo);

                Console.WriteLine("\n El turno fue registrado con éxito.");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\n📋 TURNOS REGISTRADOS:");

                if (listaTurnos.Count == 0)
                {
                    Console.WriteLine("Aún no existen turnos registrados.");
                }
                else
                {
                    foreach (Turno t in listaTurnos)
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Paciente: " + t.NombrePaciente);
                        Console.WriteLine("Doctor: " + t.NombreDoctor);
                        Console.WriteLine("Fecha: " + t.FechaTurno);
                    }
                }
            }

        } while (opcion != 3);

        Console.WriteLine("\nGracias por usar la Agenda Clínica. ¡Hasta pronto!");
    }
}

