
Random random = new Random();
int a = random.Next(0, 100);

    if (a < 18)
    {
        Console.WriteLine($"Извените Вам нельзя пройти в клуб, посколкьу Вам нет 18лет, Вам - {a}");
    }
    if (18 < a && a < 40)
    {
        Console.WriteLine($"Добро пожаловать в клуб, Вам - {a}");
    }
    else
    {
        Console.WriteLine($"мдэээ, Вам {a} лет");
    }

