// Определить количество цифр в числе
int n= 35325823;
int c = 0;
int n1 = n;
while(n!=0)
{
    n=n/10;
    c++;
}
System.Console.WriteLine("{0,8} {1,8}", n1, c);
