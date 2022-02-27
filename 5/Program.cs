// Найти максимальное из трех чисел
int a = 11;
int b = 22;
int c = 14;
int max = a;

if (b > max) max = b;
if (c > max) max = c;
   
System.Console.WriteLine($"Из чисел: {a}, {b} и {c} максимальное: {max}");
