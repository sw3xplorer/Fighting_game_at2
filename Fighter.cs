using System;

public class Fighter
{
    static List<string> characters = new() { "Jigglypuff", "Sephiroth", "Sans", "Bowser", "Tuba Knight" }; // static gör en lista som varje instans av fighter delar på
    static List<int> Hp = new() { 250, 300, 200, 400, 250 };
    static List<int> Speed = new() { 5, 4, 9, 3, 6 };
    Random generator = new Random();

    public string characterInfo;
    public string name;
    public int opponent;
    public int hp;
    public int maxHp;

    public int speed;
    public string confirmPlayer;
    public int page;

    // DOT damage variablar
    public bool doDot = false;
    public Fighter DotAttacker;
    public int dotTimesLeft;
    public int dotDamage;

    // Multi hit variblar
    public Fighter MultiAttacker;
    public int MultiDamage;
    public int Hits;

    // Crit up variablar

    public Fighter CritUpAttacker;
    public int critBonus;

    // Dmg block 
    public bool blockDmg = false;

    // Stun status

    public bool stun = false;


    public List<Attack> attacks = new();

    public void UpdateDot()
    {
       if (doDot == true)
       {
            dotTimesLeft -= 1;
            hp -= dotDamage;
            if (dotTimesLeft == 0)
            {
                doDot = false;
            }
       }
    }
    public void Tutorial()
    {
        Console.Clear();
        Console.WriteLine(@"________      _____             _____       ______
___  __/___  ___  /________________(_)_____ ___  /
__  /  _  / / /  __/  __ \_  ___/_  /_  __ `/_  / 
_  /   / /_/ // /_ / /_/ /  /   _  / / /_/ /_  /  
/_/    \__,_/ \__/ \____//_/    /_/  \__,_/ /_/   
                                                  ");
        Task.Delay(1000).Wait();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("All characters have 4 different attacks. There are 4 types of attacks:");
        Task.Delay(750).Wait();
        Console.WriteLine("-Basic");
        Console.WriteLine("-Multihit");
        Console.WriteLine("-Status");
        Console.WriteLine("-Special");
        Task.Delay(1000).Wait();
        Console.WriteLine("Basic attacks deal low damage and have a high chance of hitting.");
        Console.WriteLine("Multihit attacks can hit for lower or higher damage than normal attacks but are harder to land.");
        Console.WriteLine("Status attacks apply buffs to you or debuffs to your opponent.");
        Console.WriteLine("Special are utlimate attacks with a low chance of hitting but very high damage.");
        Task.Delay(2000).Wait();
        Console.WriteLine("\nAll attacks except status can land critical hits, which deal 2x damage. Crit chance varies depending on the kind of attack.");
        Task.Delay(1000).Wait();
        Console.WriteLine("\nSpeed determines who attacks first.");
        Task.Delay(1000).Wait();
        Console.WriteLine("Use the arrow keys to select an attack then hit enter to attack.");
        Console.Write("Press enter when done: ");
        Console.ReadLine();


    }
    public void PlayerChooseName()
    {
        while (page == 0)
        {
            Console.WriteLine(@"______________                                                                    ______                            _____             
    __  ____/__  /_________________________     _____  ___________  _________   _________  /_______ _____________ ________  /_____________
    _  /    __  __ \  __ \  __ \_  ___/  _ \    __  / / /  __ \  / / /_  ___/   _  ___/_  __ \  __ `/_  ___/  __ `/  ___/  __/  _ \_  ___/
    / /___  _  / / / /_/ / /_/ /(__  )/  __/    _  /_/ // /_/ / /_/ /_  /       / /__ _  / / / /_/ /_  /   / /_/ // /__ / /_ /  __/  /    
    \____/  /_/ /_/\____/\____//____/ \___/     _\__, / \____/\__,_/ /_/        \___/ /_/ /_/\__,_/ /_/    \__,_/ \___/ \__/ \___//_/     
                                                /____/                                                                                    ");

            Console.WriteLine();
            Console.WriteLine(@"___                   _                                                                    _    
  |    ._   _   /| __ |_   _|_  _    _ |_   _         _ |_   _. ._ _.  _ _|_  _  ._  o ._ _|_ _  
  | \/ |_) (/_   |     _)   |_ (_)  _> | | (_) \/\/  (_ | | (_| | (_| (_  |_ (/_ |   | | | | (_) 
    /  |                                                                                         ");
            Task.Delay(750).Wait();
            Console.WriteLine();
            Console.WriteLine("\n1: Jigglypuff");
            Task.Delay(250).Wait();
            Console.WriteLine("\n2: Sephiroth");
            Task.Delay(250).Wait();
            Console.WriteLine("\n3: Sans");
            Task.Delay(250).Wait();
            Console.WriteLine("\n4: Bowser");
            Task.Delay(250).Wait();
            Console.WriteLine("\n5: Tuba Knight");
            Console.WriteLine();
            Console.Write(">");
            while (characterInfo != "1" && characterInfo != "2" && characterInfo != "3" && characterInfo != "4" && characterInfo != "5")
            {
                characterInfo = Console.ReadLine();
                if (characterInfo != "1" && characterInfo != "2" && characterInfo != "3" && characterInfo != "4" && characterInfo != "5")
                {
                    Console.WriteLine("\nPlease write one of the numbers provided.");
                }

            }
            int.TryParse(characterInfo, out page);
            Console.Clear();
            Task.Delay(750).Wait();
            PlayerArt.Art(page);
            PlayerStats.Stats(page);
            while (confirmPlayer != "yes" && confirmPlayer != "y" && confirmPlayer != "no" && confirmPlayer != "n")
            {
                Console.WriteLine("\nPlay as this character (Y/N)?");
                confirmPlayer = Console.ReadLine().ToLower();
                if (confirmPlayer != "yes" && confirmPlayer != "y" && confirmPlayer != "no" && confirmPlayer != "n")
                {
                    Console.WriteLine("\nJust write yes or no.");
                }
            }
            if (confirmPlayer == "y" || confirmPlayer == "yes")
            {
                name = characters[page - 1];
                SpeedHp();
                AttackNameStats();
                characters.Remove(name); //tar bort namnet som mathcar string name
                //Remove tar bort det som matchar med det man vill ta bort
                Hp.RemoveAt(page - 1); // RemoveAt tar bort objektet på respektive index value
                Speed.RemoveAt(page - 1);
            }
            else if (confirmPlayer == "n" || confirmPlayer == "no")
            {
                confirmPlayer = "";
                characterInfo = "";
                page = 0;
                Console.Clear();
            }
        }
    }


    public void Challangername()
    {
        Console.WriteLine("Selecting opponent:");
        Task.Delay(2000).Wait();
        page = generator.Next(characters.Count); //.count, väljer mellan hur många objekt i listan det finns kvar
                                                 // eftersom vi tog bort karaktären vi valde ur listan kommer vi aldrig få samma motståndare
        Console.Write("Your opponent is: ");
        Task.Delay(1000).Wait();
        Console.WriteLine(characters[page]);

        name = characters[page];

        SpeedHpEnemy();
        AttackNameStats();
    }

    public void AttackNameStats() //inte min ide, Mickes
    {
        if (name == "Jigglypuff")
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Punch", effect = 25 });
            attacks.Add(new Attack() { name = "Body Slam", effect = 40 });
            attacks.Add(new Attack() { name = "Roll", effect = 60 });
            attacks.Add(new Heal() { name = "Rest", effect = 50 });

        }
        else if (name == "Sephiroth")
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Impale", effect = 35 });
            attacks.Add(new DotAttack() { name = "Shadow Flare", effect = 15, dotDuration = 5 });
            attacks.Add(new Multihit() { name = "Octaslash", effect = 10, amount = 8 });
            attacks.Add(new Attack() { name = "Gigaflare", effect = 200 });
        }

        else if (name == "Sans")
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Slam", effect = 25 });
            attacks.Add(new DotAttack() { name = "Decay", effect = 20, dotDuration = 5 });
            attacks.Add(new Multihit() { name = "Bone Barrage", effect = 10, amount = 10 });
            attacks.Add(new Attack() { name = "Mega Blast", effect = 100 });
        }

        else if (name == "Bowser")
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Claw", effect = 40 });
            attacks.Add(new DotAttack() { name = "Fire Breath", effect = 30, dotDuration = 3 });
            attacks.Add(new Multihit() { name = "Ravage", effect = 20, amount = 5 });
            attacks.Add(new Attack() { name = "Ground Pound", effect = 125, stunDuration = 2 }); //och stun för 2 turns
            //läggs till om attacken träffar
        }
        else
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Flute Slash", effect = 30 });
            attacks.Add(new CritUp() { name = "Chord", effect = 2 });
            attacks.Add(new Block() { name = "Block", effect = 0 });
            attacks.Add(new Attack() { name = "Sound Blast", effect = 100 });
        }

    }



    public void SpeedHp()
    {
        maxHp = Hp[page - 1];
        hp = maxHp;
        speed = Speed[page - 1];
    }

    public void SpeedHpEnemy()
    {
        maxHp = Hp[page];
        hp = maxHp;
        speed = Speed[page];
    }


    public Fighter()
    {

    }

}
