/*
Задача 1:
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine($"Число {n} кратно одновременно 7 и 23");
else
    Console.WriteLine($"Введённое число ({n}) не кратно 7 и 23");
