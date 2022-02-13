// Дана строка текста, надо ее перевернуть.

string s=Console.ReadLine();
string s1 = String.Empty;

for (int i = s.Length-1; i>=0; i--)
{
    s1=s1+s[i];//склеивание или конкатинация строк.
    //System.Console.Write(s[i]);
}
System.Console.WriteLine(s1);
