// using System.Media; 
string tutorial = "";
Fighter player = new Fighter();
Fighter enemy = new Fighter();
int enemyAttack; 


Random generator = new Random();
// int choice = 0;
// bool confirmRestart = false;


Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

// Console.WriteLine(Console.LargestWindowHeight);
// Console.WriteLine(Console.LargestWindowWidth);

Console.WriteLine("Some main and quality of life are missing but the game is working as designed");
Task.Delay(1500).Wait();

Console.WriteLine("USE FULLSCREEN FOR BEST EXPERIENCE! OTHERWISE STUFF WILL BREAK");
Console.WriteLine("NOTE: All characters belong to their respective copyright owners.");
Console.Write("Press enter to start: ");
enemy.BossPrompt();
enemy.BossPromptCheck(enemy.bossPrompt, Fighter.bossesPrompt);
Console.Clear();

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

// Visa en tutorial på hur man kör spelet

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

// välja spelare
// utifrån namnet på spelaren ska den bestämma spelarens attacker och hp

player.PlayerChooseName(); 
Console.Clear();


// När man skriver Fighter enemy så skapas en hel ny blank instans av klassen fighter som tar nytta av samma kod
// men variablarna krockar inte med dem från player.

// samma tanke som med spelaren fast för fienden

if (enemy.bossFight == false)
{
      enemy.Challangername();

      Task.Delay(750).Wait();
      Console.WriteLine("Battle starts in:");
      
}
else 
{
      enemy.Bossname();

}
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

// rita ut UI för spelet
// ha en loop som körs så länge båda spelarna lever och sedan bryter ut när en av de dör
Ui.MenuLine();
Ui.AttackLabel();
player.CombatArtP();
enemy.CombatArtE();
while (enemy.hp > 0 && player.hp > 0) 


{
      Ui.HpBar(5, 10, player.maxHp, player.hp);
      Ui.HpBar(65, 10, enemy.maxHp, enemy.hp);
      

      // Avgör vem som attackerar först
      // Fixa ett sätt för spelaren att välja attack
      // Fienden väljer attack randomly
      
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

      
      
}
// Deklarera vem som vann


Ui.HpBar(5, 10, player.maxHp, player.hp);
Ui.HpBar(65, 10, enemy.maxHp, enemy.hp);
Console.SetCursorPosition((int)(0.45*Console.LargestWindowWidth), (int)Console.LargestWindowHeight/2);
if (player.hp >= 0)
{
      Console.Write($"{player.name} wins!");
      // ClearArea((int)(Console.WindowWidth*0.7), (int)(Console.WindowHeight*0.3), Console.WindowWidth-1, (int)(Console.WindowHeight*0.9)-1);
}
// (int)(Console.WindowHeight*0.3)
else if (enemy.hp >= 0)
{
      Console.Write($"{enemy.name} wins!");
      // ClearArea((int)(Console.WindowWidth*0.1), (int)(Console.WindowHeight*0.3), (int)Console.WindowWidth/2, (int)(Console.WindowHeight*0.9)-1);
}
else 
{
      Console.WriteLine("Draw");
}
      Console.ReadLine(); //för att se till om allting funkar
       
      // Ui.RestartLabel();
      // Restart();




      // void ClearArea(int x, int y, int x2, int y2)
      // {
      //       for(int i = x; i < x2; i++)
      //       {
      //             for(int j = y; j < y2; j++)
      //             {
      //                   Console.SetCursorPosition(x,y);
      //                   Console.Write("ahfhalsk");
                        
      //             }
      //       }
      // }

      // void Restart()
      // {
      //       while (!confirmRestart)
      //   {
      //       if (choice >= 0 && choice <= 10)
      //       {
      //           Console.SetCursorPosition(choice + (int)(Console.WindowWidth * 0.45), (int)(Console.LargestWindowHeight*0.55)+2);
      //           Console.Write(">");
      //       }
      //       var key = Console.ReadKey(true);   //readkey är som readline men reagerar direkt när man trycker istället för bara enter
      //       if (key.Key == ConsoleKey.RightArrow && choice < 10)  //true gör så att man inte ritar det man skriver
      //       {
      //           choice += 10;
      //           Console.SetCursorPosition((choice-10) + (int)(Console.WindowWidth * 0.45), (int)(Console.LargestWindowHeight*0.55)+2);
      //           Console.Write(" ");
      //       }
      //       else if (key.Key == ConsoleKey.LeftArrow && choice > 0)
      //       {
      //           choice -= 10;
      //           Console.SetCursorPosition((choice+10) + (int)(Console.WindowWidth * 0.45), (int)(Console.LargestWindowHeight*0.55)+2);
      //           Console.Write(" ");
      //       }
      //       else if (key.Key == ConsoleKey.Enter)
      //       {
      //           confirmRestart = true;
      //           if (choice == 0)
      //           {
      //             playing = true;
      //             Fighter.page = 0;
      //             Console.Clear();
      //           }
      //           else 
      //           {
      //             playing = false; 
      //           }
      //       }   
      //   }
            
      // }



// Boss fight prompts

// Tagilla = 5%
// Cloud = Chocobo
// Vergil = Motivated
// Doom Guy = Rip and Tear
// Eva-01 = Get in the robot Shinji

