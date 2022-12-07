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
        // när CurrentHP är mindre än i (45) så kommer delen som saknas färgas röd. 
        {
            if (hp > i)
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
        Console.SetCursorPosition((int)x + 45, (int)y);
        Console.WriteLine($">{hp}/{maxHp}  ");
    }

    public static void MenuLine()
    {
        Console.SetCursorPosition(0, 39);
        for (var i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("-");
        }
    }
}
