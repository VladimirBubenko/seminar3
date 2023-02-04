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


int GetQuadrant(int x, int y)

{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input a first coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());

int result = GetQuadrant(xA,yA);

if(result == 0)
{
    Console.WriteLine("Your point is on axes");
}
else
{
    Console.WriteLine($"Your point is on {result}");
}
