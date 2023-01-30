/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] matrix = CreateIniteMatrix(10, 5);
PrintMatrix(matrix);
int minSum = MinSumRowToMatrix(matrix);
Console.WriteLine($"Наименьшая сумма на {minSum} строке");


int[,] CreateIniteMatrix(int uRow, int uCol)
{
    int[,] matr = new int[uRow, uCol];
    var rnd = new Random();

    for (int i = 0; i < uRow; i++)
    {
        for (int j = 0; j < uCol; j++)
        {
            matr[i, j] = rnd.Next(10, 100);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5}");
            sum += matr[i, j];
        }
        Console.WriteLine(" | " + sum);
        Console.WriteLine();
    }
}

int MinSumRowToMatrix(int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] += matr[i, j];

        }

    }

    int minSum = sum[0];
    int numRow = 1;

    for (int i = 1; i < sum.Length; i++)
    {
        if (minSum > sum[i])
        {
            minSum = sum[i];
            numRow = i + 1;

        }
    }
    return numRow;
}