// Задача 58. Задайте две матрицы.
// Напишите программу которая будет находить произведение двух матриц

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

void MultiplicationArray(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] massiv1 = InitializateArray(m,n);
int[,] massiv2 = InitializateArray(m,n);
int[,] massiv3 = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(massiv1,minValue,maxValue);
PrintArray(massiv1);
Console.WriteLine();
FillArray(massiv2,minValue,maxValue);
PrintArray(massiv2);
Console.WriteLine();
MultiplicationArray(massiv1,massiv2,massiv3);
PrintArray(massiv3);