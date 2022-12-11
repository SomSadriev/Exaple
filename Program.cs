
Random random = new Random();
int a = random.Next(0, 40);

if (a < 18)
    {
        Console.WriteLine($"Извените Вам нельзя пройти в клуб, посколкьу Вам нет 18лет, Вам - {a}");
    }
    else
    {
        Console.WriteLine($"Добро пожаловать в клуб, Вам - {a}");
    }


