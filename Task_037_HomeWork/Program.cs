/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

double[] arr = CreateInitArrey(10);
PrintMas(arr);
double minElem = MinElem(arr);
double maxElem = MaxElem(arr);
double result = DifferenceMinMax(minElem,maxElem);
Console.WriteLine($"\nМинимальный {minElem}");
Console.WriteLine($"Максимальный {maxElem}");
Console.WriteLine($"Разница {result}");


double[] CreateInitArrey(int size, double min = 1, double max = 10)
{
    double[] mas = new double[size];
    var rnd = new Random();

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);

    }
    return mas;

}

void PrintMas(double[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {

        if (i < mas.Length - 1) Console.Write(mas[i] + " | ");
        else Console.Write(mas[i]);

    }
    Console.Write("]");
}

double MinElem(double[] mas)
{
    double min = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] < min) min = mas[i];
    }
    return min;
}

double MaxElem(double[] mas)
{
    double max = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] > max) max = mas[i];
    }
    return max;
}

double DifferenceMinMax(double min,double max)
{
   return Math.Round(max - min,1);

}
