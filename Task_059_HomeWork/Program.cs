/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



int[,] spiralMartix = CreateInitSpiralMatrix(4);  // только для квадратных матриц
PrintMatrix(spiralMartix);

int[,] CreateInitSpiralMatrix(int size)
{
    int[,] matr = new int[size, size];
    int elem = 0;


    for (int i = 0; i <= size / 2; i++)
    {
        for (int j = i; j <= size - i - 1; j++)
        {
            matr[i, j] = elem;
            elem++;
        }

        for (int k = i + 1; k < size - i; k++)
        {
            matr[k, size - i - 1] = elem;
            elem++;
        }

        for (int h = size - i - 2; h >= i; h--)
        {
            matr[size - i - 1, h] = elem;
            elem++;
        }
        for (int m = size - i - 2; m >= i + 1; m--)
        {
            matr[m, i] = elem;
            elem++;
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
            Console.Write($"{matr[i, j],5}");

        }

        Console.WriteLine();
    }
}
