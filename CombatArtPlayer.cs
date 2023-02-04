using System;

public class CombatArtPlayer
{
    public static void CombatArt(string name)
    {
        int currRow = (int)(Console.WindowHeight*0.4);
        if (name == "Jigglypuff")
        {
            var rows = @"                                       
                         &&&&          
                .&&&  &&,,,,,&         
             @%&@@@@@&@&&%,,*&         
            %%%&@@@&&@@&@@@@@&         
   &@@@&&&%%%&%&&&@@@@@@&@@@@@@&       
 &&,,,,,,%%%%%%%&&&&&&&&%&@/@***@      
   %&,,,%%%%&&&&%%%%%%%&&&&@**/(@&     
     %%&%%%%&&@/@*,*@&&&&&&&&&&&&&& && 
        %%%%%@,,,,*//@&&&&&%&&&&&&%&&& 
         %%%%%@*((%(@%&&&&&&%%%&@%%%   
          &%%%%%%%%%%%%%%%%%%%%%%%     
            &%&@@@@&&###%&@&%%         
              %%%%%%%%%%%              
                  ####                 ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.5);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
            Console.Write(row);
            currRow++;
          }
          }

        else if (name == "Sephiroth")
        {
            var rows = @"                                             
    %                          ,             
                              ,. ,*          
     #             (%*(**     ,  ., .        
                 (*//#%**     .   .....      
      &        %&&%, / .#(/, .    . .,, *    
       @  #((*%/ % .#(%,* ,          ..,,*   
    # (#(/##((/(  . . ..              .. ,*  
     (##/,/*,.. ,,.  ......            .. ,  
  /&%/ (((.(.,,*** ..,....,          . , . / 
 / #(/  (# .,,  / .,,...,. .         .  .../ 
 # %#  &    (*.   .*..   ,*.   . . . .....,* 
    #  #    **   ,,..   . / .   ,  . ....,** 
             .. ,  .  ( .          .,  ,.**/ 
          ,*,,,.  ...      *        ,..,,*** 
       **,,**. .  ....  .  ,         , .,./* 
       .,*,.    ..      ,  .          ,.(,, ,
       ,,.    ., ,.       ..            ,/*  
                  .        .               * 
                  . ..    ,                  
                  *, ,.                      
                  ...  *,                    
                  ...                        ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.3);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
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
          currRow = (int)(Console.WindowHeight*0.35);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
            Console.Write(row);
            currRow++;
          }
        }
        
        else if (name == "Bowser")
        {
            var rows = @"            .       .,                       
            .,**  ////     **/**             
            (#(   (##&# .(//(///(,  /        
     ,,.*/(. .,**//***(#%/((#((//(//         
       *%#.....,**&/*(#....*/.,#(%*          
      ,( ...*((%...,,/.,,/*....,.,*/,        
     (# .**#%/...,/(/(#&,(@&//(/*((/         
       .*(&*&,,(((////*, .,%(#%&(/&%%(///(##/
      ,//@....,,*((/(////*,.,***/%#&(/////*..
 ..,,  ,*.....,,,*((//////##/  ((/%&/(*.(    
  ....,,*.....,,*////***((((((/              
    /**/...,,,*////*  ((((((/*               
        . ..,,//*     ((((((/*,              
       ... *.,,./      /((**/*               ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.5);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
            Console.Write(row);
            currRow++;
          }
        }

        else
        {
            var rows = @"                                        
                                        
                           (            
                           ,.           
                  . *%      ,           
                %,/,**#      /          
                #*,,,.*,     /          
        *#(,.***%*..,.,*      ,         
       *###%%%%(***##,*(      (         
        ,,**.,**/,.#&(/        *        
         ,       ./,*(#%#      *        
        %#@.**/(,,.,**((##     //       
       (%((@@@(*#*./**(/(,       *      
       &((/(/&@//**(#%,#,               
         %*% ,../  **%%(                
       ,#&.#(.%%%&#%@&,###,             
     *#  *&#(  **@&/#%%                 
    ((    # #&#@&/%#@@@                 
     *#*   .@#//# @@@@@@                
        %#&(#%@@*   @@@@@               
           #@@@@   @@@@@                
           @&&&&  @@@@@                 
           &&&&* @@@@&                  
          &&@&&   #(#(#(/               
          &&&&&                         ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.3);
           foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
            Console.Write(row);
            currRow++;
          }
        }
    }
}
