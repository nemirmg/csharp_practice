Console.Clear();
Console.WriteLine(@"Задача 4*(не обязательная):
Задайте строку, состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены в обратном порядке. 
В полученной строке слова должны быть также разделены пробелами.
");

Console.Write("Введите строку: ");
string[] str = Console.ReadLine()!.Split();
string newStr = "";
for (int i = str.Length - 1; i >= 0; i--){
    if (str[i] == "")
        continue;
    else if (i == 0)
        newStr += str[i];
    else
        newStr += $"{str[i]} ";
    
}
Console.WriteLine(newStr);

