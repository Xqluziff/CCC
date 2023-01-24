/**/

int[,] max = CreateInitArrey(3,4,1,10);
PrintMas(max);


int[,] CreateInitArrey(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
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