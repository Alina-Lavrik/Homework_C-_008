/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
Console.WriteLine("");
RowMinSumNum(array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void RowMinSumNum(int[,] array)
{
    int MinRow = 0;
    int SumRow = 0;
    int RowWhitMin = 0;
   
    for (int i = 0; i < array.GetLength(1); i++)
    {
        MinRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        SumRow += array[i, j];
        if (SumRow < MinRow)
        {
            MinRow = SumRow;
            RowWhitMin = i;
        }
        SumRow = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов {RowWhitMin + 1}");
}


    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }



