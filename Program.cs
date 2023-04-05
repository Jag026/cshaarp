Random random = new Random();
int current = 0;

do {
    current = random.Next(1, 100);
    Console.WriteLine(current);
} while (current != 7);