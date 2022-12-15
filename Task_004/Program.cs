/*7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8*/



System.Console.WriteLine("Введите 3х значное число");

int x = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine( x % 10 );

