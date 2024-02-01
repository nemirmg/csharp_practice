Console.Clear();
Console.WriteLine(@"Задача 1:
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.");

Console.Write("\nВведите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно");