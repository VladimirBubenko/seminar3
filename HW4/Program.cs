// HW4
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int rate(int a,int b)
{
    int result = 1;
    int current = 1;
    while (current <= b)
    {
        result = result * a;
        current++;

    }
    return result;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rate(a,b));
