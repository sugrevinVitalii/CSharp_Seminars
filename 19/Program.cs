// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = 0, y = 0;
string s = String.Empty;

System.Console.WriteLine("Введите не нулевое значение Х (X != 0): ");
s = Console.ReadLine();
x = Convert.ToInt32(s);

System.Console.WriteLine("Введите не нулевое значение Y (Y != 0): ");
s = Console.ReadLine();
y = Convert.ToInt32(s);

if(x > 0 && y > 0) System.Console.WriteLine($"Точка (Х={x} Y={y}) - I четверть плоскости.");
if(x > 0 && y < 0) System.Console.WriteLine($"Точка (Х={x} Y={y}) - VI четверть плоскости.");
if(x < 0 && y < 0) System.Console.WriteLine($"Точка (Х={x} Y={y}) - III четверть плоскости.");
if(x < 0 && y > 0) System.Console.WriteLine($"Точка (Х={x} Y={y}) - II четверть плоскости.");
if(x == 0) System.Console.WriteLine("Неверное значение X = 0! ");
if(y == 0) System.Console.WriteLine("Неверное значение Y = 0! ");
