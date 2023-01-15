/*

Напишите программу, которая // выводит массив из 8 элементов,
 заполненный // нулями и единицами в случайном порядке. // 
 [1,0,1,1,0,1,0,0] 
*/

Console.WriteLine("Enter size arrey");
int number = Convert.ToInt32(Console.ReadLine());

int[]  mas = new int [number];
InitMas(mas);
Print(mas);

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " | ");       
    }
}

void InitMas(int[]arr)
{   
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }   
}