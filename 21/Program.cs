// Программа проверяет пятизначное число на палиндром

int a = 0;
string s = string.Empty;

System.Console.Write("Введите положительное пятизначное число: ");
s = Console.ReadLine();
a = s.Length;
//s=Math.Abs(s);

if(a == 5)
{
    int [] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        array[i] = Convert.ToInt32(s[i]);
    }
    if(array[0] == array[4] && array[1] == array[3])
    {
        System.Console.WriteLine($"Введенное число {s} является полиндромом.");
    }
    else System.Console.WriteLine($"Введенное число {s} не является полиндромом.");
}
else System.Console.WriteLine($"Число {s} не является пятизначным или положительным.");