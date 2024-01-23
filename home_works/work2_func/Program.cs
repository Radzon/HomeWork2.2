// Функции нужные в решении задачи 1 и 2.
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true)
// {
//     string input = Console.ReadLine();
//     if (input == "q")
//     {
//         break;
//     }
//     int number = int.Parse(input!);
//     int count = 0;
//     while (number >= 1)
//     {
//         count += number % 10;
//         number /= 10;
//     }
//     if (count % 2 == 0)
//     {
//         break;
//     }
// }


// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Enter array size: ");
// int arrSize = int.Parse(Console.ReadLine()!);

// int[] arr = CreateRandomArray(arrSize, 100, 1000);

// int count = 0;
// int x = 0;
// while (count < arr.Length) if (arr[count++] % 2 == 0) x++;

// Console.WriteLine(x);


// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// Console.WriteLine("Enter array size: ");
// int arrSize = int.Parse(Console.ReadLine()!);

// int[] arr = CreateRandomArray(arrSize, 1, 10);

// Console.Write("Original array: ");
// PrintArray(arr);

// for (int i = 0; i < arr.Length / 2; i++)
// {
//     int temp = arr[i];
//     arr[i] = arr[arr.Length - i - 1];
//     arr[arr.Length - i - 1] = temp;
// }

// Console.Write("New array: ");
// PrintArray(arr);