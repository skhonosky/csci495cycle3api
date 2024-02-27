using System.Collections.Generic;
using System.Collections;
using PlayerApi.Models;
using PlayerApi.Repository;


namespace  PlayerApi.Services {
    public class PlayerService : IPlayerService {
        
        private IPlayerRepository _repo;
        
        public PlayerService(IPlayerRepository repo) {
            _repo = repo;
        }

        
        public IEnumerable<Player> GetPlayers() {
            IEnumerable<Player> myList = _repo.GetPlayers();
            return myList;
        }

        public Player GetPlayersByName(string name) {
            return _repo.GetPlayersByName(name);
        }

        public IEnumerable<Player> GetPlayersBySport(string sport) {
            return _repo.GetPlayersBySport(sport);
        }

        public IEnumerable<Player> GetPlayersByTeam(string team) {
            return _repo.GetPlayersByTeam(team);
        }

        public void CreatePlayer(Player p) {
            _repo.InsertPlayer(p);
        }

        public void UpdatePlayer(string name, Player p) {
            _repo.UpdatePlayer(name, p);
        }

        public void DeletePlayer(string name) {
            _repo.DeletePlayer(name);
        }



    }
}