
/*Напишите программу, которая принимает на вход число (А)
 и выдаёт сумму чисел от 1 до А.
  7 -> 28
   4 -> 10
    8 -> 36 */



System.Console.WriteLine("Enter digit");
int number = Convert.ToInt32(Console.ReadLine());

int sum(int num)
{
    int sum=0;
    for (int i = 1; i <= num; i++)
    {
        sum+=i;
    }

    return sum;
}


Console.WriteLine(sum(number));
