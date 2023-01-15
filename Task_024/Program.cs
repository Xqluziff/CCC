/*Напишите программу, которая принимает
 на вход число и выдаёт количество цифр
  в числе. 
  456 -> 3 
  78 -> 2 
  89126 -> 5 
*/

Console.WriteLine("Enter digit");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Count(number));


int Count(int num)
{
    if(num == 0) return 1;
    if (num < 0)  num = -num; 
    
    int count = 0;

    while (num > 0)
    {
        
        num = num / 10;
        count++;
    }
    return count;
}