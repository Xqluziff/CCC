/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

Console.WriteLine("Введите размер массива");
int sizeMas = Convert.ToInt32(Console.ReadLine());

if (sizeMas > 0)
{
    int[] arrey = CreatMas(sizeMas);
    InitMas(arrey);
    PrintMas(arrey);  
}
else Console.WriteLine("Размер массива не может быть отрицательным или равный 0");

    int[] CreatMas(int size)
    {
        return new int[size];
    }
    void InitMas(int[] arr)
    {
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 100);
        }
    }
    void PrintMas(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1) Console.Write(", ");

        }
        Console.WriteLine("]");
    }



