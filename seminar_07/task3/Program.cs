//--------------------
// Вариант 1
/*
Console.Clear();
Console.WriteLine(@"Задача 3:
Задайте произвольный массив. Выведете его элементы, начиная с конца.
Использовать рекурсию, не использовать циклы.
");

string flipArray(int[] array, int i){
    if (i == array.Length)
        return "";
    return flipArray(array, i + 1) + $"{array[i]} ";
}

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);
Console.WriteLine($"Начальный массив: {string.Join(" ", array)}");
Console.WriteLine($"Перевёрнутый массив: {flipArray(array, 0)}");
*/

//--------------------
// Вариант 2

Console.Clear();
Console.WriteLine(@"Задача 3:
Задайте произвольный массив. Выведете его элементы, начиная с конца.
Использовать рекурсию, не использовать циклы.
");

void flipArray(int[] array, int i){
    if (i == array.Length / 2)
        return;
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
    flipArray(array, i + 1);
}

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
flipArray(array, 0);
Console.WriteLine($"Перевёрнутый массив: [{string.Join(", ", array)}]");