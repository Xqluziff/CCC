/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3 
[6 7 3 6] -> 36 21 
*/

int[] arrey = CreateInitArrey(5, 1, 123);
PrintMas(arrey);
int[] arr2 = MultElemMas(arrey);
PrintMas(arr2);


int[] MultElemMas(int[] mas)
{
    int size = 0;

    if (mas.Length % 2 == 0) size = mas.Length / 2;
    else size = mas.Length / 2 + 1;//3

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = mas[i] * mas[mas.Length - 1 - i];
    }
    if (mas.Length % 2 != 0) arr[arr.Length - 1] = mas[size - 1];

    return arr;

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


