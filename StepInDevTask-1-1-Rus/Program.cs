uint n; // количество блоков
uint k; // количество башен
Console.Clear(); // Очистка экрана
Console.WriteLine("Введите количество блоков");
UInt32.TryParse(Console.ReadLine(), out n);
Console.WriteLine("Введите количество блоков на башню");
UInt32.TryParse(Console.ReadLine(), out k);
uint t = n / k; // Максимальное количество башен
uint b = t * k; // Количесво блоков
Console.WriteLine($"Из {n} блоков можно построить максимум {t} башен(ни)");
Console.WriteLine($"На это уйдёт {b} блоков.");
Console.Read(); // Задержка вывода до нажатия клавиши "Ввод"