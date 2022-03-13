// Дано число. Проверить кратно ли оно 7 и 23

int a = 0;
string s = string.Empty;

System.Console.Write("Введите целое число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if(a%7 == 0 && a%23 == 0) System.Console.WriteLine($"Введенное число {a} кратно 7 и 23.");
else
{
    if(a%7 == 0) System.Console.WriteLine($"Введенное число {a} кратно 7.");
    if(a%23 == 0) System.Console.WriteLine($"Введенное число {a} кратно 23.");
}
if(a%7 !=0 && a%23 !=0) System.Console.WriteLine($"Введенно число {a} не кратно ни 7, ни 23.");