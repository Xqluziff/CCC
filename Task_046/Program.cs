/*
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] max = CreateInitMatrix(3,4);
PrintMas(max);


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