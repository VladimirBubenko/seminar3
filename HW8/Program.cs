// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int [,] CreatRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of minValue: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of maxValue: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int [,] array = new int [rows,columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int [,] MinMaxArray (int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//         for (int x = array.GetLength(1)-1; x>0; x--)
//             for (int j = 0; j < x; j++)
//             {
//                 if (array[i,j]>array[i,j+1])
//                     {
//                         int temp = array [i,j];
//                         array [i,j] = array [i,j+1];
//                         array [i,j+1] = temp;
//                     }
//             }
//     return array;
// }

// int [,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);

// int [,] newMayArray = MinMaxArray(myArray);
// Show2dArray(newMayArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int [,] CreatRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of minValue: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of maxValue: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int [,] array = new int [rows,columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int [] Done (int [,] array)
// {
//     int [] summary = new int [array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//                 summary[i]= summary[i] + array [i,j];
//     return summary;
// }

// int Result (int [] array)
// {
//     int min = array[0];
//     int minindex = 0;
//     for (int i = 0; i < array.Length-1; i++)
//         if (array[i] < min)
//             {
//                 min = array[i];
//                 minindex = i;
//             }
//     return minindex;
// }

// int [,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);
// int [] summary = Done(myArray);
// ShowArray (summary);
// int number = Result(summary);
// Console.WriteLine($"Строка c индексом {number} имеет минимальную сумму");


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// int [,] MultiArray (int [,] array1, int [,] array2)
// {
//     int [,] multiArray = new int [array1.GetLength(0), array2.GetLength(1)];
//     if (array1.GetLength(1) != array2.GetLength(0))
//         Console.WriteLine("Error");
//     else
//         for (int i = 0; i < array1.GetLength(0); i++)
//             for (int j = 0; j < array2.GetLength(1); j++)
//                 for (int k = 0; k < array2.GetLength(0); k++)
//                     multiArray[i,j] += array1[i,k]*array2[k,j];
//     return multiArray;
// }

// int [,] NewArray ()
// {
//     Console.WriteLine("Введите размерность матрицы: ");
//     int [,] matrix = new int [Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"Элемент {i},{j} = ");
//                 matrix [i,j] = Convert.ToInt32(Console.ReadLine());
//             }
//     return matrix;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Задайте матрицу А: ");
// int [,] myArray = NewArray();
// Show2dArray(myArray);

// Console.WriteLine("Задайте матрицу В: ");
// int [,] newArray = NewArray();
// Show2dArray(newArray);

// int [,] multiArray = MultiArray(myArray,newArray);
// Show2dArray(multiArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
 
    int [,] matrix = new int [4,4];
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= matrix.GetLength(0)*matrix.GetLength(1))
    {
        matrix [i,j] = number;
        number++;
        if (i<=j+1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i+ j > matrix.GetLength(1) - 1)
            j--;
        else 
            i--;
    }

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Show2dArray(matrix);