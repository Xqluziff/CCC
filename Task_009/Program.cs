/*9. Напишите программу, которая выводит случайное число
 из отрезка [10, 99] и показывает
наибольшую цифру числа. 
78 -> 8
12-> 2 
85 -> 8 */

int num = new Random().Next(10,100);

System.Console.WriteLine($"Случайное число из отрезка 10-99 => {num}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int res = firstDigit > secondDigit ? firstDigit : secondDigit;
    return res;
}
System.Console.WriteLine($"Наибольшая цифра => {MaxDigit(num)}");