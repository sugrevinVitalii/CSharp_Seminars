// Написать программу замены элементов массива на противоположные.

int N=10;
int[] array=new int[N];

void Input(int[] arr) //Создание рандомного массива
{
    Random random=new Random();//Создали объект класса Random и назвали его ransom
    for(int i=0; i<arr.Length; i++)
        arr[i]=random.Next(1,100);
}
void Solve(int[] arr)//Обработка данных
{
    for(int i=0;i<arr.Length;i++)
        arr[i]=-arr[i];
}

void Print(int[] arr) //Вывод результата.
{
    for(int i=0; i<arr.Length; i++)
        System.Console.Write($"{arr[i]} ");
}

Input(array);
Print(array);
Solve(array);
System.Console.WriteLine();
Print(array);