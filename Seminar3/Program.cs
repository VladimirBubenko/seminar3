// Math.Pow(a,b)=a^b
// Math.Sqrt(a)=корень из а
// Методы возращаются тип переменных double - т/е/ вещественые числа
// Math.Round(a,b) - округление вещественного числа: а само число, b - количество знаков после запятой
// Math.Round - используется перед выводом числа, в конце 

// Задача 1 - Пример: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int GetQuadrant(int x, int y)
// {
//     int quadNum = 0;
//     if (x > 0 && y > 0) 
//     quadNum =1;
//     else if (x < 0 && y > 0) 
//     quadNum = 2;
//     else if (x < 0 && y < 0) 
//     quadNum = 3;
//     else if (x > 0 && y < 0) 
//     quadNum = 4;
//     return quadNum;
// }


// int GetQuadrant(int x, int y)

// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }

// Console.Write("Input a first coordinate: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second coordinate: ");
// int yA = Convert.ToInt32(Console.ReadLine());

// int result = GetQuadrant(xA,yA);

// if(result == 0)
// {
//     Console.WriteLine("Your point is on axes");
// }
// else
// {
//     Console.WriteLine($"Your point is on {result}");
// }


// Задача 2. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// VOID метод, без return

// void ShowCoordinate(int quadNum)
// {
//     if (quadNum <= 0 || quadNum > 4) Console.WriteLine("uncorrect quadNum");
//     else if (quadNum == 1) Console.WriteLine("x > 0, y > 0");
//     else if (quadNum == 2) Console.WriteLine("x < 0, y > 0");
//     else if (quadNum == 3) Console.WriteLine("x < 0, y < 0");
//     else if (quadNum == 4) Console.WriteLine("x > 0, y < 0");
// }

// Console.Write("Input a quad number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowCoordinate(num);

// Задача 3. Напишите программу, 
// которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
// VOID метод, без return

// void ShowN(int num)
// {
//     int current = 1;
//     if (num <= 0) Console.WriteLine("Error num");
//     else 
//     {
//         while (current <= num)
//         {
//             Console.Write(Math.Pow(current,2) + " ");
//             current++;
//         }
//     }
// }
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowN(num);

// Задача 4.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// переменные тип double

double LenthPoint(double xA, double yA, double xB, double yB)
{
    double kat1 = xB - xA;
    double kat2 = yB - yA;
    double gip = Math.Sqrt(Math.Pow(kat1,2) + Math.Pow(kat2,2));
    return gip;
}

Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
double result = LenthPoint(xA,yA,xB,yB);
Console.WriteLine(Math.Round(result,2));
