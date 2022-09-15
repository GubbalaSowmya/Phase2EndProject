using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2EndProject
{
     class Program
    {
        public static Player PlayerId { get; private set; }

        static void Main(string[] args)
        {

           Program:
                Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
                int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
                {
                case 1:
                        if (choice == 1)
                        {

                            OneDayTeam player = new OneDayTeam();

                            Console.WriteLine("enter player Id");
                            int pid = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("enter player name");
                            string pname = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("enter player age");
                            int page = Convert.ToInt32(Console.ReadLine());

                            player.PlayerID = pid;
                            player.PlayerName = pname;
                            player.PlayerAge = page;

                            player.Add(player);
                            Console.WriteLine("player added");

                        }

                        break;

                case 2:
                   
                    OneDayTeam obj3 = new OneDayTeam();
                    Console.WriteLine("Enter Player ID to Remove:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    obj3.Remove(id);
                    break;

                case 3:

                    OneDayTeam obj4 = new OneDayTeam();
                    Console.WriteLine("Enter PlayerID:");
                    int player_id = Convert.ToInt32(Console.ReadLine());
                    Player p = obj4.GetPlayerById(player_id);
                    Console.WriteLine("PlayerID: " + p.PlayerID);
                    Console.WriteLine("PlayerName: " + p.PlayerName);
                    Console.WriteLine("PlayerAge: " + p.PlayerAge);
                    break;


                case 4:

                    OneDayTeam obj2 = new OneDayTeam();
                    Console.WriteLine("Enter Player Name:");
                    string name = Console.ReadLine();
                    Player p1 = obj2.GetPlayerByName(name);
                    Console.WriteLine("PlayerID: " + p1.PlayerID);
                    Console.WriteLine("PlayerName: " + p1.PlayerName);
                    Console.WriteLine("PlayerAge: " + p1.PlayerAge);
                    break;

                case 5:


                    Console.WriteLine("All Players details:");
                    List<Player> print_all = new List<Player>();
                    OneDayTeam obj5 = new OneDayTeam();
                    print_all = obj5.GetAllPlayers();
                    foreach (var play in print_all)
                    {
                        Console.WriteLine("PlayerID: " + play.PlayerID);
                        Console.WriteLine("PlayerName: " + play.PlayerName);
                        Console.WriteLine("PlayerAge: " + play.PlayerAge);
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;


            }
            Console.WriteLine("Do you want to continue (y/n)?");
            string ch1 = Console.ReadLine();
            if (ch1 == "y")
            {
                goto Program;
            }
            else if (ch1 == "n")
            {
                Environment.Exit(0);
            }
            Console.ReadLine();

        }
    }
}

