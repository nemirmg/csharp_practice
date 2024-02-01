// -------------------

Console.Clear();
Console.WriteLine(@"Задача 1:
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.");

Console.Write("\nВведите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine($"Число {n} кратно одновременно 7 и 23");
else
    Console.WriteLine($"Введённое число ({n}) не кратно 7 и 23");

// -------------------

Console.Clear();
Console.WriteLine(@"Задача 2:
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.");

string message = "\nВведите координату ";
Console.Write(message + "X: ");
int x = int.Parse(Console.ReadLine()!);

string warning = "Ошибка! Координата не должна быть равна 0.";
while (x == 0)
{
    Console.Write(warning + message + "X: ");
    x = int.Parse(Console.ReadLine()!);
}

Console.Write(message + "Y: ");
int y = int.Parse(Console.ReadLine()!);
while (y == 0)
{
    Console.Write(warning + message + "Y: ");
    y = int.Parse(Console.ReadLine()!);
}

string quarter = "";
if (x > 0 && y > 0)
    quarter = "I";
else if (x < 0 && y > 0)
    quarter = "II";
else if (x < 0 && y < 0)
    quarter = "III";
else if (x > 0 && y < 0)
    quarter = "IV";

Console.WriteLine($"Координаты ({x}, {y}) принадлежат {quarter} четверти.");

/* -------------------
Задача 3:
Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
и показывает наибольшую цифру числа.
------------------- */

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
string max;
if (n1 > n2)
    max = $"{n1}";
else if (n1 < n2)
    max = $"{n2}";
else
    max = "Цифры числа равны";

Console.WriteLine(max);
