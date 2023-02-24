// Seminar7

//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами строки массива заданные пользователем.

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

// void ChangeRows (int [,] array, int row1, int row2)
// {
//     if (row1 >= 0 && row1 < array.GetLength(0)&&
//         row2 >= 0 && row2 < array.GetLength(0)&&
//         row1 != row2)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array [row1,j] = array[row2,j];
//             array [row2,j] = temp;
//         }
//     }
//     else Console.WriteLine("Error");
// }

// int [,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);
// Console.WriteLine("Input a number row1: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a number row2: ");
// int row2 = Convert.ToInt32(Console.ReadLine());
// ChangeRows(myArray, row1, row2);
// Show2dArray(myArray);

// Задача 1. Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
// кол-во строк и столбцов должно быть равно, на вход массив - войд, меняем i и j
// по всем элекментам не придется идти

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
// void Transformation(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++ )
//         for (int j = i+1; j < array.GetLength(1); j++)
//         {
//             int temp = array [i,j];
//             array [i,j] = array [j,i];
//             array [j,i] = temp;
//         }
// }

// int [,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);
// Transformation(myArray);
// Show2dArray(myArray);

// Задача 2. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
// найти минимальный элемент, его индексы
// сгенерировать новый массив, где мы добавим проверку, и ислючить строку и столбец
// первый метод, найти мин элемент, второй метод, генерирование нового массива

int [,] CreatRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int [,] array = new int [rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array;
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
void ShowArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int [] MinIndexs(int [,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < array[minI,minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    int [] minarray = {minI,minJ};
    return minarray;
}

int [,] NewArray(int [,] array, int [] minarray)
{
    int [,] newArray = new int [array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i = 0, x = 0; i < array.GetLength(0); i++)
    {
        if (i != minarray[0])
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++)
            {
                if (j != minarray[1])
                {
                    newArray[x,y] = array [i,j];
                    y++;
                }
            }
            x++;
        }
    }
    return newArray; 
}

int [,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
int [] minarray = MinIndexs(myArray);
ShowArray(minarray);
int [,] newArray = NewArray(myArray,minarray);
Show2dArray(newArray);

