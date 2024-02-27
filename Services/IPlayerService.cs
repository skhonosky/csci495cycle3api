using System.Collections.Generic;
using System.Data;
using PlayerApi.Models;
using PlayerApi.Repository;

namespace PlayerApi.Services {
    public interface IPlayerService {
        public IEnumerable<Player> GetPlayers();
        public Player GetPlayersByName(string name);
        public IEnumerable<Player> GetPlayersBySport(string sport);
        public IEnumerable<Player> GetPlayersByTeam(string team);
        public void CreatePlayer(Player p);
        public void UpdatePlayer(string name, Player p);
        public void DeletePlayer(string name);

    }
}