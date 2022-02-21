// Определить, присутствует ли в заданном массиве, некоторое число.

int [] arr={22, 33,44,55,66,77,88};
int InputN()
{
    string s;
    System.Console.WriteLine(" Enter a number to search");
    s=Console.ReadLine();
    return Convert.ToInt32(s);
}
int n=InputN ();
bool flag = false;
int i;
for (i=0; i<arr.Length; i++)
{
    if (arr[i]==n)
    {
        flag=true;
        break;
    }
}
if(flag==true)
    System.Console.WriteLine(" The entered number is present in the array {0}, Serial number {1} ", n, i);
else 
    System.Console.WriteLine( " the entered number is not in the array ");