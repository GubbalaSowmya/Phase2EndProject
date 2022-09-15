using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phase2EndProject
{
    public class OneDayTeam :Player, ITeam
    {
        //        3.Create a derived class OneDayTeam to implement ITeam interface functionalities as given below:
        //Class Members   Member Description
        //public static List<Player> oneDayTeam = new List<Player>(); Global Field Member Create a global variable of type List<Player> to collect objects of type Player
        //public OneDayTeam()     Constructor Function    Write a constructor to set the capacity property to 11 
        //public void Add(Player player)  Function Implement functionality for adding a player to the Team by passing an object of the type Player as a parameter
        //public void Remove(int playerId)    Function Implement functionality for removing the player from the Team by passing Player Id as a parameter
        //public Player GetPlayerById(int playerId)   Function Implement functionality to get player by passing Player Id as a parameter.
        //public Player GetPlayerByName(string playerName)
        //    Function To implement functionality to get player by Player Name as a parameter.
        //public List<Player> GetAllPlayers() Function To implement functionality to get all players from Team.
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

        public Player GetPlayerById(int playerID)
        {
            Player ply = null;

            foreach (var play in oneDayTeam)
            {
                if (play.PlayerID == playerID)
                {
                    ply = play;
                    break;
                }
                else
                {
                    Console.WriteLine("PlayerID not found");
                }
            }
            return ply;
        }

    

        public Player GetPlayerByName(string playerName)
        {
            Player ply = null;

            foreach (var play in oneDayTeam)
            {
                if (play.PlayerName == playerName)
                {
                    ply = play;
                    break;
                }
                else
                {
                    Console.WriteLine("PlayerName not found");
                }
            }
            return ply;
        }

        public void Remove(int playerId)
        {
            Player ply = null;

            foreach (var play in oneDayTeam)
            {
                if (play.PlayerID == playerId)
                {
                    Console.WriteLine("Player{0} details has been removed successfully", play.PlayerID);
                    ply = play;
                }
                else if (play.PlayerID != playerId)
                {
                    Console.WriteLine("Players details was Empty");
                }
            }
            oneDayTeam.Remove(ply);
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }


    }
}
