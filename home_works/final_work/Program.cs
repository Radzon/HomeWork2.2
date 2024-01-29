// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

System.Console.Write("input M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input N: ");
int n = Convert.ToInt32(Console.ReadLine());


void NaturalNumbs(int m, int n)
{
    if (m >= n)
        return;
    Console.Write(m + " ");
    NaturalNumbs(m + 1, n);
}

NaturalNumbs(m, n);



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// System.Console.Write("input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return AckermannFunction(m - 1, 1);
//     }
//     else
//     {
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }

// System.Console.WriteLine(AckermannFunction(n, m));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


// int[] CreateRandomArray(int min, int max)
// {
//     int[] array = new int[10];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }

//     return array;
// }

// int[] arrr = CreateRandomArray(1, 10);
// System.Console.WriteLine("Начальный масив: " + string.Join(" ", arrr));
// System.Console.Write("Выведеный масив: ");

// void PrintArray(int[] array, int i)
// {
//     if (i == 0)
//         return;
//     Console.Write(array[i - 1] + " ");
//     PrintArray(array, i - 1);
// }

// PrintArray(arrr, 10);