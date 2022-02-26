// Найти максимальное из трех чисел
int a = 11;
int b = 22;
int c = 14;
int max = a;

if (a >= max) max = a;
if (b >= max) max = b;
if (c >= max) max = c;
   
System.Console.WriteLine($"Максимальное число:{max}");
