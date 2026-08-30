uint n; // number of blocks
uint k; // number of towers
Console.Clear(); // Clear screen
Console.WriteLine("Enter the number of blocks");
UInt32.TryParse(Console.ReadLine(),out n);
Console.WriteLine("Enter the number of towers");
UInt32.TryParse(Console.ReadLine(), out k);
uint t = n / k; // Maximum number of towers
uint b = t * k; // Number of blocks
Console.WriteLine($"From {n} blocks, you can build a maximum of {t} towers");
Console.WriteLine($"This will take {b} blocks.");
Console.Read(); // Delay output until key "Enter" not pressed