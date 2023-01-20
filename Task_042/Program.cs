/*
Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.
*/
int[] arr =CreateInitArrey(10,1,10);
PrintMas(arr);
System.Console.WriteLine();
int[] newArr = CopyMas(arr);
PrintMas(newArr);


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

int[] CopyMas(int[] mas)
{
    int[]tempMas = new int[mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        tempMas[i]=mas[i];
    }
    return tempMas;
}