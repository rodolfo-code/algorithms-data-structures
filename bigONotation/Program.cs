using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");

        string[] names = new string[] { "Marcos", "Pedro", "Joao", "Felipe", "Rodolfo" };

        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int[] nums2 = { 8, 9, 10 };


        // O(1) - CONSTANTE
        O1_constant(names);

        // O(n) - ALGORITMO LINEAR
        On_linear(names);

        // O(n) - O(6 + 2n) => O(n)
        On(names);

        //O(n^2)
        On2(nums);

        // O(n*m)
        Onm(nums, nums2);

    }

    public static void O1_constant(string[] names)
    {
        Console.WriteLine(names[0]);
    }

    public static void On_linear(string[] names)
    {
        foreach (var name in names)
        {
            if (name == "Rodolfo")
                Console.WriteLine(name);
        }
    }

    public static void On(string[] students)
    {
        var firtStudent = students[0]; /*O(1)*/
        int total = 0; /*O(1)*/
        string[] newList = new string[students.Length]; /*O(1)*/

        foreach (var student in students)
        {
            total += 1; /*O(n)*/
            newList.Append(student.ToString()); /*O(n)*/
        }

        Console.WriteLine(newList[1]); /*O(1)*/
        Console.WriteLine(total); /*O(1)*/
    }

    public static void On2(int[] list) /*O(n^2)*/
    {
        int total = 0;
        foreach(var num1 in list) 
        { 
            foreach(var num2 in list)
            {
                Console.WriteLine($"{num1} -  {num2}");
                total += 1;
            }
        }

        Console.WriteLine(total);
    }

    public static void Onm(int[] nums1, int[] nums2)
    {
        int total = 0;

        foreach (var num1 in nums1)
        {
            foreach (var num2 in nums2)
            {
                Console.WriteLine($"{num1} -  {num2}");
                total += 1;
            }
        }

        Console.WriteLine(total);

    }
}
