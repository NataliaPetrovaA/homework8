// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
// строки двумерного массива.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

void SortDescending(int[,] arr)
{
    int[,] arr2 = new int[arr.GetLength(0),arr.GetLength(1)];
    arr2 = arr;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < arr.GetLength(1) - 1; z++)
            {
                if (arr2[i, z] < arr2[i, z + 1])
                {
                    temp = arr2[i, z];
                    arr2[i, z] = arr2[i, z + 1];
                    arr2[i, z + 1] = temp;
                }
            }
        }   
    }
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
Console.WriteLine();
FillArray(array,minValue,maxValue);
PrintArray(array);
SortDescending(array);
Console.WriteLine();
PrintArray(array);