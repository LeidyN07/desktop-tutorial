using System;
using System.Collections.Generic;

class BalanceChecker
{
    /// <summary>
    /// Verifica si una expresión matemática tiene paréntesis, llaves y corchetes balanceados.
    /// </summary>
    /// <param name="expression">Expresión matemática a evaluar</param>
    /// <returns>True si está balanceada, False en caso contrario</returns>
    public static bool EstaBalanceada(string expression)
    {
        Stack<char> pila = new Stack<char>();
        int pasos = 0;

        foreach (char c in expression)
        {
            pasos++;
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
                Console.WriteLine($"Paso {pasos}: Se encontró '{c}', se apila.");
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                {
                    Console.WriteLine($"Error en el paso {pasos}: No hay elemento que coincida con '{c}'.");
                    return false;
                }

                char top = pila.Pop();
                Console.WriteLine($"Paso {pasos}: Se encontró '{c}', se desapila '{top}'.");

                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    Console.WriteLine($"Error en el paso {pasos}: '{c}' no coincide con '{top}'.");
                    return false;
                }
            }
        }

        return pila.Count == 0;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese una expresión matemática:");
        string expresion = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(expresion))
        {
            Console.WriteLine("La expresión no puede estar vacía.");
            return;
        }

        Console.WriteLine(EstaBalanceada(expresion)
            ? "✅ Fórmula balanceada."
            : "❌ Fórmula no balanceada.");
    }
}