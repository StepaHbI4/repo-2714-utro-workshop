
/////////////////////////////Cеминар/////////////////////////////////////////////////////////////

// void , методы

// void - нет return

// void TestMethod(int number)
// {
//     number*=number;
//     //Console.WrieteLine(number);
//     return number;
// }
// Console.WriteLine(TestMethod(5));
// // f(z) = f(x) + f(y)

/////////////////////////////////////////////////////////////////////////////////////////////////

// int [] array = {1,2,3,4,5};

// Console.WriteLine($"{String.Join("; ", array)}"); // интерполяция

//1; 2; 3; 4; 5

//////////////////////////////////////////////////////////////////////////////////////////////////

// int index = 1;

// Console.WriteLine(index++); // ++ увеличение на еденичку


// // Пре-инкримент, пост-инкримент

///////////////////////////////////////////////////////////////////////////////////////////////////

// TryParse

// string test = "12345"; // 12345
// int result = 0;
// Console.WriteLine(int.TryParse(test, out result));

// Console.WriteLine(result);

///////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 24: 
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28 
// 4 -> 10 
// 8 -> 36

// int A = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// // for (int i = 1; i<=A; i++)
// // {
// //     sum+= i;
// //     // sum = sum +i
// // }

// int i = 1;
// while(i <= A)
// {
//     sum+=i;
//     i++;
// }
// Console.WriteLine(sum);

/////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 26:
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// 78 -> 7(1) -> 0(2) -> 3(!=0)

// int number = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// while (number != 0)
// {
//     number /= 10;
// // number = number / 10
// count++;
// }
// Console.WriteLine(count);

/////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 28: Факториал!
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int N = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// int start = 1;

// while(start <= N)
// {
//     result*=start;
//     start++;
// }
// // 1до N

// for (int i = 2; i <= N; i++)
// {
//     result*=i;
// }
// Console.WriteLine(result);

/////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// int [] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join("; ",array )}]");
// int [] GetBinaryArray(int size)
// {
//     int[] resultArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(2);
//     }

//     return resultArray;
// }

//////////////////////////////////////////Домашняя Работа////////////////////////////////////////////////


// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.WriteLine("Возведите число A в натуральную степень B");

// int Exponentiation(int numberA, int numberB)
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }

//     return result;
// }

// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation(numberA, numberB);
// Console.WriteLine("Ответ: " + exponentiation);

// Console.WriteLine("Задача решена!");

/////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.WriteLine("Посчитайте сумму всех цифр в числе");
// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int numberN)
// {

//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++)
//     {
//         advance = numberN - numberN % 10;
//         result = result + (numberN - advance);
//         numberN = numberN / 10;
//     }
//     return result;
// }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);
// Console.WriteLine("Задача решена!");

///////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



// Console.Write("Введите через запятую ряд чисел : ");
// string? seriesOfNumbers = Console.ReadLine();

// seriesOfNumbers = seriesOfNumbers + ",";    // Дополнительня запятая для обозначения конца строки

// // Удаление пробелов из строки 
// string RemovingSpaces (string series){
//   string seriesNew = "";
//   for (int i = 0; i < series.Length; i++)
//   {
//     if (series[i] != ' ') 
//     {
//       seriesNew += series[i];
//     }
//   }
//   return seriesNew;
// }

// //    Проверка на правильность ввода 
// void СheckNumber2 (int  series){

//       if (series == '0'||series == '1'||series == '2'
//       ||series == '3'||series == '4'||series == '5'||series == '6'
//       ||series == '7'||series == '8'||series == '9'||series == ','
//       ||series == '-')
//       {
//       }
//         else {
//           Console.WriteLine($"Ошибка Ошибка Ошибка! Вводи цифры!.");

//       }
// }

// //  Создание и заполнение массива из строки
// int[] ArrayOfNumbers(string seriesNew){ 

//   int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

//   int j =0;

//   for (int i = 0; i < seriesNew.Length; i++){
//     string seriesNew1 = "";

//     while (seriesNew[i] != ',' && i < seriesNew.Length){
//       seriesNew1 += seriesNew[i];
//       СheckNumber2(seriesNew[i]);
//       i++;
//     }
//     arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполнение массива значениями из строки
//     if (i < seriesNew.Length-1){
//       arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавление нового нулевого элемента в конец массива
//     }
//     j++;
//   }
//   return arrayOfNumbers;
// }

// // Вывод массива на печать 
// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   Console.Write("[");
//   while(index < count){
//     Console.Write(coll[index]);
//     index++;
//     if (index < count){
//       Console.Write(", ");
//     }
//   }
//   Console.Write("]");
// } 


// string seriesNew = RemovingSpaces(seriesOfNumbers);

// int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

// PrintArry(arrayOfNumbers);






