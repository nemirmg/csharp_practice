Console.Clear();
Console.WriteLine(@"Задача 4:
Напишите программу, которая на вход принимает натуральное число N,
а на выходе показывает его цифры через запятую.");

string message = "\nВведите число: ";
Console.Write(message);
int n = int.Parse(Console.ReadLine()!);
while (n < 0)
{
    string warning = "Число не должно быть отрицательным!";
    Console.Write(warning + message);
    n = int.Parse(Console.ReadLine()!);
}

int num;
string text = "";
while (n > 0)
{
    num = n % 10;
    if (n / 10 == 0)
        text = $"{num}" + text;
    else
        text = $", {num}" + text;
    n /= 10;
}

Console.WriteLine(text);
