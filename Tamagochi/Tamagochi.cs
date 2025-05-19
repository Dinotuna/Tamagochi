// public class Weapon
// {
//     public string Name;
//     public int MinDamage;
//     public int MaxDamage;

//     public Weapon(string name)
//     {
//         Name = name;
//         MinDamage = Random.Shared.Next(8, 12);
//         MaxDamage = Random.Shared.Next(18,25);
//     }

//     public int Attack()
//     {
//         Console.WriteLine($"Attacking with {Name}");
//         return Random.Shared.Next(MinDamage, MaxDamage);
//     }
// }


public class Tamagochi
{
    private int hunger;
    private int boredom;
    private bool isAlive = true;
    private List<string> words = new List<string>() {"Hej"};
    public string name;
    private int gamble;
    

    public void Feed()
    {
        Console.WriteLine($"Du matar {name} och {name} blir mindre hungrig");
        hunger -= Random.Shared.Next(3);

        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Gamble()
    {
        gamble = Random.Shared.Next(2);

        if (gamble == 0)
        {
            hunger -= 2;
            Console.WriteLine($"Bra val du har matat {name}");
        }

        else
        {
            hunger +=2;
            Console.WriteLine($"Dåligt val! {name} är nu hungrigare");
        }
    }

    public void Hi()
    {
        int wordNum = Random.Shared.Next(words.Count);
        Console.WriteLine($"{name} säger {words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($"{name} lärde sig ordet {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger += Random.Shared.Next(3);
        boredom++;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Hunger = {hunger} Boredom = {boredom}");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        Console.WriteLine($"{name} är nu mindre uttråkad");

        boredom -= 2;

        if (boredom < 0)
        {
            boredom = 0;
        }
    }   




}