/*
Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/

int[,] mas = CreateInitMatrix(5, 5);
PrintMatrix(mas);
Console.WriteLine();
int[,] arr = ReversMas(mas);
PrintMatrix(arr);


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

int[,] ReversMas(int[,] arr)
{
    int temp;
    int[,] m = new int[5,5];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            m[j,i] = arr[i,j];

        }
    }

return m;
}
