using System;


public class CombatArtEnemy
{
    public static void CombatArtE(string name)
    {
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
          currRow = (int)(Console.WindowHeight*0.3);
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
          currRow = (int)(Console.WindowHeight*0.35);
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

        else if (name == "Tuba Knight")
        {
            var rows = @"                                        
                                        
             *                          
            /.                          
            ,      #, .                 
           /      #**.**%               
           (     (/.,,.*#               
          ,      (,.,,.*%/**.,(#.       
          *      (*,#/,,*#%%%%%#(*      
         /        (/&#**//,,.**,,       
        ..     *#%#(*.*.       ,        
        (,     ##((**,..,(*/* @#%       
       ,       ,((/***,//*%@@@((#(      
                /#.%//**#.&%#////%      
                 #(#,,, ,.., #,&        
              ,#/#,&&%&@&&% (% @%,      
                  %%(#%@(*  *#%/  #*    
                 .@@@#(*#@(%( #    ##   
                 @@@@@@ #((%&    /##    
                @@@@@   %@@##(&#%       
                 @@@@@   @@@@*          
                  @@@@@  &&&&&          
                   &@@@# %&&&&          
                /(#(#((   &&@&&         
                          &&&&&         ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.3);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }
        else if (name == "Tagilla")
        {
          var rows = @"                                             
                 ,%%(                        
               ..  ,**&                      
               *///*#(#*                     
               **##%%%&*                     
               /(%,//%*(% *                  
           .   .* *.  ,(          %&&&%%%    
          ,     ,,./*,*% (          *(%&&%(  
          ( *  (/(/*(/%#*%(.(/.  #/&,        
          *   .*(((((&#(,  .,../*(/*         
                  //((((    *..              
            *%%&/,*#**(((*(*                 
         #&&%##(#%%%%#/ /,&                  
        %&%#(#%&&&&&%.&&##((                 
         %&&#&&  %/*   &&%(/(,               
       /##%#&&&#,       %&&%#**              
      .%(#%%&@,          %&&%*/              
       &#%&&#            #%%(#/              
        &#&&,             *%##               
        .&&&               &%&               
         #%%                  ,              
     ,/##/                                   
                                             ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.35);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }
        else if (name == "Cloud")
        {
          var rows = @"                                             
  @/                              %          
   @(((%                     &&@&%&          
    @&*///((               %&&@#&&%          
     @@&**,*/(##             #@&%  %         
      &@&,,,,****/(    /../(,/..*,           
       &&%%...,.,,,**/( .%&(./**/*#&         
        @@@&&%%..,,.*,,,,*&&% ...#&@         
             @@&&&%...........#,,/%          
                 &%%%##,...... *,,%          
                      ###((/ ./ ,/.          
                        */#(/..** .,*/       
                       (,/,,,/..... ,***     
                     /***,..      ,....*/(   
                 (/**,.,..           ....,*  
                 ,. .,,             .,,. ,   
                %#/...,             *,,..    
               ,.& *                *..*/    
             **/,                     (/,,,. 
             /***,                           ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.35);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }
        else if (name == "Vergil")
        {
          var rows = @"                            /*(        
                    .. ...,,.%%,       
             ,,.. , /  ..*.* #(%       
         , .     .  .  .%&#  ,(@       
        ,   .    #/,,,/#%&@  &&        
        /  ...   %#**((#%&#  @@        
        (         *,*.%#%(  ,**/#      
        .      .    ..*(  * .,,*/#(*   
         /    ..  .       .,  .    * ,*
              ./. .. .,.      ,    .  ,
          .   ..  . .,,      ,*        
          ,.  ,  ....,**  . .,*        
          ., .   .. ..,..  ..*..       
           , ,    . ,,,,.  ,*(**       
           ,      . ,.,,  . ,(**       
          ,          .,,  ..*(/        
           .        ..,... .//(        
        **              .  ,/,/        
        .        .... .... ,(,,.       
      ..       ..    . ... ,/#..       
     (       ..    .. ..   **.,(       
    ..            ... .   ,/, ,/       
    , .            .,     ,/. /,       ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.3);
          foreach (string row in rows)
          {
            Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
            Console.Write(row);
            currRow++;
          }
        }
      else if (name == "Doom Guy")
      {
        var rows = @"                                                  
                       %,  .%                     
                     @%,.   .,/                   
                     (,./.  ...*    (             
              *#/ //  */***/..     /. /           
            ,(,% .    .,%. .  . . *    .          
           #(#%%.*.  (* ...,      .  ,,,,         
           &%**/((, #****,./,.     ....*          
            /..  .(/,,,.        .     #           
          (*,,     .....     , *,*/   **          
          *%#*,.   &,/.   * .. ,.*. *, *          
           &&#(.,*##*/.*% .   .#,%,  *&           
             */,(,,,  .*(/&(.* # ,. .(            
                ,.   .   *#    ,&,.(              
                 (,.   .        &    ,%.#%        
                 *.,         .  ..#  /,   , . *   
                 ,,    .         ./               
                 ,. .             .               
                 ,.                               
                 ...       .     .                ".Split("\n");
              currRow = (int)(Console.WindowHeight*0.35);
              foreach (string row in rows)
              {
                Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
                Console.Write(row);
                currRow++;
              }
              
      }

      else 
      {
        var rows = @"                                                  
                                  *#(( ,          
                (##(              /((  *          
                (##    ,           (#  .          
                ##     .           #,   #         
                (**                (    *         
 .*/         (///*.. ***,          ,              
     .***   ,*.*/*,,/*,,/*/, /**/,.     ,*        
          */,//./,.*** ,, .//*#(*    *,  ,        
        #(#/. *,**. (.  /**,..*((   /(   /        
        ,###**././///.(#(#.    ###. ,//  ,        
         ./// /,#*/. / #**/,,,. ##  .,/,,         
          *//  ,#.,*,.*/.,,,,,.*(#  *//*,         
              /  , ,.,,,,///,*.,.   **/(/.        
               ././*/,      ..,,.,, *,(#(.        
                (#///, /   */,,.  /#*#((/ .       
                /#      *(*., (/*//,  (           
                ,.   ,  (*,,,#(//.,  #,,  .,,     
               ,  ,*,.  *%#(//  , ,.  ,  #/,.     
              ,  (#,.   *.*/,**,,,,.,  .#(,,#     
             .  ((    * /*..*//,   *., ###,.      
                (    */ ./(***, ***,   (#..       
             , .    **/  #*/.   //,.. ##./        
           ,./,    #*//..*,,  ////*  ,#.(         
           */*/   **////,,,, #///*. .#.*          
          ***,*  **////,,/,,,,..*/*/,.,           
          ,.,*, #/////,,,,*  ,*//*/..,,           
          *... /*,*//,,,.   /,**...*.,,           
            .*(*****,,,.     (*..,,.,,,           ".Split("\n");
          currRow = (int)(Console.WindowHeight*0.2);
              foreach (string row in rows)
              {
                Console.SetCursorPosition((int)(Console.WindowWidth*0.7), currRow);
                Console.Write(row);
                currRow++;
              }
      }
    }
}
