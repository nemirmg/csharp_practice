void showMatrix(char[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.WriteLine(@"Задача 1:
Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.
");

char[,] charMatrix = {
    { 'H', 'e', 'l', 'l', 'o', ' ' },
    { 'w', 'o', 'r', 'l', 'd', '!' }
};
Console.WriteLine("Начальный массив:");
showMatrix(charMatrix);

string str = "";
for (int i = 0; i < charMatrix.GetLength(0); i++){
    for (int j = 0; j < charMatrix.GetLength(1); j++){
        str += charMatrix[i, j];
    }
}
Console.WriteLine($"\nПосле преобразования в строку:\n{str}");