// Показать числа от -N до N

int a = 0;
int b = 0;
int result = 0;
string s = String.Empty;

System.Console.WriteLine("Enter the initial negative number of the sequence ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Enter the end number of the sequence ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

result = b - a;
int [] array = new int [result+1];
array[0]= a;
array[result] = b;

for (int i = 1; i < array.Length-1; i++)
{
    array[i] = array[i-1] + 1;
}

for (int k = 0; k < array.Length; k++)
{
    System.Console.Write(array[k] + " ");
}