// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int [,] MinMaxArray (int [,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
        for (int x = array.GetLength(1)-1; x>0; x--)
            for (int j = 0; j < x; j++)
            {
                if (array[i,j]>array[i,j+1])
                    {
                        int temp = array [i,j];
                        array [i,j] = array [i,j+1];
                        array [i,j+1] = temp;
                    }
            }
    return array;
}

int [,] myArray = CreatRandom2dArray();
Show2dArray(myArray);

int [,] newMayArray = MinMaxArray(myArray);
Show2dArray(newMayArray);
