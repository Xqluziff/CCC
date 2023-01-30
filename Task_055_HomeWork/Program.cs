/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] matrix = CreateInitMatrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
SortLargestRowMatrix(matrix);
PrintMatrix(matrix);



int[,] CreateInitMatrix(int uRow, int uCol)
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
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],8}");
        }
        Console.WriteLine();
    }
}

void SortLargestRowMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            for (int k = j; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, j] < matr[i, k + 1])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }

        }
    }
}