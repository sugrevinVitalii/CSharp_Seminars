﻿// Показать четные числа от 1 до N

int a = 0;

System.Console.WriteLine("Enter the end number of the sequence ");
string s = string.Empty;
s = Console.ReadLine();
a = Convert.ToInt32(s);

for (int i = 1; i <= a; i++)
{
    if(i%2 == 0) System.Console.Write(i + " ");
}
