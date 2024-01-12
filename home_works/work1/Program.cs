// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// bool task_1(int num)
// {
//     //Если остаток от деления 7 и 23 равен 0 то возвращает true
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     //Иначе false
//     return false;
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(task_1(number));



// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// int task_2(int x, int y)
// {
//     //Не самый эффективный метод, зато очень простой
//     if (x > 0 && y > 0)
//         return 1;
//     else if(x < 0 && y > 0)
//         return 2;
//     else if(x < 0 && y < 0)
//         return 3;
//     else
//         return 4;
// }

// System.Console.Write("Введите X: ");
// int number_x = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите Y: ");
// int number_y = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(task_2(number_x, number_y));



// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int task_3(int num)
// {
//     if (num / 10 > num % 10)
//         return num / 10;
//     else
//         return num % 10;
// }

// Random random = new Random();

// System.Console.WriteLine(task_3(random.Next(10, 100)));



// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// string task_4(int num)
// {
//     //В переменной text будут хранится числа через запаятую
//     string text = "";
//     // Использую цикл while чтобы цикл остановился когда останится однозначное число
//     while (num > 9)
//     {
//         // Добавляю цифру к строке вместе с запятой и отнимаю у num эту цифру
//         text += Convert.ToString(num % 10) + ", ";
//         num /= 10;
//     }
//     // Эта операция вне цикла чтобы в конце не ставить запятую
//     text += Convert.ToString(num);

//     return text;
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(task_4(number));

// Программа выводит числа в обратном порядке, но в условии про порядок ни слова так-что я думаю все нормально