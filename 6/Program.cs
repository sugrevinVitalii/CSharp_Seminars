// 
void Pause(string message="Press any key")//описание подпрограммы (метода), аналог команды goto
{
    System.Console.WriteLine(message);
    Console.ReadKey(); //Команда останавливает выполнение УП до нажатия любой клавиши
}


Pause();//вызов. т.е. идет вызов метода (Console.ReadKey();)и его выполнение.
