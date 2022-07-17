
////////////////////////////////////////////Семинар////////////////////////////////////////////////////////////

// Задача 46: 
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows = Int32.Parse(Console.ReadLine());
// int columns = Int32.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11); //NextDouble() -> от 0 до 1
//         Console.Write(matrix[i, j] + "\t"); // t - Tab
//                                             // n - new
//     }
//     Console.WriteLine();
// }


// Задача 48: 
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// int[,] matrix = new int[3,4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }


// int[,] matrix = {{1,2,3,4},{5,5,6,7}};

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i + j;
//     }
//     Console.WriteLine();
// }


// Задача 49: 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// int[,] matrix = { { 1, 2, 3, 4 }, { 5, 5, 6, 7 }, { 10, 11, 12, 13 } };

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             matrix[i, j] *= matrix[i, j];
//             //matrix[i,j] = matrix[i,j] * matrix[i,j];
//         }
//         Console.Write(matrix[i, j] + "\t");

//     }
//     Console.WriteLine();

// }


//Задача 51: 
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// int[,] matrix = { { 1, 2, 3, 4 }, { 5, 5, 6, 7 }, { 10, 11, 12, 13 } };
// int sum = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sum += matrix[i, j];
//         }
//         //Console.Write(matrix[i, j] + "\t");

//     }
//     Console.WriteLine();

// }
// Console.WriteLine(sum);



///////////////////////////////////////////////Домашняя работа////////////////////////////////////////////////////


//Задача 47:
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine($"Двумерный массив размером m×n, заполненный случайными вещественными числами.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

Console.WriteLine($"\nРезультат\n");

WriteArray(array);


Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}


// Задача 50: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.



Console.Write("\nВоспользуемся массивом из задачи (№ 47).\n");
Console.Write("Введите позиции элемента, разделенных запятой: ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if (position[0] <= m
&& position[1] <= n
&& position[0] >= 0
&& position[1] >= 0)
{
    double result = array[position[0] - 1, position[1] - 1];
    Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
    int countNumbers = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNumbers++;
    }

    int[] numbers = new int[countNumbers];

    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }

    return numbers;
}

string RemovingSpaces(string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            output += input[i];
        }
    }
    return output;
}
Console.WriteLine();


//Задача 52: 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine($"\n\nНайди среднее арифметическое элементов в каждом столбце.");
Console.Write("\nВоспользуемся массивом (№ 47), преобразовав double в int32.\n");

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double average = 0;
  for (int j = 0; j < m; j++)
  {
    average += arrayWhole[j, i];
  }
  average = Math.Round(average / m, 1);
  Console.WriteLine($"столбец № {i+1} {average}");
}

int[,] TransformationArrayWhole (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}
Console.WriteLine();

//Задачка дополнительная: про друзей.
// условие в "info.md"

Console.WriteLine($"\tЧетыре друга поспорили.\n");
Console.WriteLine($"\tЧто пройдут 12 баров.\n");
Console.WriteLine($"\tИ не упадут от выпивки.\n");
double[] frendsLimit = new double[]{1.1, 1.5, 2.2, 3.3};
int speedDrinking = 15;
int[] walkingSpeed = new int[]{15, 20};
int travelTime = 0;
int pubsQuantity = 12;
double pint = 0.56826125;
int timeСounter = 0;

for (int j = 0; j <= frendsLimit.Length - 1; j++)
{
  int count = 0;
  travelTime = -17;
  
  while (frendsLimit[j] > 0)
  {
    frendsLimit[j] -= pint;
    count++;
    travelTime = travelTime + new Random().Next(walkingSpeed[0], walkingSpeed[1] + 1);
  }

  timeСounter = travelTime + speedDrinking * count;
  
  if (count > pubsQuantity) Console.WriteLine($"Друг № {j + 1} пошел на 2-й круг и упадёт в {count-12} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
  else 
  {
  Console.WriteLine($"Друг № {j + 1} упадёт в {count} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
  }
}




