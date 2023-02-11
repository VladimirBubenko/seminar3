// HW5. 
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random ().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// int[] CreateRandomArray(int size)
// {
//      int[] array = new int [size];
//      for (int i = 0; i < size; i++)
//          array[i] = new Random ().Next(100, 1000);
//      return array;
//  }
// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// int Count(int[]array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2==0)
//         count++;
//     }
//     return count;
// }

// Console.Write("Input a lengh of new array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);
// Console.WriteLine($"Anwer is {Count(myArray)}");


// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random ().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// int sum(int[] array)
// {
//     int summary = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(i%2!=0)
//             summary = array[i] + summary;
//     return summary;
// }

// Console.Write("Input a lengh of new array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min of new array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max of new array: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// Console.Write($"Answer is {sum(myArray)}");

// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] CreateRandomArray(int size, int minValue, int maxValue)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random ().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return array;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i],3) + " ");
    Console.WriteLine();
}

double Result(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        if(array[i] > max)
            max = array[i];

    for (int i = 0; i < array.Length; i++)
        if(array[i] < min)
            min = array[i];

    double result = max - min;
    return Math.Round(result,3);
}

Console.Write("Input a lengh of new array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min of new array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max of new array: ");
int max = Convert.ToInt32(Console.ReadLine());

double [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
double answer = Result(myArray);
Console.WriteLine($"Answer is {answer}");