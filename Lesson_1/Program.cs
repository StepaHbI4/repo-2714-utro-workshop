
//Семинар

Console.WriteLine("Бугагашеньки!");
//Задача 1
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

//Console.WriteLine("Введите первое число: ");
//int squareNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (squareNumber == number*number)
//{
//    Console.WriteLine("Да");
//}

//else
//{
//    Console.WriteLine("Нет");
//}

//Задача 2

//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

//Console.WriteLine("Введите номер дня недели");
//int dayNumber = Convert.ToInt32(Console.ReadLine());
//if (dayNumber <= 7 && dayNumber >=1 )
//{
//    if (dayNumber ==1)
//    {
//        Console.WriteLine("Понедельник");
//    }
//    if (dayNumber == 2)
//    {
//        Console.WriteLine("Вторник");
//    }
//}
//else {
//    Console.WriteLine("Error");
//}

//Задача 3

// Напищите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

//Console.Write("N: ");
//int N = Convert.ToInt32(Console.ReadLine());

//int negativeN = N * (-1); // N со знаком "-"

//while (negativeN <= N)
//{
//    Console.WriteLine(negativeN);
//    negativeN += 1; // negativeN = negativeN + 1
//}
///////////////////////////////////////////////////////////////////


//Домашняя работа//

//Задача 2

//Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());
 
        if(num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Первое число меньше второго");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }


//Задача 4

//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.


Console.WriteLine("Введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");

int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);


//Задача 6

//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).


Console.WriteLine("Введите число: ");

int num;
num = Console.Read();
if ((num % 2) == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}





    
    

