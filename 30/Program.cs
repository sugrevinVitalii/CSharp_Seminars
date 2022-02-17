// Показать кубы чисел, заканчивающихся на четную цифру

int[] a={2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
for (int i =0; i<a.Length; i++)
{
    if (a[i]%2 == 0)
    System.Console.WriteLine("{0,10} {1,10}", a[i], Math.Pow(a[i],3));
}
