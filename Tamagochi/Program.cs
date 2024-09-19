// Weapon axe = new("Axe");


// int damage = axe.Attack();

// Console.WriteLine(damage);

// Console.ReadLine();



Tamagochi tama = new();


Console.WriteLine("Vad ska din tamagochi heta?");
tama.name = Console.ReadLine();

Console.WriteLine($"Du har döpt din Tamagochi till {tama.name}");



while (tama.GetAlive() == true)
{
    tama.PrintStats();
    Console.WriteLine("Vad vill du göra nu?");
    Console.WriteLine($"(1) Lär {tama.name} ett nytt ord");
    Console.WriteLine($"(2) Säg hej till {tama.name}");
    Console.WriteLine($"(3) Mata {tama.name}");
    Console.WriteLine($"(4) Gör ingenting");

    string svar = Console.ReadLine();

    if (svar == "1")
    {
        Console.WriteLine($"Vilket ord vill du lära {tama.name}");
        string word = Console.ReadLine();
        tama.Teach(word);
    }


    else if (svar == "2")
    {
        tama.Hi();
    }

    else if (svar == "3")
    {
        tama.Feed();
    }
    else
    {
        Console.WriteLine($"{tama.name} gör inget");
    }





    tama.Tick();
    Console.WriteLine("Tryck på ENTER för att forsätta");
    Console.ReadLine();
}

Console.WriteLine($"{tama.name} är död :c");

Console.ReadLine();