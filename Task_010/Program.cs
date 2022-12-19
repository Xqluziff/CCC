/*11. Напишите программу, которая выводит случайное
 трёхзначное число и удаляет вторую цифру этого числа. 
 456 -> 46 
 782 -> 72 
 918 -> 98 */

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

int DeliteSecondDigit(int num)
{
    int first = num / 100;
    int end = num % 10;
    int res = first * 10 + end;
    return res;
}

int res = DeliteSecondDigit(num);
System.Console.WriteLine(res);




