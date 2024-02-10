Console.Clear();
Console.WriteLine(@"Задача 1: 
Напишите программу, которая бесконечно запрашивает 
целые числа с консоли. Программа завершается при вводе символа 
‘q’ или при вводе числа, сумма цифр которого чётная.");

int sumNumber(int num)
{
    int summa = 0;
    if (num < 0)
        num *= -1;
    while (num != 0)
    {
        summa += num % 10;
        num /= 10;
    }
    return summa;
}

bool continueInput(string line)
{
    int n = 0;
    bool canConvert = int.TryParse(line, out n);
    if (canConvert)
    {
        if (sumNumber(n) % 2 == 0)
            return false;
    }
    else if (line == "q")
        return false;
    return true;
}

Console.Write("\nВведите целое число: ");
string input_line = Console.ReadLine()!;

while (continueInput(input_line))
{
    Console.Write("Введите целое число: ");
    input_line = Console.ReadLine()!;
}