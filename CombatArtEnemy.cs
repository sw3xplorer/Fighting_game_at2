using System;


public class CombatArtEnemy
{
    public static void CombatArtE(int page)
    {
        string name = Fighter.characters[page];
        int currRow = (int)(Console.WindowHeight*0.3);  
        if (name == "Jigglypuff")
        {
            var rows = @"                                       
           &&&&                        
          &,,,,,&&  &&&                
          &,,,%&&@&@@@@@&%@            
          &@@@@@&@@&@@@@&%%%           
        @@@@@@@&@@@@@@&&&%&%%%&&&@@@&  
       @***@/@&%&&&&&&&%%%%%%%%,,,,,,&&
      &@(/**@&&&&%%%%%%%&&&&%%%%,,,&%  
  && &&&&&&&&&&&&&&@*,*@/@&&%%%%&%%    
  &&%%&&&&&&&&&&&&@//*,,,,@%%%%%       
    %%%@&%%%&&&&&&&@(%((*@%%%%%        
      %%%%%%%%%%%%%%%%%%%%%%%&         
          %%&@&%###&&@@@@&%&           
               %%%%%%%%%%%             
                  ###%       ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.5);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }

        else if (name == "Sephiroth")
        {
            var rows = @"                                             
              ,                          #   
           *, .,                             
         . ,.  ,     ,*(*%#             %    
       ...  .  .     (*&#(*/(                
     * .,. .    . ../#* / *#&&%        (     
    ,,,..          % .,&//,.% /%*(##  @      
   **...             ... . .  (/*(##/##/     
   , ..            ,. ...  .,, ..,//,(##(    
  * . , .          ,....,.. /*,,*.(.(((./#%# 
  *. .  .         . .,...,.. /  ,,.,#(  *(% /
  *,,....         .*.   . *.   .*/    %  (% %
  **....... .,     * .   ..,,   **       *   
  **,..  ..       ,  . *  .  , .,            
  ,/ ,,...        ,       ..  .*,,*,         
  *%.,  *         , ..  .. . .. .**,,*,      
 , ,**,,          .  ,      ..    .,*,,      
   */,            ..       ., ..    .,,      
  /               .        ..                
                   ,    .. .                 
                       ,, **                 
                     ,*   ..                 
                         ...                 ".Split("\n");
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }

        else if (name == "Sans")
        {
            var rows = @"                                       
            @@@@@@@@@@@@@@@@           
          @@@@@@@@@@@@@@@@@@@@         
         @@@@    @@@@@@    @@@@        
         @%   @&  @@@@  @@   @@        
          .@@@@@@@/  @@*@@@@@          
          @@@ @@@@@@@@@@@@. @@         
          ,@@@  @ @ @@ @  @@@  @@      
      @@@@%  (@@@@@@@@@@@@. /@@. &     
     &       @@  @@@@@    @@(  &   @   
        &    ( .       *@      .    @@ 
 &@     &@#,,,% % @@@ @.@ %%#, .     ,#
  @     .     @ @ @@@ @ @ .    &      #
    (@  .      &@ ((/ @#/      @   //  
        &@@@@@@               @.       
            @            @@   @        
         & @*      &@    @@    @       
        @ @@      @& @   @@#    (      
        @ @@      @  @    @#    (      
                        .              
      @@@@@@*@@         @@@@ @@@@@@@   ".Split("\n");
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }
        
        else if (name == "Bowser")
        {
            var rows = @"                        /.       .           
              **/*      ////  **,,           
         ,  /(//((///. &##%/   ##/           
          (/(//((#(//%%(****/**.  ((*,.,.    
           ,#(#../,....%((#%***.....#%       
         ,/,,.,....*/,,,/,...*%(/*...*/.     
         */((//(//&@(,&##/(/,...&%#(,..((    
 /##////(&%&(/&%#(/,. ,*////((/,/&*%(,.      
 *.#/////(###/**,,.,/////((((*,,....&/*.    .
    ,/,/(/&%/((  /##/////(((*,,,.....,.  ,...
               /((((((***///**,,....,*,,..., 
                */(((((/  *////*,,,.../**/   
               **/(#((((     ///,,.. .       
                *///((*      /./.., ...      ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.5);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }

        else
        {
            var rows = @"           ,      ( / ,(               
           ,     %*.,(,%               
          *      ,./.*,%               
         ,      #*.*.*./%%%####%       
         /       (*#&/*.*(####(*.      
        /       ###(#/#.*.     .       
       (/     .(##(*,../(* ,  @%       
      ,*/,    /#/#/* .#*///.@&&(,      
                (/(/(*%/@%%@@#/(@(     
                .**,@.,&/,*%*(#&       
               ,,//%%%,&%&&%  #*       
                #%%,%%&#&@(,(,. /*,    
                 @@#&/#@/&%@@&*#  #(   
                &@@@@@##,#@,%*   ##%   
                @@@@@   @##.( **(%     
                @@@@@   @@@@@          ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.45);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }
    }
}
