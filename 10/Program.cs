// Показать последнюю цифру трёхзначного числа

int a = 0;
string s = string.Empty;

System.Console.Write("Введите трехзначное число ");
s = Console.ReadLine();
a = s.Length;

switch (a)
{
    case 3:
        Console.WriteLine("Последняя цифра трехзначного числа " + s[s.Length - 1]);
        break;
    default:
        Console.WriteLine("Число не является трехзначным");
        break;
}
