// ввести два числа с клавиатуры.

int a,b;//Глобальные переменные

void Input(out int x, out int y)
{
    x=int.Parse(Console.ReadLine());
    y=int.Parse(Console.ReadLine());
}

Input(out a, out b);
