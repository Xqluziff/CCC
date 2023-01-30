/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] matrix1 = CreateInitMatrix(3, 4);
int[,] matrix2 = CreateInitMatrix(4, 6);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Такие размеры матриц нельзя переумножать");
else
{
    int[,] multMatrix = MultMatrix(matrix1, matrix2);
    PrintMatrix(multMatrix);
}


int[,] CreateInitMatrix(int uRow, int uCol)
{
    int[,] matr = new int[uRow, uCol];
    var rnd = new Random();

    for (int i = 0; i < uRow; i++)
    {
        for (int j = 0; j < uCol; j++)
        {
            matr[i, j] = rnd.Next(1, 10);
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

int[,] MultMatrix(int[,] mart1, int[,] matr2)
{
    int[,] multMatr = new int[mart1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < mart1.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matr2.GetLength(1); j++) // 2
        {
            for (int k = 0; k < matr2.GetLength(0); k++) // 3
            {
                multMatr[i, j] += mart1[i, k] * matr2[k, j];
            }
        }

    }

    return multMatr;
}



