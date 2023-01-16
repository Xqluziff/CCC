/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов.
 В своём решении сделайте для 123 
 [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5 
 

*/

int[] arrey = CreateInitArrey(20, 1, 123);
PrintMas(arrey);
int count = SearchCountElem(arrey,10,99);
Console.WriteLine();
Console.WriteLine($"Количество элементов {count}");

int SearchCountElem(int[] mas,int min,int max)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] >= min && mas[i] <= max) count++;
    }
    return count;

}

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

