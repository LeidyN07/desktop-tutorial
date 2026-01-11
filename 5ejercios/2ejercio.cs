using System;

class Programa
{
    static void Main()
    {
        // Yo escribí las materias que estudio
        string[] materias = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("\nMensajes de mis materias:");
        foreach (var m in materias)
        {
            Console.WriteLine("Yo estudio " + m);
        }
    }
}
