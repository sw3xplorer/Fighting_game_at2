using System;

public class CombatArtPlayer
{
    public static void CombatArt(int moves)
    {
        int currRow = (int)(Console.WindowHeight*0.4);
        if (moves == 1)
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

        else if (moves == 2)
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
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
            Console.Write(row);
            currRow++;
          }
        }

        else if (moves == 3)
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
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
            Console.Write(row);
            currRow++;
          }
        }
        
        else if (moves == 4)
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
            var rows = @"                /, * #      /          
                %,(,,*%     #          
                %,/./..      ,         
       ,%####&%%/.*.*.*(     /         
       **((###(*.*/&(/(       /        
        .     .*.%(((#%#       (       
        &%  ..*(*..,/###(      **      
       *#@&@./*/*#. /(%/#*   .**/.     
      (@//#@@#&@##/(/((#        .      
       .&#(/%,,,&,*@ (/                
        ,% .%%@&&*&&%,(,*              
     /*/ */,*(@&%%%%,%%#               
    (#  #,%@@#%(@#/%#@&                
    %%%   (&*@#,##@@@@@#               
      &//, (.%#@   @@@@@               
           @@@@@   @@@@@               ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.45);
           foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.1), currRow);
            Console.Write(row);
            currRow++;
          }
        }
    }
}
