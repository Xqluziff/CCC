/*
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.



*/

int[,] mas = CreateInitMatrix(5, 4);
PrintMatrix(mas);
Console.WriteLine();
if(mas.GetLength(0) == mas.GetLength(1)) 
{
    ReversMartixBeginEndElem(mas);
    PrintMatrix(mas);

}
else Console.WriteLine("Не корректный размер");






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

void ReversMartixBeginEndElem(int[,] matr)
{
   
    int temp;

    for (int i = 0; i < matr.GetLength(1); i++) //5
    {
        temp = matr[0, i];// 43
        matr[0, i] = matr[matr.GetLength(0) - 1, i]; // 52
        matr[matr.GetLength(0) - 1,i] = temp; // 
    }
}



