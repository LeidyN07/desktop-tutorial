using System;

class Programa
{
    static void Main()
    {
        // Yo escribí las asignaturas que estudio
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("Estas son mis asignaturas:");
        foreach (var materia in asignaturas)
        {
            Console.WriteLine(materia);
        }
    }
}
