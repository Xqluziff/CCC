/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.WriteLine("ВВдетите количество строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВдетите количество столбцов в массиве");
int col = Convert.ToInt32(Console.ReadLine());

double[,] matrix = CreateInitDoubleMatrix(row, col);
PrintMatrix(matrix);
double[,] CreateInitDoubleMatrix(int uRow, int uCol)
{
    double[,] matr = new double[uRow, uCol];
    var rnd = new Random();

    for (int i = 0; i < uRow; i++)
    {
        for (int j = 0; j < uCol; j++)
        {          
            matr[i, j] = Math.Round(rnd.NextDouble() * (10-(-10))+(-10) , 1);       
        }
    }

    return matr;
}

void PrintMatrix(double[,] matr)
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