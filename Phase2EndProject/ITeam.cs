using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Phase2EndProject
{
    public interface ITeam
    {
                //        Interface Members   Member Description
                //void Add(Player player); Function To implement functionality for adding a player to the Team by passing an object of type Player as a parameter
                //void Remove(int playerId); Function Implement functionality for removing the player from the Team by passing Player Id as a parameter
                //Player GetPlayerById(int playerId); Function To implement functionality to get player by passing Player Id as a parameter
                //Player GetPlayerByName(string playerName);
                //        Function To implement functionality to get player by Player Name as a parameter
                //List<Player> GetAllPlayers(); Function To implement functionality to get all players from the Team

        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();


    }



}
