/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] matrix = CreateInitDoubleMatrix(5, 6);
PrintMatrixInt(matrix);

double[] avgSum = AvgElemCol(matrix);
Console.WriteLine();
PrintArrey(avgSum);


int[,] CreateInitDoubleMatrix(int uRow, int uCol)
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

void PrintMatrixInt(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],8}");
        }
        Console.WriteLine();
    }
}

void PrintArrey(double[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"{matr[i],8}");
    }

    Console.WriteLine();
}

double[] AvgElemCol(int[,] matr)
{
    double[] avgSum = new double[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            avgSum[i] += matr[j, i];
        }
        avgSum[i] = Math.Round(avgSum[i] / matr.GetLength(0), 1);
    }

    return avgSum;
}