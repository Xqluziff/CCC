/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] arrey = CreateInitArrey(20);
PrintMas(arrey);
int count = CountHonestElemArrey(arrey);
Console.WriteLine();
Console.WriteLine($"Количество четных элементов в массиве {count}");

int[] CreateInitArrey(int size, int min = 100, int max = 1000)
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

int CountHonestElemArrey(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0) count++;
    }
    return count;
}
