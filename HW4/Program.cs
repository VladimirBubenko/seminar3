// HW4
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int rate(int a,int b)
// {
//     int result = 1;
//     int current = 1;
//     while (current <= b)
//     {
//         result = result * a;
//         current++;

//     }
//     return result;
// }

// Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rate(a,b));

// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int sum(int number)
// {
//     int mult = 0;
//     int result = 0;
//     while (number > 0)
//     {
//         mult = number%10;
//         result = result + mult;
//         number = number/10;
//     }
//     return result;
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sum(number));

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] mas(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input intdex {i} = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a lengh of new array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = mas(size);
ShowArray(myArray);
