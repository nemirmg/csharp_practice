char[,] createAlphabet(string str){
    char[,] alphabet = new char[2, str.Length];
    string strLower = str.ToLower();
    string strUpper = str.ToUpper();
    for (int i = 0; i < str.Length; i++){
        alphabet[0, i] = strLower[i];
        alphabet[1, i] = strUpper[i];
    }
    return alphabet;
}

char convertToLower(char symbol, char[,] alphabet){
    for (int i = 0; i < alphabet.GetLength(1); i++){
        if (symbol == alphabet[1, i])
            return alphabet[0, i];
    }
    return symbol;
}


Console.Clear();
Console.WriteLine(@"Задача 2
Задайте строку, содержащую латинские буквы в
обоих регистрах. Сформируйте строку, в которой
все заглавные буквы заменены на строчные.");

Console.WriteLine("\nВведите строку, содержащую латинские буквы в обоих регистрах: ");
string str = Console.ReadLine()!;
Console.WriteLine($"Начальная строка:\n{str}");

string letters = "abcdefghijklmnopqrstuvwxyz";
char[,] alphabet = createAlphabet(letters);
// string[] alphabet = new string[2];
// alphabet[0] = letters;
// alphabet[1] = letters.ToUpper();

string newStr = "";
for (int i = 0; i < str.Length; i++){
  newStr += convertToLower(str[i], alphabet);
}
Console.WriteLine($"Результат:\n{newStr}");