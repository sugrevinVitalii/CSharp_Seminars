// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int d = 0;
string s = String.Empty;

System.Console.WriteLine("Введите число дня недели от 1 до 7: ");
s = Console.ReadLine();
d = Convert.ToInt32(s);

if(d == 6 | d ==7) System.Console.WriteLine($"Номер дня недели {d} является выходным");
else System.Console.WriteLine($"Номер дня недели {d} не является выходным");