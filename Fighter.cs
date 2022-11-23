using System;

public class Fighter
{
    static List<string> characters = new() { "Jigglypuff", "Sephiroth", "Sans", "Bowser", "Tuba Knight" }; // static gör en lista som varje instans av fighter delar på

    Random generator = new Random();

    public string characterInfo;
    public string name;
    public int hp;
    public string confirmPlayer;
    public int page = 0;

// DOT damage variablar
    public bool doDot = false;
    public Fighter DotAttacker;
    public int dotTimesLeft;
    public int DotDamage;

// Multi hit variblar
    public Fighter MultiAttacker;
    public int MultiDamage;
    public int Hits;

// Crit up variablar

    public Fighter CritUpAttacker;
    public int critBonus;


    public List<Attack> attacks = new();

    public void UpdateDot()
    {

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



                AttackNames();
                AttackStats();
                SpeedHp();
                characters.Remove(name); //tar bort namnet som ligger på name index value
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
        int opponent = generator.Next(characters.Count); //.count, väljer mellan hur många objekt i listan det finns kvar
        //eftersom vi tog bort karaktären vi valde ur listan kommer vi aldrig få samma motståndare

        Console.Write("Your opponent is: ");
        Task.Delay(1000).Wait();
        Console.WriteLine(characters[opponent]);
    }

    public void AttackNames() //inte min ide, Mickes
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
            attacks.Add(new Multihit() { name = "Octaslash", effect = 10, amount = 8  });
            //unik attak: "Multihit": DMG varierar mellan 20-90
            attacks.Add(new Attack() { name = "Gigaflare", effect = 200 });
        }

        else if (name == "Sans")
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Slam", effect = 25 });
            attacks.Add(new Attack() { name = "Decay", effect = 20, dotDuration = 5 });
            attacks.Add(new Attack() { name = "Bone Barrage", effect = 10, amount = 10 }); 
            attacks.Add(new Attack() { name = "Mega Blast", effect = 100 });
        }

        else if (name == "Bowser")
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Claw", effect = 40 });
            attacks.Add(new Attack() { name = "Fire Breath", effect = 30, dotDuration = 3 }); 
            attacks.Add(new Attack() { name = "Ravage", effect = 20, amount = 5 });
            attacks.Add(new Attack() { name = "Ground Pound", effect = 125 }); //och stun för 2 turns
            //läggs till om attacken träffar
        }
        else
        {
            attacks.Clear();
            attacks.Add(new Attack() { name = "Flute Slash", effect = 30 });
            attacks.Add(new Attack() { name = "Chord", effect = 2});
            attacks.Add(new Attack() { name = "Block", effect = 0 });
            attacks.Add(new Attack() { name = "Sound Blast", effect = 100 });
        }

        // foreach (Attack a in attacks)
        // {
        //     Console.WriteLine(a.name);
        // }

        List<string> AttacksPuff = new() { "Punch", "Body Slam", "Roll", "Rest" };
        List<string> AttacksSeph = new() { "Impale", "Shadowflare", "Octaslash", "Gigaflare" };
        List<string> AttacksSans = new() { "Slam", "Decay", "Bone Barrage", "Mega Blast" };
        List<string> AttacksBowser = new() { "Claw", "Fire Breath", "Ravage", "Ground Pound" };
        List<string> AttacksTuba = new() { "Flute Slash", "Chord", "Block", "Sound Blast" };
        List<List<string>> Attacks = new() { AttacksPuff, AttacksSeph, AttacksSans, AttacksBowser, AttacksTuba };
        //En lista av listor, för att hålla reda på alla namn
        //Avgörs beroende på vilken karaktär man väljerd

        List<string> CurrentAttacks = Attacks[page - 1];
        // foreach(string attack in CurrentAttacks) Kod för att kontrollera om den väljer rätt namn
        // {
        //     Console.WriteLine(attack);
        // }
        // Console.ReadLine();

        string AtkLabel1 = CurrentAttacks[0];
        string AtkLabel2 = CurrentAttacks[1];
        string AtkLabel3 = CurrentAttacks[2];
        string AtkLabel4 = CurrentAttacks[3];


    }

    public void AttackStats()
    {
        List<int> AtkDmgPuff = new() { 25, 40, 60, 0 };
        List<int> AtkDmgSeph = new() { 35, 0, 0, 200 };
        List<int> AtkDmgSans = new() { 25, 0, 0, 80 };
        List<int> AtkDmgBowser = new() { 40, 20, 0, 125 };
        List<int> AtkDmgTuba = new() { 30, 0, 0, 100 };
        List<List<int>> AtkStats = new() { AtkDmgPuff, AtkDmgSeph, AtkDmgSans, AtkDmgBowser, AtkDmgTuba };

        List<int> CurrAtkStats = AtkStats[page - 1];

        int PlayerAtkStat1 = CurrAtkStats[0];
        int PlayerAtkStat2 = CurrAtkStats[1];
        int PlayerAtkStat3 = CurrAtkStats[2];
        int PlayerAtkStat4 = CurrAtkStats[3];
    }

    public void SpeedHp()
    {
        List<int> Hp = new() { 250, 300, 200, 400, 250 };
        List<int> Speed = new() { 5, 4, 9, 3, 6 };
        int PlayerHp = Hp[page - 1];
        int PlayerSpeed = Speed[page - 1];
    }
    public Fighter()
    {

    }

}
