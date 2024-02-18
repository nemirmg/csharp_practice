Console.Clear();
Console.WriteLine(@"Задача 2:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.");

int printAkkerman(int m, int n){
    if (m > 0 && n > 0)
        return printAkkerman(m - 1, printAkkerman(m, n - 1));
    else if (m > 0 && n == 0)
        return printAkkerman(m - 1, 1);
    // else if (m == 0)
    return n + 1;
}
/*
f(2, 0) -> f(2 - 1, 1) = f(1, 1) -> 
f(1 - 1, f(1, 1 - 1)) = f(0, f(1, 0))
                             |
                             f(1 - 1, 1) = f(0, 1)
                                           |
                                           1 + 1 = 2
*/
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(printAkkerman(m, n));