using System.Collections.Generic;
using PlayerApi.Models;

namespace PlayerApi.Repository {
    public interface IPlayerRepository {
        public IEnumerable<Player> GetPlayers();
        public Player GetPlayersByName(string name);
        public IEnumerable<Player> GetPlayersBySport(string sport);
        public IEnumerable<Player> GetPlayersByTeam(string team);
        public void InsertPlayer(Player p);
        public void UpdatePlayer(string name, Player playerIn);
        public bool DeletePlayer(string name);
    }
}