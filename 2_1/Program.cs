﻿//По двум заданным числам проверять является ли первое квадратом второго

double a = 0, b = 0;
string s;

Console.WriteLine("Введите первое число ");
s = Console.ReadLine();
a = Convert.ToDouble(s);

Console.WriteLine("Введите второе число ");
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a == Math.Pow(b,2))
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
