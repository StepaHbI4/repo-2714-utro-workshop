
///////////////////////////////////////Семинар//////////////////////////////////
// Рукурсия
// n! = 1...n
// функция
// Factorial(4)
// Мы идем на 8 строчку, так как "4" !=1.
// в 8 строчке: 4 * Factorial(4-1)

// и далее - мы выполняем Factorial(3)
// 4*3 Factorial(2)
// Factorial(1)
// return 1;
// 4*3*2*1

// int Factorial(int n)
// {
//     if (n == 1) return 1; //Базовый случай - выход из рекурсии
//     return n * Factorial(n - 1); // Рекурсивный случай - вызов функции Факториал
// }

// Console.WriteLine(Factorial(5));
//Базовый случай - условие выхода из рекрсии
//Рекурсивный - вызов функции


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1, N));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers(int number)
// {
//     if (number == 0) return 0;
//     return (number % 10 + SumNumbers(number / 10));
// }
// Console.WriteLine(SumNumbers(number));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// int number = Convert.ToInt32(Console.ReadLine());
// int stepen = Convert.ToInt32(Console.ReadLine());
// int NumberStepen(int first, int second)
// {
//     if (second == 0) return 1;
//     return (first * NumberStepen(first, second - 1));
// }
// Console.WriteLine(NumberStepen(number, stepen));


///////////////////////////Домашняя Работа///////////////////////////


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int temp = m;

// if (m > n)
// {
//     m = n;
//     n = temp;
// }

// PrintSumm(m, n, temp = 0);

// void PrintSumm(int m, int n, int summ)
// {
//     summ = summ + n;
//     if (n <= m)
//     {
//         Console.Write($"Сумма натуральных элементов= {summ} ");
//         return;
//     }
//     PrintSumm(m, n - 1, summ);
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 


// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Ack(m - 1, 1);
//     else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }