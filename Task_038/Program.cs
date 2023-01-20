/**/

int[] arrey = CreateInitArrey(5);
PrintMas(arrey);
ReverseArrayVersion2(arrey);
Console.WriteLine();
PrintMas(arrey);
//Array.Reverse(arrey);
//Console.WriteLine();
//PrintMas(arrey);


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

void ReverceArray(int[] mas)
{
    for (int i = 0; i < mas.Length / 2; i++)
    {
        int temp = mas[i];
        mas[i] = mas[mas.Length - 1 - i];
        mas[mas.Length - 1 - i] = temp;
    }
}

void ReverseArrayVersion2(int[] array)
{
    int index1 = 0;
    int index2 = array.Length - 1;

    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;
        index1++;
        index2--;
    }
}