using System;



public class PlayerStats
{
    public static void Stats(int page)
    {
        if (page == 1)
        {
            Console.WriteLine("\nA character with all around stats.");
            Task.Delay(750).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"____________       _____        
    __  ___/_  /______ __  /________
    _____ \_  __/  __ `/  __/_  ___/
    ____/ // /_ / /_/ // /_ _(__  ) 
    /____/ \__/ \__,_/ \__/ /____/  
                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("250 HP");
            Console.WriteLine("\nSpeed: 5");

            Task.Delay(750).Wait();
            Console.WriteLine();
            Console.WriteLine(@"_________________             ______         
    ___    |_  /__  /______ _________  /_________
    __  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
    _  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
    /_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\nPunch: 25 DMG");
            Console.WriteLine("\nBody Slam: 40 DMG");
            Console.WriteLine("\nRoll: 60 DMG");
            Console.WriteLine("\nRest: Restore 40 HP");
            Task.Delay(1000).Wait();
        }


        else if (page == 2)
        {
            Console.WriteLine("\nA fighter with more HP, harder hitting attacks but slower then average");
            Task.Delay(750).Wait();
            Console.WriteLine(@"____________       _____        
    __  ___/_  /______ __  /________
    _____ \_  __/  __ `/  __/_  ___/
    ____/ // /_ / /_/ // /_ _(__  ) 
    /____/ \__/ \__,_/ \__/ /____/  
                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("350 HP");
            Console.WriteLine("\nSpeed: 4");

            Task.Delay(750).Wait();
            Console.WriteLine();
            Console.WriteLine(@"_________________             ______         
    ___    |_  /__  /______ _________  /_________
    __  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
    _  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
    /_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\nImpale: 35 DMG");
            Console.WriteLine("\nShadowflare: Burn for 15 DMG per turn for 5 turns");
            Console.WriteLine("\nOctaslash: 20-80 DMG");
            Console.WriteLine("\nGigaflare: 200 DMG");
            Console.WriteLine("\nPASSIVE: One Winged form");
            Task.Delay(750).Wait();
            Console.WriteLine("When Sephiroth's HP drops below 30%, he gains higher speed and 15 extra DMG");
            Task.Delay(1000).Wait();
        }


        else if (page == 3)
        {
            Console.WriteLine("\nTrades some HP for speed.");
            Task.Delay(750).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"____________       _____        
    __  ___/_  /______ __  /________
    _____ \_  __/  __ `/  __/_  ___/
    ____/ // /_ / /_/ // /_ _(__  ) 
    /____/ \__/ \__,_/ \__/ /____/  
                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("200 HP");
            Console.WriteLine("\nSpeed: 9");

            Task.Delay(750).Wait();
            Console.WriteLine();
            Console.WriteLine(@"_________________             ______         
    ___    |_  /__  /______ _________  /_________
    __  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
    _  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
    /_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\nSlam: 25 DMG");
            Console.WriteLine("\nDecay: Apply decay for 5 turns, dealing 20 DMG per turn");
            Console.WriteLine("\nBone Barrage: 15-70 DMG");
            Console.WriteLine("\nMega Blast: 100 DMG");
            Task.Delay(1000).Wait();
        }


        else if (page == 4)
        {
            Console.WriteLine("\nTank with high damage output but slow speed");
            Task.Delay(750).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"____________       _____        
    __  ___/_  /______ __  /________
    _____ \_  __/  __ `/  __/_  ___/
    ____/ // /_ / /_/ // /_ _(__  ) 
    /____/ \__/ \__,_/ \__/ /____/  
                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("400 HP");
            Console.WriteLine("\nSpeed: 3");

            Task.Delay(750).Wait();
            Console.WriteLine();
            Console.WriteLine(@"_________________             ______         
    ___    |_  /__  /______ _________  /_________
    __  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
    _  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
    /_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                                ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\nClaw: 40 DMG");
            Console.WriteLine("\nFire Breath: Apply bruning for 3 turns dealing 30 DMG per turn");
            Console.WriteLine("\nRavage: 20-100 DMG");
            Console.WriteLine("\nGround Pound: 125 DMG, stuns the opponent for 2 turns");
            Task.Delay(1000).Wait();
        }


        else
        {
            Console.WriteLine("\nDefensive character that can block attacks");
            Task.Delay(750).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"____________       _____        
__  ___/_  /______ __  /________
_____ \_  __/  __ `/  __/_  ___/
____/ // /_ / /_/ // /_ _(__  ) 
/____/ \__/ \__,_/ \__/ /____/  
                              ");
            Task.Delay(1000).Wait();
            Console.WriteLine("250 HP");
            Console.WriteLine("\nSpeed: 6");

            Task.Delay(750).Wait();
            Console.WriteLine();
            Console.WriteLine(@"_________________             ______         
___    |_  /__  /______ _________  /_________
__  /| |  __/  __/  __ `/  ___/_  //_/_  ___/
_  ___ / /_ / /_ / /_/ // /__ _  ,<  _(__  ) 
/_/  |_\__/ \__/ \__,_/ \___/ /_/|_| /____/  
                                            ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\nFlute Slash: 30 DMG");
            Console.WriteLine("\nChord: Increase crit chance");
            Console.WriteLine("\nBlock: Raise the Tuba Shield to block an incoming attack.");
            Console.WriteLine("\nSound Blast: Unleash a powerful blast, dealing 100 DMG");
            Task.Delay(1000).Wait();
        }
    }



   
}
