/*
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные,
 и наоборот. 
 [-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] arrey = CreateInitArrey(12, -9, 9);
PrintMas(arrey);

ReversMas(arrey);
Console.WriteLine();
PrintMas(arrey);


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

void ReversMas(int[] mas)
{

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = -mas[i];
    }
    
}