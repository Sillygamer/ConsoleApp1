using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class MiniDC
    {
        public static void StartDc()
        {
            Console.Clear();
            Console.WriteLine("Mini dungeon crawler. Welcome to MiniTopia");
            Console.Write("\n\tWhat is you name player? > ");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 90, 20);
            //monsters
            Player[] monster = new Player[6];
            monster[0] = new Player(0, "", 0, 0);
            monster[1] = new Player(1, "Goblo the giant", 70, 15);
            monster[2] = new Player(2, "The wizard of MiniTopia", 30, 15);
            monster[3] = new Player(3, "Gerda the gremlin", 150, 25);
            monster[4] = new Player(4, "The Evil Knight", 55, 20);
            monster[5] = new Player(5, "Greg", 200, 30);

            //Create locations
            int maxX = 11;
            int maxY = 11;
            //2d array
            Location[,] location = new Location[maxX, maxY];

            location[5, 5] = new Location("Home", "You sit in a comfy chair near a fire.", 0);
            location[4, 4] = new Location("- Getel", "A Small town with a magical fountain.", 2);
            location[7, 7] = new Location("0 cavern ", "a huge cavern", 5);
            location[9, 7] = new Location("+ weeping willow", "The Braches sooth you", 0);
            location[4, 8] = new Location("- MiniTopia Castle", "You see a giant castle towering in front of you", 4);
            location[3, 8] = new Location("0 Throne Room", "you stand in front of the throne with a red carpet leading up to it.", 3);
            location[3, 4] = new Location("+ The wishing well", "there is a mysterious well in front of you", 0);
            location[7, 5] = new Location("- Goblos post", "This is where Goblo the Giant gaurds the cave", 1);


            //place player at home
            int px = 5;
            int py = 5;

            // create a dice
            Random dice = new Random();

            //Game begins
            while (true)
            {
                //display loc and health
                Console.WriteLine("\n-----------");
                Console.WriteLine("Health: {0}", player.Health);
                Console.WriteLine("Location: {0}, {1}", px, py);

                // Display Details
                if (location[px, py] != null)
                {
                    Console.WriteLine("*** {0} ***", location[px, py].LocationName);
                    Console.WriteLine("*** {0} ***", location[px, py].Description);
                    if (px == 7 && py == 7 && monster[3].Health <= 0)
                    {
                        Console.WriteLine("You hear rubling and stomping");
                        Console.WriteLine("You have entered the bosses layer");
                        location[px, py].MonsterId = 5;
                    }
                    if (px == 7 && py == 7 && monster[3].Health >= 1)
                    {
                        Console.WriteLine("There is nobody home.");
                        location[px, py].MonsterId = 0;
                    }

                    if (location[px, py].MonsterId != 0)
                    {
                        int mId = location[px, py].MonsterId;
                        Console.WriteLine("!!! You came across {0} with health of {1} !!!", monster[mId].Name, monster[mId].Health);

                        //battle
                        int damageToPlayer = dice.Next(10, monster[mId].MaxDamage);

                        // deal damage
                        player.Health -= damageToPlayer;

                        //show results
                        Console.WriteLine("!!! You take {0} damage, your health is now {1} !!!", damageToPlayer, player.Health);


                        //death
                        if (player.Health <= 0)
                        {
                            Console.WriteLine("You died");
                            Console.WriteLine("Game over! insert coin to play again");
                            return;
                        }
                        if (monster[3].Health <= 0 && monster[5].Health >= 1)
                        {
                            Console.WriteLine("Gerda: There is more out there, you still have not defeted my boss");
                        }
                        if (monster[mId].Health <= 0)
                        {
                            Console.WriteLine("!!! {0} has been killed", monster[mId].Name);
                            location[px, py].MonsterId = 0;//TAKES MONSTER OUT OF ROOM
                                                           // location[px, py] = null gets rid of room
                        }
                        if (monster[3].Health <= 0 && monster[5].Health <= 0)
                        {
                            Console.WriteLine("You have defeated the boss and saved MiniTopia!");
                            Console.WriteLine("You Win! Insert coin to play again");
                            return;

                        }
                    }//monstrid !=0
                }//location!= null

                //healing or other kind of rooms
                if (px == 9 && py == 7)
                {
                    Console.WriteLine("The magic tree begins to heal you as you feel calmer.");
                    //player.Health = 40;
                    //player.Health += 3;
                    player.Health += dice.Next(1, player.Health);
                    Console.WriteLine("You now have{0} health", player.Health);
                    if (player.Health > 70)
                    {
                        player.Health = 80;
                        Console.WriteLine("You can not heal any more points");
                        Console.WriteLine("You now have{0} health", player.Health);
                    }
                }//end of healing

                if (px == 3 && py == 4)
                {
                    int NumberOfWishes = 3;
                    while (true)
                    {
                        Console.WriteLine("\nYou have {0} wishe(s) left.", NumberOfWishes);
                        Console.WriteLine("'A' for more attack power, 'H' for more health, 'Hint' for help and 'leave' to go back to the city");
                        Console.WriteLine("Leaving will not affect your wish count");
                        Console.Write("What do you wish > ");
                        string wish = Console.ReadLine().ToLower().Trim();
                        if (NumberOfWishes >= 1)
                        {
                            if (wish == "a")
                            {

                                player.MaxDamage += dice.Next(1, player.MaxDamage);
                                NumberOfWishes -= 1;
                                Console.WriteLine("The max damage you can deal is now {0}", player.MaxDamage);
                            }
                            if (wish == "h")
                            {
                                player.Health += dice.Next(1, player.Health);
                                NumberOfWishes -= 1;
                                Console.WriteLine("You now have {0} health", player.Health);
                            }
                            if (wish == "hint")
                            {
                                if (monster[3].Health >= 1)
                                {
                                    Console.WriteLine("There is rumours that a gremin has taken over the castle to the east of the village");
                                }
                                if (monster[3].Health <= 0)
                                {
                                    Console.WriteLine("Southeast of your home lies the layer of greg. Defeat him to save MiniTopia!");
                                }
                                NumberOfWishes -= 1;
                            }
                            if (wish == "leave")
                            {
                                px = 4;
                                py = 4;
                                break;
                            }
                        }

                        if (NumberOfWishes <= 0 && wish == "a")
                        {

                            Console.WriteLine("\nNo more wishes left");
                            NumberOfWishes--;

                        }
                        if (NumberOfWishes <= 0 && wish == "h")
                        {

                            Console.WriteLine("\nNo more wishes left");
                            NumberOfWishes--;
                        }
                        if (NumberOfWishes <= 0 && wish == "hint")
                        {

                            Console.WriteLine("\nNo more wishes left");
                            NumberOfWishes--;
                        }
                        if (wish == "leave")
                        {
                            px = 4;
                            py = 4;
                            break;
                        }
                        if (NumberOfWishes == -2 && wish == "a")
                        {
                            Console.WriteLine("\nI would'nt do that if I were you");
                            NumberOfWishes -= 1;
                        }
                        if (NumberOfWishes == -2 && wish == "h")
                        {
                            Console.WriteLine("\nI would'nt do that if I were you");
                            NumberOfWishes -= 1;
                        }
                        if (NumberOfWishes == -2 && wish == "hint")
                        {
                            Console.WriteLine("\nI would'nt do that if I were you");
                            NumberOfWishes -= 1;
                        }
                        if (NumberOfWishes == -4 && wish == "h")
                        {
                            Console.WriteLine("\nThats going to bring bad luck");
                            NumberOfWishes -= 1;
                        }
                        if (NumberOfWishes == -4 && wish == "a")
                        {
                            Console.WriteLine("\nThats going to bring bad luck");
                            NumberOfWishes -= 1;
                        }
                        if (NumberOfWishes == -4 && wish == "hint")
                        {
                            Console.WriteLine("\nThats going to bring bad luck");
                            NumberOfWishes -= 1;
                        }
                        if (NumberOfWishes <= -6 && wish == "h")
                        {
                            player.Health -= 10;
                            player.MaxDamage -= 5;
                            Console.WriteLine("!!!You have taken 10 points of damage and are 5 points weaker!!!");
                            Console.WriteLine("!!!You now have {0} health and max damage is now {1}!!!", player.Health, player.MaxDamage);
                        }
                        if (NumberOfWishes <= -6 && wish == "a")
                        {
                            player.Health -= 10;
                            player.MaxDamage -= 5;
                            Console.WriteLine("!!!You have taken 10 points of damage and are 5 points weaker!!!");
                            Console.WriteLine("!!!You now have {0} health and max damage is now {1}!!!", player.Health, player.MaxDamage);
                        }
                        if (NumberOfWishes <= -6 && wish == "hint")
                        {
                            player.Health -= 10;
                            player.MaxDamage -= 5;
                            Console.WriteLine("!!!You have taken 10 points of damage and are 5 points weaker!!!");
                            Console.WriteLine("!!!You now have {0} health and max damage is now {1}!!!", player.Health, player.MaxDamage);
                        }
                        if (player.Health <= 0)
                        {
                            Console.WriteLine("!!!You died!!!");
                            Console.WriteLine("Game over! insert coin to play again");
                            return;
                        }

                    }//end of while


                }//end of wishes

                Console.Write("What do you wish to do? (cmds for help) > ");
                string cmd = Console.ReadLine().ToLower().Trim();
                if (cmd == "q" || cmd == "quit")
                {
                    Console.WriteLine("Thank you for playing. Insert coin to start again?");
                    return;
                }//end of quit if
                if (cmd == "a" || cmd == "attack")
                {
                    int mId = location[px, py].MonsterId;
                    int damageToMonster = dice.Next(10, player.MaxDamage);
                    monster[mId].Health -= damageToMonster;
                    Console.WriteLine("\n!!! {0} takes {1} damage, it has {2} health left !!!", monster[mId].Name, damageToMonster, monster[mId].Health);
                }

                //moving
                if (cmd == "n" || cmd == "north") py--;
                if (cmd == "s" || cmd == "south") py++;
                if (cmd == "e" || cmd == "east") px++;
                if (cmd == "w" || cmd == "west") px--;

                //solve off world
                px = Math.Clamp(px, 0, maxX - 1);
                py = Math.Clamp(py, 0, maxY - 1);
                // if (py < 0) py = maxY - 1; wrapping
                //  if (py > maxY-1) py = 0;

                //map
                if (cmd == "m" || cmd == "map") Location.DrawMap(location, px, py);

                //saving
                try
                {
                    if (cmd == "save") DataManagment.SavePlayerdata(player);
                }
                catch
                {
                    Console.WriteLine("Could not save");
                }
                try
                {
                    if (cmd == "l" || cmd == "load") player = DataManagment.LoadPlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not load player data");
                }
                // show all commands
                if (cmd == "cmds")
                {
                    Console.WriteLine("\n'save', 'q' or 'quit', and 'l' or 'load'. ");
                    Console.WriteLine("'n' or 'north', 's' or 'south', 'e' or 'east' w or 'west'.");
                    Console.WriteLine("'m' or 'map', 'a' or 'attack'.");
                }
            }//end of while true
        }//end of start dc
    }
}
