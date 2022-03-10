// Удалить вторую цифру трёхзначного числа

int a = 597;

int temp = a%10;
a = (a/100) * 10 + temp;
System.Console.WriteLine(a);

