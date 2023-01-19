// using System.Media; 
string tutorial = "";
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
Random generator = new Random();
int enemyAttack; 

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

 while (tutorial != "yes" && tutorial != "y" && tutorial != "no" && tutorial != "n")
            {
                Console.WriteLine("View the tutorial? (Y/N)");
                tutorial = Console.ReadLine().ToLower();
                if (tutorial != "yes" && tutorial != "y" && tutorial != "no" && tutorial != "n")
                {
                    Console.WriteLine("\nJust write yes or no.");
                }
            }
if (tutorial == "yes" || tutorial == "y")
{
      player.Tutorial();
}
Console.Clear();

player.PlayerChooseName(); //kalla in klassen först
Console.Clear();


// När man skriver Fighter enemy så skapas en hel ny blank instans av klassen fighter som tar nytta av samma kod
// men variablarna krockar inte med dem från player.
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

Ui.MenuLine();
Ui.AttackLabel();
while (enemy.hp > 0 && player.hp > 0) //enemy hp är 0????

//sätt in en input metod för att välja attacker
{
      Ui.HpBar(5, 10, player.maxHp, player.hp);
      Ui.HpBar(65, 10, enemy.maxHp, enemy.hp);
      

      // lägg till updateDot för spelare och fiende som första saken i funktionen.
      
      if (player.speed > enemy.speed)
      {
            enemy.UpdateDot();
            player.Control();
            player.attacks[player.choice].Affect(player,enemy); //Affect är en funktion som används som grunden till attackerna
            player.confirmAttack = false;
            player.UpdateDot();
            enemyAttack = generator.Next(4);
            enemy.attacks[enemyAttack].Affect(enemy,player);
      }

      else if (player.speed < enemy.speed)
      {
            player.UpdateDot();
            enemyAttack = generator.Next(4);
            enemy.attacks[enemyAttack].Affect(enemy, player);
            enemy.UpdateDot();
            player.Control();
            player.attacks[player.choice].Affect(player, enemy);
            player.confirmAttack = false;
      }

      Console.ReadLine(); // kontroll cr
           
}

Ui.HpBar(5, 10, player.maxHp, player.hp);
Ui.HpBar(65, 10, enemy.maxHp, enemy.hp);
Console.SetCursorPosition((int)(0.45*Console.LargestWindowWidth), (int)Console.LargestWindowHeight/2);
Console.Write("Test of text");
Console.WriteLine(player.hp);
Console.WriteLine(enemy.hp);
Console.ReadLine(); //för att se till om allting funkar

