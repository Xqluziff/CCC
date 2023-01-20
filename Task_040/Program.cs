/*
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

string str = Binar(55);
str = ReversBinar(str);
Console.WriteLine(str);

string Binar(int num)
{
    string binar = string.Empty;
    while (num != 0)
    {
        if (num % 2 == 0)
        {
            binar += "0";
            num = num / 2;
        }
        else
        {
            binar += "1";
            num = num / 2;
        }
    }
    return binar;
}
string ReversBinar(string s)
{
    string temp = string.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        temp += s[s.Length - 1 - i];
    }
    return temp;
}