/*5. Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
Итерация №2
Решение в группах задач: 20 мин

*/

System.Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int count = -x;

while(count<=x)
{

    System.Console.WriteLine(count);
    count++;
}



