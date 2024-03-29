public class Ui
{
    public static void HpBar(float x, float y, int maxHp, int hp)
    // CurrentHP/MaxHP *45 ger hur mycket hp man har kvar i procent
    {
        x = Console.WindowWidth * (x / 100);
        y = Console.WindowHeight * (y / 100);
        Console.SetCursorPosition((int)x, (int)y);
        Console.Write("<");
        for (var i = 0; i < Console.WindowWidth * 0.25; i++) // i är längden på hp bar, den ska fortsätta expandera tills den är 45 pixlar
        // när CurrentHP är mindre än i så kommer delen som saknas färgas röd. 
        {
            if (hp / (float)maxHp > i / (Console.WindowWidth * 0.25))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Write("█");
        }
        Console.ResetColor();
        Console.SetCursorPosition((int)x + (int)(Console.WindowWidth*0.25)+1, (int)y);
        Console.WriteLine($">{hp}/{maxHp}  ");
    }

    public static void MenuLine()
    {
        Console.SetCursorPosition(0, (int)(Console.LargestWindowHeight * 0.9));
        for (var i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("-");
        }
    }
    
    public static void AttackLabel()
    {
        string[] Attacks1 = { "Punch", "Body Slam", "Roll", "Rest" };
        string[] Attacks2 = { "Impale", "Shadowflare", "Octaslash", "Gigaflare" };
        string[] Attacks3 = { "Slam", "Decay", "Bone Barrage", "Mega Blast" };
        string[] Attacks4 = { "Claw", "Fire Breath", "Ravage", "Ground Pound" };
        string[] Attacks5 = { "Flute Slash", "Block", "Chord", "Sound Blast" };
        Array[] Attacks = { Attacks1, Attacks2, Attacks3, Attacks4, Attacks5 };
        string[] AttackName = (string[])Attacks[Fighter.moves-1];
        Console.SetCursorPosition(1, (int)(Console.LargestWindowHeight*0.95));
        Console.Write($"{AttackName[0]}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.25) + 1, (int)(Console.LargestWindowHeight*0.95));
        Console.Write($"{AttackName[1]}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.5) + 1, (int)(Console.LargestWindowHeight*0.95));
        Console.Write($"{AttackName[2]}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.75) + 1, (int)(Console.LargestWindowHeight*0.95));
        Console.Write($"{AttackName[3]}");

    }

    // public static void RestartLabel()
    // {
    //     Console.SetCursorPosition((int)(0.45*Console.LargestWindowWidth), (int)(Console.LargestWindowHeight*0.55));
    //     Console.Write("Play again?");
    //     Console.SetCursorPosition((int)(0.45*Console.LargestWindowWidth), (int)(Console.LargestWindowHeight*0.55)+2);
    //     Console.Write("Yes");
    //     Console.SetCursorPosition((int)(0.45*Console.LargestWindowWidth)+10, (int)(Console.LargestWindowHeight*0.55)+2);
    //     Console.Write("No");
    // }

    public static void AttackInfo()
    {
        
    }

    public static void ClearLine()
    {
        int currentLineCursor = (int)(Console.WindowHeight*0.98);
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }
}
