//Задача 60. Сформируйте трехмерный массив из неповторяющихся двухзначных чисел. 
// Напишите программу которая построчно выводит массив.Добавляя индексы каждого элемента.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] InitializateArray(int m, int n, int l)
{
    return new int[m,n,l];
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = count;
                count += 1;
                if (count >= 100) break;
            }
            if (count >= 100) break;
        }
        if (count >= 100) break;
    }
    if (count >= 100) 
        {
            Console.WriteLine("Задан слишком большой массив");
        }

}

int m = GetNumberFromConsole("Введите колличество строк m");
int n = GetNumberFromConsole("Введите колличество столбцов n");
int l = GetNumberFromConsole("Введите глубину массива l");
int[,,] massiv = InitializateArray(m,n,l);
FillArray(massiv);
PrintArray(massiv);