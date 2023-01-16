/*
Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. 
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] CreateInitArrey(int size, int min, int max)
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
        else System.Console.Write(mas[i]);

    }
    Console.Write("]");
}

int GetSumPositivElem(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0) sum += mas[i];

    }
    return sum;
}

int GetSumNegativElem(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < 0) sum += mas[i];

    }
    return sum;
}
int[] arrey = CreateInitArrey(12, -9, 9);
PrintMas(arrey);
int pos = GetSumPositivElem(arrey);
int neg = GetSumNegativElem(arrey);

Console.WriteLine($"\nСумма положительных = {pos}");
Console.WriteLine($"Сумма отрацательных = {neg}");
