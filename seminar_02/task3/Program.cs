Console.Clear();
Console.WriteLine(@"Задача 3:
Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
и показывает наибольшую цифру числа.");

string message = "\nВведите число: ";
Console.Write(message);
int n = int.Parse(Console.ReadLine()!);
while (n < 10 || n > 99)
{
    string warning = "Ошибка! Число должно быть из отрезка [10, 99]";
    Console.Write(warning + message);
    n = int.Parse(Console.ReadLine()!);
}

int n1 = n / 10;
int n2 = n % 10;
string max = "";
if (n1 > n2)
    max = $"{n1}";
else if (n1 < n2)
    max = $"{n2}";
else
    max = "Цифры числа равны";

Console.WriteLine(max);
