/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] arr = CreateInitArrey(10);
PrintMas(arr);
int sum = SumElemOddIndex(arr);
Console.WriteLine($"\nСумма нечетных элементов {sum} ");

int[] CreateInitArrey(int size, int min = 1, int max = 10)
{
    int[] mas = new int[size];
    var rnd = new Random();

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(min, max);
    }
    return mas;

}

void PrintMas(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {

        if (i < mas.Length - 1) Console.Write(mas[i] + ", ");
        else Console.Write(mas[i]);

    }
    Console.Write("]");
}

int SumElemOddIndex(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 != 0) sum += mas[i];
    }
    return sum;
}