// Понял задание так, что сами значения M и N в промежуток не входят

Console.Clear();
Console.Write(@"Задача 1:
Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
");

string printNumbers(int m, int n, int i){
    if (m + i == n)
        return "";
    return $"{m + i}" + printNumbers(m + i, n, i);
}

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Натуральные числа между {m} и {n}:");

if (m < 0)
    m = 0;
if (n < 0)
    n = 0;


int i = 0;
if (m < n)
    i = 1;
else if (m > n)
    i = -1;

Console.WriteLine(printNumbers(m, n, i));