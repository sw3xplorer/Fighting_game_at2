// using System.Media; 

Fighter player = new Fighter();
Fighter enemy = new Fighter();

Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

Console.WriteLine(Console.LargestWindowHeight);
Console.WriteLine(Console.LargestWindowWidth);

Console.WriteLine("USE FULLSCREEN FOR BEST EXPERIENCE! OTHERWISE STUFF WILL BREAK");
Console.WriteLine("NOTE: All characters belong to their respective copyright owners.");
Console.Write("Press enter to start: ");
Console.ReadLine();
Console.Clear();
Random Generator = new Random();

Console.WriteLine(@"_____________            _______                           
___  __/__  /______      ___    |________________________ _
__  /  __  __ \  _ \     __  /| |_  ___/  _ \_  __ \  __ `/
_  /   _  / / /  __/     _  ___ |  /   /  __/  / / / /_/ / 
/_/    /_/ /_/\___/      /_/  |_/_/    \___//_/ /_/\__,_/  
                                                           ");
Task.Delay(500).Wait();
Console.WriteLine();
Console.WriteLine(@"_____________________________________
__  ___/__  __/__    |__  __ \__  __/
_____ \__  /  __  /| |_  /_/ /_  /   
____/ /_  /   _  ___ |  _, _/_  /    
/____/ /_/    /_/  |_/_/ |_| /_/     
                                     ");
Console.WriteLine(@"                   
 __  __  __  __  \ 
                 / 
                   ");
Console.ReadLine();
Console.Clear();

Task.Delay(1000).Wait();

player.PlayerChooseName(); //kalla in klassen först
Console.Clear();

player.attacks[0].Affect(player, enemy);


enemy.Challangername();

Task.Delay(750).Wait();
Console.WriteLine("Battle starts in:");
Task.Delay(1500).Wait();
Console.WriteLine(@"________
__|__  /
___/_ < 
____/ / 
/____/  
        ");
Task.Delay(1000).Wait();
Console.WriteLine(@"______ 
__|__ \
____/ /
_  __/ 
/____/ 
       ");
Task.Delay(1000).Wait();
Console.WriteLine(@"______
__<  /
__  / 
_  /  
/_/   
      ");
Task.Delay(1000).Wait();
Console.Clear();



Console.ReadLine(); //för att se till om allting funkar
