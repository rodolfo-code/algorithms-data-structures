using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");

        string[] names = new string[] { "Marcos", "Pedro", "Joao", "Felipe", "Rodolfo" };

        // O(n) - ALGORITMO LINEAR
        On_linear(names);

        // O(1) - CONSTANTE
        O1_constant(names);
    }

    public static void On_linear(string[] names)
    {
        foreach(var name in names)
        {
            if (name == "Rodolfo")
                Console.WriteLine(name);
        }
    }

    public static void O1_constant(string[] names)
    {
        Console.WriteLine(names[0]);
    }
}
