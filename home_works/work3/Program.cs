// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.



// char[,] MakeQArray(int rows, int cols, int max)
// {
//     Random rand = new Random();
//     char[,] qArray = new char[rows, cols];
//     for (int i = 0; i < qArray.GetLength(0); i++)
//         for (int j = 0; j < qArray.GetLength(1); j++)
//         {
//             qArray[i, j] = Convert.ToChar(rand.Next(65, max + 65));
//         }
//     return qArray;
// }

// string PrintArrString(char[,] qArray)
// {
//     string str = "";
//     for (int i = 0; i < qArray.GetLength(0); i++)
//         for (int j = 0; j < qArray.GetLength(1); j++)
//         {
//             str += Convert.ToString(qArray[i, j]);
//         }
//     return str;
// }

// System.Console.WriteLine(PrintArrString(MakeQArray(5, 5, 26)));



// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.



// string MakeString2(int length)
// {
//     Random rnd = new Random();
//     string str = "";
//     for (int i = 0; i < length; i++)
//     {
//     str += Convert.ToChar(rnd.Next(1, 3)==1 ? rnd.Next(65, 91) : rnd.Next(97, 123));
//     }
//     return str;
// }

// System.Console.Write("Введите длину строки: ");
// int len = Convert.ToInt32(Console.ReadLine());

// string rndString = MakeString2(len);

// System.Console.WriteLine("Начальная строка: " + rndString);
// System.Console.WriteLine("Строка без заглавных букв: " + rndString.ToLower());




// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.




// string MakeString(int length)
// {
//     Random rand = new Random();
//     string str = "";
//     for (int i = 0; i < length; i++)
//     {
//         str += Convert.ToChar(rand.Next(65, 65 + 26));
//     }
//     return str;
// }

// System.Console.Write("Введите длину строки: ");
// int len = Convert.ToInt32(Console.ReadLine());

// string s = MakeString(len);
// // string s = "anna";

// System.Console.WriteLine("String: " + s);

// bool IsPalindrome(string str)
// {
//     string revStr = "";
//     for (int i = str.Length - 1; i >= 0; i--)
//     {
//         revStr += str[i];
//     }
//     return str == revStr;
// }

// Console.WriteLine(IsPalindrome(s));



// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.



// string str = "Если между признаками есть приближённая линейная зависимость, коэффициенты в линейной модели могут совершенно потерять физический смысл";

// string ReverseString(string str)
// {
//     string[] words = str.Split(" ");
//     string result = "";
//     for (int i = words.Length - 1; i >= 0; i--)
//     {
//         result += words[i] + " ";
//     }
//     return result;
// }

// System.Console.WriteLine(ReverseString(str));