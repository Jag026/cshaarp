Random dice = new Random();
int current = 0;
int rollCount = 0;
Console.WriteLine("RN || Roll");
do {
    current = dice.Next(2, 12);
    rollCount++;
    Console.WriteLine($"{rollCount}       || ${current}");
} while (current != 7);

Console.WriteLine("Total Rolls:");
Console.WriteLine(rollCount);