Console.Clear();
Console.WriteLine(@"Задача 3:
Напишите программу, которая перевернёт одномерный массив
(первый элемент станет последним, второй – предпоследним и т.д.)");

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1001);
}

int[] flipArray(int[] array)
{
    int[] new_array = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        new_array[array.Length - 1 - i] = array[i];
    return new_array;
}

Console.Write("\nВведите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Перевёрнутый массив: [{string.Join(", ", flipArray(array))}]");