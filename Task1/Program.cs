//Задача 1: Проверка кратности числа 7 и 23

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}