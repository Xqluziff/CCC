/*
Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4


Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

*/

int[,] max = CreateInitMatrix(3, 4);
PrintMas(max);
System.Console.WriteLine();
int sum = SumElem(max);
//ReplacElements(max);

PrintMas(max);
System.Console.WriteLine(sum);


int[,] CreateInitMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }

    }
    return matrix;

}

void PrintMas(int[,] mas)
{

    for (int i = 0; i < mas.GetLength(0); i++)
    {

        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }

}

void ReplacElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
        }

    }

}

int SumElem(int[,] matr)
{
    sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum += matr[i, j];
        }

    }
    return sum;
}