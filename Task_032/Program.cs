/*
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве. 4; 
массив [6, 7, 19, 345, 3] -> нет 3;
 массив [6, 7, 19, 345, 3] -> да 
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrey = CreateInitArrey(20, 1, 99);
PrintMas(arrey);
bool res = FindElem(arrey, number);

Console.WriteLine();
Console.WriteLine(res);


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

bool FindElem(int[] mas, int num)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == num) return true;
    }
    return false;
}