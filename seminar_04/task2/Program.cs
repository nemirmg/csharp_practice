Console.Clear();
Console.WriteLine(@"Задача 2:
Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел 
в массиве");

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

bool evenNumber(int num)
{
    if (num % 2 == 0)
        return true;
    return false;
}

Console.Write("\nВведите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

int count = 0;
foreach (int element in array)
{
    if (evenNumber(element))
        count++;
}
Console.WriteLine($"Чётных чисел в массиве: {count}");