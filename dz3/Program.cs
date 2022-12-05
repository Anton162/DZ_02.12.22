Console.WriteLine("Введите номер дня недель (1-7)");
int n = int.Parse(Console.ReadLine()!);

if (n > 0 && n < 8) {
    if (n == 6 || n == 7) 
    {
        Console.WriteLine("ВЫХ");
    } else {
        Console.WriteLine("Буд");
    }
} else {
    Console.WriteLine("Ввели неверное число");
}
