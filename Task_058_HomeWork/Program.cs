/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(00,,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/
Console.WriteLine("Задайте размеры 3х значного массива");
Console.Write("Введите кол. страниц: ");
int page = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол. строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол. столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

if (page * row * col > 99) Console.WriteLine($"Размер массива {page * row * col} превышает диапазон уникальных значений от 10 до 99");
else if (page <= 0 || row <= 0 || col <= 0) Console.WriteLine("Массив не может имень отрицательный или 0 размер ");
else
{
    int[,,] martix3d = CreateInitMatrix3d(page, row, col);
    PrintMatrix3d(martix3d);
}


int[,,] CreateInitMatrix3d(int uPage, int uRow, int uCol)
{
    int[,,] matr = new int[uPage, uRow, uCol];
    int elem = 10;

    for (int i = 0; i < uPage; i++)
    {
        for (int j = 0; j < uRow; j++)
        {
            for (int k = 0; k < uCol; k++)
            {
                matr[i, j, k] = elem;
                elem++;
            }

        }
    }

    return matr;
}

void PrintMatrix3d(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k],5}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
