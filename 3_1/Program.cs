// Даны два числа. Показать большее и меньшее число.

int a = 0, b = 0;
string s;

System.Console.WriteLine("Введите первое число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Введите второе число ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if (a > b) System.Console.WriteLine("Большее число " + a + ", " + "меньшее число " + b + ".");
if (a == b) System.Console.WriteLine("Оба числа равны.");
if (a < b) System.Console.WriteLine("Большее число " + b + ", " + "меньшее число " + a + ".");
