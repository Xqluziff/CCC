/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого элемента в массиве нет
*/

Console.WriteLine("Введите позицию 2х метрого массива");
Console.WriteLine("Ввдедите строку :");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввдедите колонку :");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateInitDoubleMatrix(8, 10);
PrintMatrix(matrix);

if (row <= 0 || col <= 0) Console.WriteLine("Не корректный размер");
else SearchElemArrey(matrix, row, col);


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

void SearchElemArrey(int[,] matr, int uRow, int uCol)
{
    if (matr.GetLength(0) >= uRow && matr.GetLength(1) >= uCol) Console.WriteLine($"Элемент с индексами [{uRow},{uCol}] = {matr[uRow - 1, uCol - 1]}");
    else Console.WriteLine("Такого элемента нет");
}

