using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");

        // ALGORITMO LINEAR - O(n)
        On_linear(new string[] { "Marcos", "Pedro", "Joao", "Felipe", "Rodolfo" });
    }

    public static void On_linear(string[] names)
    {
        foreach(var name in names)
        {
            if (name == "Rodolfo")
                Console.WriteLine(name);
        }
    }
}
