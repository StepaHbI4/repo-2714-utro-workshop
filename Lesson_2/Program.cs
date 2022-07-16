//////////////////////////////////////////////Семинар/////////////////////////////////////////////////////

// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

// comand +/ - быстрое комментирование

// int number = new Random().Next(10,100); // [10,100]
// Console.WriteLine($"Случайное число - {number}"); // Интерполяция
// int digitOne = number / 10; // 56 -> 5. 56/10 = 5
// int digitTwo = number % 10; // 56 -> 6
// Console.WriteLine(digitOne);
// Console.WriteLine(digitTwo);


// int max = Math.Max(digitOne,digitTwo); //Max(1_значение,2_значение)
// int min = Math.Min(digitOne,digitTwo);
// Console.WriteLine($"Самое большое число - это {max}");
// Console.WriteLine($"Самое большое число - это {min}");


///////////////////////////////////////////////Задача 11/////////////////////////////////////////////////////

//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int digitOne = number / 100;
// int digitThre = number % 10;
// Console.WriteLine("результат" + digitOne + digitThre);

/////////////////////////////////////////////////////Задача 12//////////////////////////////////////////////////

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int firstNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine("Число делится без остатка");
// }
// else
// {
//      Console.WriteLine($"Остаток: {firstNumber % secondNumber}"); //Интерполяция

// }

///////////////////////////////////////Задача 14/////////////////////////////////////////////

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет (False)
// 161 -> да (True)

// int value = Convert.ToInt32(Console.ReadLine());
// bool IsMultiplicity (int number)
// {
//     return(number % 7 == 0 && number % 23 == 0); // && - логическое "И"
// }

// Console.WriteLine(IsMultiplicity(350));


//////////////////////////////////////////Домашняя Работа///////////////////////////////////////

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число.");
// while (true)
// {
//     string input = Console.ReadLine();
//     if (!input.Equals("exit"))
//         Console.WriteLine("{0}->{1}", input, input[1]);
//     else
//         break;
// }


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите  число.");

// while (true)
// {
//     string input = Console.ReadLine();
//     if (!input.Equals("exit"))
//         Console.WriteLine("{0} третья цифра {1}", input, input[2]);
//     else
//          break;

// }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// using System.Globalization;
// internal class NewBaseType
// {
//     static void Main(string[] args)
//     {
//         uint day = uint.Parse(Console.ReadLine());
//         string[] days = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
//         Console.WriteLine(day == 7 ? days[0] : day <= 6 && day >= 1 ? days[day] : "нет данных");
//         Console.ReadKey(true);
//     }
// }



