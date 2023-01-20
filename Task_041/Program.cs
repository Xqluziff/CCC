/*
Фибоначи
*/

Console.WriteLine("1 число");
int digit = Convert.ToInt32(Console.ReadLine());

int[] arr = Febonacci(digit);
PrintMas(arr);

int[] Febonacci(int dig)
{
    int[] mas = new int[dig];
    mas[1] = 1;
   
    for (int i = 2; i < mas.Length; i++)
    {
        mas[i] = mas[i - 2] + mas[i - 1];
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

