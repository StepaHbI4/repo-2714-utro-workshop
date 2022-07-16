
///////////////////////Семинар///////////////////////////////

//Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int x = Convert.ToInt32(Console.ReadLine());

// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Четверть № 1");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четверть № 4");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("Четверть № 3");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("Четверть № 2");
// }


//Задача 18: 
//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).

//  int num = Convert.ToInt32(Console.ReadLine());

//  if (num == 1)
//  {
//     Console.WriteLine("x > 0 && y > 0");
//  }
// if (num == 2)
// {
//     Console.WriteLine("x < 0 && y > 0");
// }
// if (num == 3)
// {
//     Console.WriteLine("x < 0 && y < 0");
// }
// if (num == 4)
// {
//     Console.WriteLine("x > 0 && y < 0");
// }


//Задача 21:
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// int x1 = Convert.ToInt32(Console.ReadLine());

// int y1 = Convert.ToInt32(Console.ReadLine());

// int x2 = Convert.ToInt32(Console.ReadLine());

// int y2 = Convert.ToInt32(Console.ReadLine());

// //AB = √(xb - xa)2 + (yb - ya)2

// double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)); // Возведение в квадрат

// Console.WriteLine(Math.Round(d));


//Задача 22: 
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4


// Console.WriteLine("Введите число");

// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"Квадрат числа{i} = {i*i}");
// }




///////////////////////////////////////Домашняя работа/////////////////////////////////////////////////

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите число");
// string? num = Console.ReadLine();

// void CheckingNumber(string num){

//     if (num[0] == num[4] || num[1] == num[3]){
//         Console.WriteLine($"Введеное число: {num} - палиндром.");
//     }
//     else Console.WriteLine($"Введеное число: {num} - Не палиндром");
// }
// if (num!.Length == 5){
//     CheckingNumber(num);
// }
// else Console.WriteLine($"Введите верное число");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2,
//                 double y1, double y2,
//                 double z1, double z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) +
//                      Math.Pow((y2 - y1), 2) +
//                      Math.Pow((z2 - z1), 2));
// }

// double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

// Console.WriteLine($"Расстояние между точками  {segmentLength}");


//Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube)
// {
//     int counter = 0;
//     int length = cube.Length;
//     while (counter < length)
//     {
//         cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//         counter++;
//     }
// }

// void PrintArry(int[] coll)
// {
//     int count = coll.Length;
//     int index = 0;
//     while (index < count)
//     {
//         Console.Write(coll[index] + " ");
//         index++;
//     }
// }

// int[] arry = new int[cube + 1];
// Cube(arry);
// PrintArry(arry);