// По заданному номеру дня недели вывести его название.

void DayOfTheWeek(int a)
{
    if(a==1) Console.WriteLine("It`s monday.");
    if(a==2) Console.WriteLine("It`s tuesday.");
    if(a==3) Console.WriteLine("It`s wednesday.");
    if(a==4) Console.WriteLine("It`s thursday.");
    if(a==5) Console.WriteLine("It`s friday.");
    if(a==6) Console.WriteLine("It`s saturday.");
    if(a==7) Console.WriteLine("It`s sunday.");
}

int b=0;
string s;
bool c = true;

Console.Write("Enter the number of the day of the week: ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

while(c == true)
{
    if (b > 0 && b < 8)
    {
        DayOfTheWeek(b);
        c = false;
    }
    else
    {
        Console.WriteLine("The entered number does not match the number of the day of the week.");
        return;
    }
}
