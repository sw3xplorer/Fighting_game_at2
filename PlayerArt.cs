using System;


public class PlayerArt
{
    public static void Art(int page)
    {
        if (page == 1)
        {
            Console.WriteLine(@"____________                ______                      _______________
______  /__(_)______ _______ ___  /____  _____________  ____  __/__  __/
___ _  /__  /__  __ `/_  __ `/_  /__  / / /__  __ \  / / /_  /_ __  /_  
/ /_/ / _  / _  /_/ /_  /_/ /_  / _  /_/ /__  /_/ / /_/ /_  __/ _  __/  
\____/  /_/  _\__, / _\__, / /_/  _\__, / _  .___/\__,_/ /_/    /_/     
            /____/  /____/       /____/  /_/                           ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"                         ..                                                                         
                      ..,, . ..                                                                   
                      ..%%%%%&/ ...                                                                
                    ..,%%%%%%%%%. ...      .............                                          
                    ..*%%%%%%%%%%%.........................                                       
                    ..,%%%%%%%%#,.............  ...........,                                      
                    .. %%%%#................    ...........,,.                                    
                    ,...(..................     .........,,,,,......       ....                   
                    ................,,.....    ..,,,,,,,,,,........##%%%%%%%%(*.   .              
                      ,..............,,.....   ..,...................,%%%%%%%%%%%%%#...            
                    ........     .. ..,,...............................%%%%%%%%%%%/ ..             
                  .....,   %##%  ,... ,,,...........,.................,#&%%%%%%*..,               
                  ....,.  %####*  *#(  ..,,,,,,,,,,,,...................,#%%%*...,                 
                  ,....  (###########       .,,,,,... .,    ,,..........,,....,.                   
                ,,,...  *#########%,            ...     (%###(*.......,,,.,,                      
                ,,,,,,.  .%####%#..             .,    ######   (*.....,,,,                        
            ....,,,....*..     ,.......         ,    *###########....,,,,,                        
          ....       ...........................,    .%#########/.,.,,,,,.                        
            ,...... ...............,*............,     %######%,,.,,,,,,,                         
              ,,,.......................,**.........      . ..,,,,,,,,,,                          
                  .,,,,,,,.............................,,,,,,...,,,,,,,,.                          
                    ,,,,,,,,,,..................................,,,,,,,                            
                    .,,,,,,,,,,,,,.......................   ...,,,,,,                             
                      .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,...    ..,,,,                               
                        ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,...  ..,.                                 
                    .,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.......                                  
                  ......,,,,,****,,,,,,,,,,,,,,,,,,,,,,,,,,...,                                   
                ........,,,,,*****       .....,.***********,,,,,,.                                
                  ,....,,,,,.                      ******,,,,,......                               
                                                      .**,,,,.......,                              
                                                            .,,,,,,.                               ");
            Task.Delay(750).Wait();

        }
        else if (page == 2)
        {
            Console.WriteLine(@"________            ______ _____             ___________  
__  ___/_______________  /____(_)______________  /___  /_ 
_____ \_  _ \__  __ \_  __ \_  /__  ___/  __ \  __/_  __ \
____/ //  __/_  /_/ /  / / /  / _  /   / /_/ / /_ _  / / /
/____/ \___/_  .___//_/ /_//_/  /_/    \____/\__/ /_/ /_/ 
            /_/                                           ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"                                                                      
                                                                *     
                  .(#%(#                                       /*     
                 /%&@&%&/                                      /.     
               @&&@&@@&%        ..(*,,,,,.                    ,,      
            /%&&&&@@@@@&        ,%#((////**                   ,.      
          *%&&&@&@@@@@@@%       .*#/,,(/%%//.                #*       
        ,&%&%&@&&@@@@@@@@&,    .//#@#*/&%%%(//              ,         
      .(%&@&%&&&@@&@@@@@@&@&%##%*@%@%(%%%(,.....,           ,.        
      /%%%@@&&@&@@@@@@@@@@@@@@##%%%/(/##/&.#     *@.       (*         
     /%%%&&@&@@@@@@@@@@@@@@@@&@&%#######%%@%##(/,(/((#(/**#,.         
    ,%%#&&%&@@@@@@@@@@@@@@@@@@#@&&&&@@@&@@@@@@#//%/*****((,****,.     
    #%#@&&@&@&@@@@@@@@@@@@@@@@@@&&%@&@#@@&@@%@@@(##((((((,//,..**,    
   .&#@&%@&@&@@@@@@@@@@@@@@@@@&@@&&&&%&@@@%%%&%@&%%#((/(//(//*/(/,,.  
   /&@&%@%@@&@@@@@@@@@@@@@&@@%%&&@&#@#%&@@@#((%@%%#%(/(#/***,*(/,,(*  
   #&&&@@@@@@@@@@@@@@@@@@%  &@@&&%&&&##%@&@@%###@&%%/(%((((((((*(, *( 
   #&&&%&@@@@@@@@@@@@@@&%  %&@&&%@&&&@##%&&@@*/.#@%%/%*,(*.   ((,*, ,*
  ,%%%%&&&@&&@@@@@@@@&%*  ##&(%%@@&@&&&&#%&&@%   @%((*.   /,   .*.* .,
   %%%%&&&@&@&@@@&@@@%    %#(,%@@@@&@@&&&%%&&@(  &&#&*     ,    ,  .. 
   ##%%%&&&&@&@@@@@%(    ,@&,#@@@&@@@@@&&&%%&@@&/#&%(.     .          
   ###%&%&&&@&&@&,,       &&%%@@@@@@&&&@&&&&&%@@@#%%                  
   ###&&%%@@@&%#            /@@@%%@@@&@&@&&@@&%@%&#%                  
   #(%%&&&@&&&&,            &@@@&@@@@@&#&&&&@@@%%#%%###.              
   ###@%%&&@&(.             (@&%#&@@@@@%%&@@@&..@%##%%%##%%&          
  (#(&&%%&#&#,             .&@@&&&&@@@@&@&&&&@@&@@@&%#%&%%##,         
  (//&%%#&/%*               @&@@&%&@@@@&&&&&&@@@@@@@@&%##%%%          
 /  #%%%%(                  &&@@@&@#@//&&@&%&&&@@@@@@@&&%%##%.        
   ,#((%*                   &&# @@@@@@,@@&@&%&@%&@@@@@@@&&%%,         
   #(/.                    .&&&, %@@@@(@@&&&*  &@@&@@/..              
   ,                         %@%   @@@#@@&&%     @@@@@/               
                             .&@.  .@@&@&&&.         .                
                                ...@@@@@&%%,,,,,,,,,,...............  
                           ....,,,*&&@@@&%%//////////////*****,,,,....
                            ...%&%#%@&%@&%@###############((((///***,,
                                .*//*#%&&%%#(((((((((((((//////****,,,
                                     ,&%%%/......          ........   ");
            Task.Delay(750).Wait();
        }
        else if (page == 3)
        {
            Console.WriteLine(@"________                     
__  ___/_____ _______________
_____ \_  __ `/_  __ \_  ___/
____/ // /_/ /_  / / /(__  ) 
/____/ \__,_/ /_/ /_//____/  
                             ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"                                                                                                    
                                     @@@@.                @@@@&                                     
                                 @                               @@                                 
                              @%                                   .@@                              
                             @                                        @                             
                           @@                                         @                             
                           @@       @@@@@@@@           /@@@@@@@@       @.                           
                           @@  ,@@@@@@@@@@@@@@        @@@*******@@@    @,                           
                           @@  ,@@@@@@@@@@@@@@        @%****@****@@@   @.                           
                             @   @@@@@@@@@@@@@  %@@    /@@****/@@@@   @                             
                              @%           @   @@@@@@    @          @@                              
                             @      @          @@@@@@         ,@      @                             
                             @   ***@#(**                   **(@@/*   @                             
                             @      @  @ @@@@@@@@@@@@@@@@@@@ @@@      @                             
                          @@@@@%       @@.  @@  %@    @(  @@@       @@@@@@@                         
                       @(,,,,,,,,@          @@@@@@@@@@@@@        @@,,,,,&@###@                      
                      @####@@@@%,,,,,@@@@.                @@@@&,.,,,,,@######@                      
                    @@#########%@,,,,,,,,@@@@@@@@@@@@@@@@@,,,,,,.,,,@@#######@                      
                    @@##############@,,,,,,@          @#,,,,,,*@@@@#####@@#####&@                   
                 &@########@@########@@((@@            /@@@@###########@#########@                  
                @##########@@########@@((@@            /@(@@##########@@############@               
               @###########@@########@@@@@@            /@@@@########@@@@############@               
               @###########@@@@@#######@(((@           ,((@@###@@@@####@#############@%             
               @##########@############@@#(@           ,((@@#@@#########@@###########@%             
                 &@#######@############@(@@@           /@@##@###########@@##########@               
                   #%%%###@#############@#(@           ,(@%%&###########@@#######%((                
                      @###@#############@#(@           ,(@#############@@@#####&@                   
                       @@@@@@@@@########@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@. @                         
                           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@,                           
                           &&&@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&@@@@@@@@@.                           
                          @&&@@@@&&&@@@@@@@@@@@@@@@@@@@@@@@@&&&@@@@@@@@&@@                          
                          @&&@@@&&@@@@@@@@@@@@@&@@&@@@@@@@@@&&&@@@@@@@@&@@                          
                          @&&@@@&&@@@@@@@@@@@@@&@@&@@@@@@@@@&&&&@@@@@@@@&&@                         
                        (@&@@@&&&@@@@@@@@@@@@@&&@@@&&@@@@@@@&&&&@@@@@@@@&&@                         
                        (@&@@@&&&@@@@@@@@@@@@@&@* @&&@@@@@@@@&&&@@@@@@@@&&@                         
                        (@&@@@&&&@@@@@@@@@@@@@&@* @&&@@@@@@@@&&&@@@@@@@@&&@                         
                          @@@@@@@&&&&&&&&&&&&&@    @@&&&&&&&&&&&&&&&@@@@@@                          
                        (@@@@@   @@@@@@                  @  @@@@@@@@    &@@@@                       
                      ,&(,,,,,&&&,     @               .,&         ,@@&&*,,,,&&(,                   
                    @@,,,,,,,,,,,,@@   @               /@        @@,,,,,,,,,,,,,,@                  
                    @@,,,,,,,,,,,,,,@,,,@.            @#,,,,,,,,@,,,,,,,.,,,,,,#@                   ");
            Task.Delay(750).Wait();
        }
        else if (page == 4)
        {
            Console.WriteLine(@"________                                    
___  __ )________      _____________________
__  __  |  __ \_ | /| / /_  ___/  _ \_  ___/
_  /_/ // /_/ /_ |/ |/ /_(__  )/  __/  /    
/_____/ \____/____/|__/ /____/ \___//_/     
                                            ");
            Task.Delay(1000).Wait();
            Console.WriteLine("");
            Console.WriteLine(@"                                                                                                    
                                                      ,                                             
                                                      ,.                 ..                         
                                                     /*,.              ,,...                        
                                //  ,*//(            (///((/,      ..**,,...                        
                             *////((//**    ./     .#%########(**(/(#***,,,                         
                           ,/((/(//(///(///(//, /%%%##%/((//(&((#((%#(**/(/                         
                    ,      ((((//////(///(((*,.... .&%%%#*.           ((##(                         
                    (.  .  ##((((((//(((((*,,.,,/*,,................      (((*//*,....    .         
                     #*#((((////((((((##((((//&(.%#(/*****/*, //***,,...    %##(//,,..,,*           
                     ,(#(((#///(((((,,%%#//%#@@&%&%#(((%%##%%%,.............  (##(/(**/             
                       .,####(%##*.#..,//.... ...,*(#/%*(,/(&***,,,*...........(#(#((               
                     */(,...%& ,....,**..  ......,,,.. ....&(*(*/. (%%#.... .... (/                 
                    .,*,,,........   .....,,*,,,,,..,,*(... .. ,%%%%%#####....... #/(*              
                   */*///*,,,,,*,,...,.,,,#(((*,,/*/(#&. .,,*/*,.. *%%(#*,*%.....  *(*(.            
                    //((/////((//********&&##((((&&###%*(((//(......  &%%####,,*,.  *((**,,,**      
    ......           **////((&,**///((@@@,,#*,.,&%#(((///(((/*....,,.. ,%%##%(((*,.. /(*            
     *,**,*/((/, ,*,/%#,.(/#%#%&%&&&/%(#&&#(/*/%*..,*//////(/*,/(//((*,.%&%#%%#((*,..               
  /((((#(////////((@%%&&&%#((/#&#%%%((##(*,.... ,*///((//////((((((/*,,(&&/,*@%#(/**,.              
 . **//*,(////////((#&@#%@%//#/#(,,..........,(///((((/*////**////(((/&&(,*(##@%(//**,.             
   *,.,#///////////(((&/(#&///****,,,,,....,,//////////((////((/**,,*,.,......./%////*,           ..
 ,,.,,//////(/,..,,,/(#&%%&#*//////////***/((((((((//////((((#(/*,,,,,...........#**/*.    *.   ,.. 
  /      ((/  .,,*//((@&&&%((((((#     ((##//////////////((#(//*,,,,,.............,*,      #*,..... 
           ,*****/#&&&*/#,...      ,((#######/*******////((((/,,,,,,,,...  ....... (,.  .,,........ 
                                 ,(((((((((((##*******///(((//**,,,,,,....  .. ,,***,,,,.........,  
                                 ///((((((((((((((/****///((///****,,,,..........**,,,..,......,,   
                                 /*///(((((((((((((((#/***////////**,,,,,,.,......,****,*,,,***     
                                  ,,*///(((((((((((.      *////////****,,,,,.......*///////*        
                                    ***///((((((((((.         *//////***,,,,,......./(/.            
                                 .,*////((#(((((((((/          **/////*,,,,..... ...                
                               .,***,*****///(((((((//           /*,,,*,,,..,.........              
                               .,,*,,*/*////////(/(/(           /*,,.(*,...*,.,.......              
                                                                /*   #*   .(,   ,,,,*               
                                                                  .     ,                           ");
            Task.Delay(750).Wait();
        }
        else
        {
            Console.WriteLine(@"________      ______             ______ __      _____        ______ _____ 
___  __/___  ____  /_______ _    ___  //_/_________(_)______ ___  /___  /_
__  /  _  / / /_  __ \  __ `/    __  ,<  __  __ \_  /__  __ `/_  __ \  __/
_  /   / /_/ /_  /_/ / /_/ /     _  /| | _  / / /  / _  /_/ /_  / / / /_  
/_/    \__,_/ /_.___/\__,_/      /_/ |_| /_/ /_//_/  _\__, / /_/ /_/\__/  
                                                     /____/               ");
            Task.Delay(1000).Wait();
            Console.WriteLine("\n");
            Console.WriteLine(@"                                                                                
                                                                                
                                                                                
                          (*                                                    
                         **,                                                    
                         //                                                     
                        **.                                                     
                        */                                                      
                       **.           /((*,. .                                   
                      ,,*           /%/,,*,,*,**(                               
                      ,/           .(/*.,*./***#%.                              
                     ,*.           #,*,..,./,,/%(                               
                     **           (**..., ,/,,/%(                               
                    **.          ./,*../,.**.,/%#                               
                    .,           *//,..*,.,*,,*(&(,***...,*/((%*                
                   **            *,*,..**,,*,,*/#%(%%%#%######%%#(              
                  .,*            **/*,,&/#**,,,***#%%%%%%%%%%#%((%,             
                  ./              #(/*/(%&&*/*(,,*/(#######((((***.             
                 .*/              */(//(&%,,*,,***//***,******.,,*.             
                 **             ,#/#/%%%*(/#/#/..*/.           ...              
                ,(,           .#####(/(/,,,(*..               ,.                
              .*,/,          ,######*((/*,....,*(//,... .     @&.               
             ,,. #*,     .. .#(###(#(/(,.. .,, ,**/**,**,,.,&@%%/               
             *,..//         .(##((*(#((/, ,,,%/(/*////*/*@@@&&&&#.              
             .*#*          .*/*/(/(////**,*,****#*%**&@@@@&&(%#(/#&,            
             ./*                /((((/////(,/,//,%*#,(@@@@@%#&#%@&#(            
                                *(,(,(%#*,*.%/*(*(,%/#*(#%(#((((#%(#,           
                                 /#*/**&(@((#*((,##(*.*/(.#/((%#%&#             
                                 ,%##,.*#&@ ./ ,...&***..%(**%&(                
                              ./,.*(% /##(/%/&&@&(&**%((/&/&##,/,               
                             ,%//*,#((@@@#(%(&%/%&#%*&&(%#,&@%%#*,*             
                            ,,*(#%%##*,&%%(#%%#%#%%%##((&%(#(// /((,(,          
                                  ,%%%((,*&&&/#(%*(@&&%(#,./%/#%(.,/#,#,        
                                   ,@&#%%%*,#&@@&./((&@@@#*&@#%/(,  .##/*       
                                   &@@@@&###(**%%&%*(%*#@@@%/#.      &%##.      
                                  #@@@@@@@@%##%/*%%%@#*(#*#%/.      ##%#%       
                                 (@@@@@@@@@* (%#%%//#%(%#*@%     ,%(*#(%.       
                                (@@@@@@@@@%    #@%##(**/%%&&#/%%#*(#(&,         
                                &@@@@@@@@@/    ,&@@@%(##***..,*####.            
                                %@@@@@@@@@/     #@@@@@@@@&%((/,                 
                                .&@@@@@@@@%      &@@@@@@@@,                     
                                 .&@@@@@@@@#     #@@@@@@@@%                     
                                   &@@@@@@@@#    (&&&&&&&&&                     
                                    %@@@@@@@@%   .&&&&&&&&&.                    
                                    .&@@@@@@@@*   &&&&&&&&&#                    
                                  .%&%%@@@@@@&%.  #&&&&&&&@&,                   
                               ,//(//(#%%&@%%%/   .&&&@&&&&&(                   
                              .(///#(//.           %&&&&&&&&%                   
                                                   /&&&&&&&&&*                  
                                                   .&&&&&&&&&(                  ");
            Task.Delay(750).Wait();
        }
    }

}




