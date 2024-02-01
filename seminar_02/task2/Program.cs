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