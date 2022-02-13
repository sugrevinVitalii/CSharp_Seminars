// Определить четное или не четное число.
void Pause(string message="Press any key")//описание подпрограммы (метода), аналог команды goto
{
    System.Console.WriteLine(message);
    Console.ReadKey(); //Команда останавливает выполнение УП до нажатия любой клавиши
}
int Sum(int a, int b)
{
    return a+b;
}
/* void OddOrEven(int a) // Неудачный метод, т.к. необходимо определить чет/нечет, а выводить его или нет будем определять потом(может в файл записать, может по сети отправить и т.д.).
{
    if (a%2==0) System.Console.WriteLine("Число четное");
    else System.Console.WriteLine("Число не четное");
}
 */
bool OddOrEven(int a)
{
    return a%2==0;//
    //if (a%2==0) return true; else return false; Выше более простой способ написания.
}
//Вот правильный метод, не надо внутри метода выводить.
//Метод должен решить задачу(в данном случае чет/не), а потом можно вывести.
OddOrEven(26);
    if (OddOrEven(26)) System.Console.WriteLine("Число четное");
    else System.Console.WriteLine("Число не четное");

Pause();//вызов. т.е. идет вызов метода (Console.ReadKey();)и его выполнение.
Sum(3,3);
int s=Sum(2,2);

System.Console.WriteLine(Sum(2,2));
System.Console.WriteLine(s);

