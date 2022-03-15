// По двум заданным числам проверять является ли одно квадратом другого
double a = 0, b = 0;
string s;

System.Console.WriteLine("Введите число A: ");
s = Console.ReadLine();
a = Convert.ToDouble(s);

System.Console.WriteLine("Введите число B: ");
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a == Math.Pow(b,2)) System.Console.WriteLine($"Число А= {a} является квадратом числа В= {b}.");
if (b == Math.Pow(a,2)) System.Console.WriteLine($"Число В= {b} является квадратом числа А= {a}.");
if (a != Math.Pow(b,2) && b != Math.Pow(a,2)) System.Console.WriteLine("Числа А и В не являются квадратом друг друга...");
