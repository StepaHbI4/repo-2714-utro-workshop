// Big O Notation

// O(n)

// 1. Эффективным по времени - 0(1)

// 2. Эффективным по памяти - оптимальный алгоритм 

// 3. Индексация массивов с нуля


////////////////////////////////////////////Семинар////////////////////////////////////////////////////

//Задача 31: 
//Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных
//и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];

// int size = array.Length;

// int resultPositive = 0;

// int resultNegative = 0;

// int index = 0;

// while (index < size)
// {
//     array[index] = new Random().Next(-9,10); // [-9,10]
//     index++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// for (int startIndex = 0; startIndex < size; startIndex++)
// {
//     if (array[startIndex] >0)
//     {
//         resultPositive += array[startIndex];
//         //resultPositive=resultPositive + array[startIndex]
//     }
//     else
//     {
//         resultNegative += array[startIndex];
//     }
// }

// Console.WriteLine($"Сумма положительных чисел = {resultPositive}");
// Console.WriteLine($"Сумма отрицательных чисел = {resultNegative}");


// Задача 32: 
// Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = { -4, -8, 8, 2 };
// Console.WriteLine($"Массив:{String.Join("; ", array)}");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }

// Console.WriteLine($"Обратный массив:{String.Join("; ", array)}");


// Задача 33: 
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = { -4, -8, 8, 2 };

// int number = new Random().Next(1, 21);
// Console.WriteLine(number);

// bool flagResult = false; // true - найдено, False - не найдено

// for (int i = 0; i < array.Length; i++)
// {
//     if (number == array[i])
//     {
//         flagResult = true;
//         break;
//     }
// }

// if (flagResult) Console.WriteLine($"Элемент {number} присутствует");
// else Console.WriteLine($"Элемент {number} не присутствует");


// Задача 35: 
//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123];

// int size = array.Length;

// int count = 0;

// for (int index = 0; index < size; index++)
// {
// array[index] = new Random().Next(0, 1000);

// if (array[index] >= 10 && array[index] <= 99)
// {
// count++;
// }
// }

// Console.WriteLine($"Исходный массив: {String.Join("; ", array)},количество: {count}");

////////////////////////////////////Домашняя работа///////////////////////////////////////////////////////////

// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.Clear();
// Console.WriteLine($"Программа на количество четных чисел в массиве:\n");
// int[] numbers = new int[10];

// void FillArray(int[] array, int min, int max){
//   for (int i = 0; i<array.Length; i++ ){
//     array[i] = new Random().Next(min, max);
//   }
// }

// void WriteArray(int[] array){
//     for (int i = 0; i<array.Length; i++ ){
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int QuantityPositive(int[] array){
//     int quantity = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       quantity++;
//     }
//   }
//   return quantity;
// }

// FillArray(numbers, 100, 1000);
// WriteArray(numbers);
// Console.WriteLine();

// int quantity = QuantityPositive(numbers);
// Console.WriteLine($"Ответ: {quantity}");


// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine($"\nНайти сумму элементов, стоящих на нечетных позициях\n");
// Console.Write($"Введите количество элементов массива: ");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 

// int RandomNumbers(int numberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("МАССИВ: ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  RandomNumbers(numberElements, 1, 10);

// Console.WriteLine($"\nСумма нечетных позиций : {randomNumbers}");

//Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.WriteLine($"\nНайдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

// double[] arrayRealNumbers = new double[10];
// for (int i = 0; i < arrayRealNumbers.Length; i++)
// {
//     arrayRealNumbers[i] = new Random().Next(1, 100);
//     Console.Write(arrayRealNumbers[i] + " ");
// }

// double maxNumber = arrayRealNumbers[0];
// double minNumber = arrayRealNumbers[0];

// for (int i = 1; i < arrayRealNumbers.Length; i++)
// {
//     if (maxNumber < arrayRealNumbers[i])
//     {
//         maxNumber = arrayRealNumbers[i];
//     }
//     if (minNumber > arrayRealNumbers[i])
//     {
//         minNumber = arrayRealNumbers[i];
//     }
// }

// double decision = maxNumber - minNumber;

// Console.WriteLine($"\nразница между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");

