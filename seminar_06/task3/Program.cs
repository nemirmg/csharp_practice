Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

Console.Clear();
Console.WriteLine(@"Задача 3:
Задайте произвольную строку. 
Выясните, является ли она палиндромом.
");
Console.Write("Введите строку: "); // голод долог
string str = Console.ReadLine()!;

string answer = "Строка - палиндром";
for (int i = 0; i < str.Length / 2; i++){
    if (str[i] != str[str.Length - 1 - i])
        answer = "Строка не является палиндромом";
        break;
}
Console.WriteLine(answer);