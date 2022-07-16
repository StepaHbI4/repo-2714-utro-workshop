
////////////////////////////////////////////Семинар//////////////////////////////////////////////

// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int[] inputArray = { 1, 2, 3, 4, 5 };
// // 0,1,2,3,4
// // size = 5, lastIndex = 5 -1 = 4
// int lastIndex = inputArray.Length - 1;

// int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

// // 4/2 = 2 + 0 = 2
// // 5/2 = 2 + 1 (в остатке)

// for (int i = 0; i < resultArray.Length; i++)
// {
//     resultArray[i] = inputArray[i] * inputArray[lastIndex - i];
//     if (i == lastIndex - i)
//     {
//         resultArray[i] = inputArray[i];
//     }
//     Console.Write($"{resultArray[i]} ");
// }


// Задача 39: 
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=ReverseCopyArray(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReverseArray(array);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];

// for (int i = 0; i < size; i++)
// {
//     res[i] = new Random().Next(minValue, maxValue + 1); // Next(0,11) -> [0;10]
// }
// return res;
// }

// void ReverseArray(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int temp = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = temp;
// }
// }

// int[] ReverseCopyArray(int[] inArray)
// {
// int[] result = new int[inArray.Length];
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];

// }
// return result;
// }


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// void Binary(int number)
// {
//     string errorResult ="";
//     string result = "";
//     while (number > 0)
//     {
//         result = number % 2 + result;
//         errorResult = errorResult + number%2 ;
//         number /= 2;
//     }
//     Console.WriteLine(result);
//     Console.WriteLine("Неправильный результат: "+ errorResult);
// }


// int inputNumber = Convert.ToInt32(Console.ReadLine());
// Binary(inputNumber);

////////////////////////////////////////Домашняя Работа//////////////////////////////////////////////


// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine($"\nПосчитай сколько чисел больше 0 ввел пользователь \n");
Console.Write($"Введи М чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");


// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine($"\nНайди точку пересечения двух прямых \n");
double[,] ratio = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < ratio.GetLength(0); i++)
    {
        Console.Write($"Введите значения {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < ratio.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение k: ");
            else Console.Write($"Введите значение b: ");
            ratio[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] ratio)
{
    crossPoint[0] = (ratio[1, 1] - ratio[0, 1]) / (ratio[0, 0] - ratio[1, 0]);
    crossPoint[1] = crossPoint[0] * ratio[0, 0] + ratio[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] ratio)
{
    if (ratio[0, 0] == ratio[1, 0] && ratio[0, 1] == ratio[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else
    {
        Decision(ratio);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }

}
InputCoefficients();
OutputResponse(ratio);

