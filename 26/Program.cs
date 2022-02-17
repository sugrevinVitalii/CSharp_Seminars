// Возведите число А в натуральную степень B используя цикл

int A = 15;
int B = 2;
int result = 1;

for (int i=1; i<=B; i++)
{
    result = result * A;
}
System.Console.WriteLine(result);