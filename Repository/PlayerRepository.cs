using System;
using System.Collections.Generic;
using System.Data;
using PlayerApi.Models;
using MySql.Data.MySqlClient;


namespace PlayerApi.Repository {
    public class PlayerRepository : IPlayerRepository {
        private static readonly List<Player> players = new List<Player>() 
        {
            new Player {Name="Travis Kelce", Age = 34, Sport = "Football", Team = "Kansas City Chiefs", Position = "Tight End"},
            
        };
        private MySqlConnection _connection;

        public PlayerRepository() {
            string connectionString="server=localhost;user=csci495user;password=csci495pass;database=csci495cycle3webapi";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
            
        }

        ~PlayerRepository() {
            _connection.Close();
        }

        public IEnumerable<Player> GetPlayers() {
            var statement = "Select * from Players";
            var command = new MySqlCommand(statement,_connection);
            var results = command.ExecuteReader();

            List<Player> newList = new List<Player>(70);

            while(results.Read()){
                Player p = new Player {
                    Name = (string)results[0],
                    Age = (int)results[1],
                    Sport = (string)results[2],
                    Team = (string)results[3],
                    Position = (string)results[4]
                };
                newList.Add(p);
            }
            results.Close();
            return newList;
            
        }

        public Player GetPlayersByName(string name) {
            var statement = "Select * From Players Where Name = @newName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newName", name);

            var results = command.ExecuteReader();
            Player p = null;
            if (results.Read()) {
                p = new Player {
                    Name = (string)results[0],
                    Age = (int)results[1],
                    Sport = (string)results[2],
                    Team = (string)results[3],
                    Position = (string)results[4]
                };
            }
            results.Close();
            return p;
            
        }

        public IEnumerable<Player> GetPlayersBySport(string sport) {
            var statement = "Select * From Players Where Sport = @newSport";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newSport", sport);

            var results = command.ExecuteReader();
            List<Player> newList = new List<Player>(60);

            while(results.Read()){
                Player p = new Player {
                    Name = (string)results[0],
                    Age = (int)results[1],
                    Sport = (string)results[2],
                    Team = (string)results[3],
                    Position = (string)results[4]
                };
                newList.Add(p);
            }
            results.Close();
            return newList;
            
        }

        public IEnumerable<Player> GetPlayersByTeam(string team) {
            var statement = "Select * From Players Where Team = @newTeam";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newTeam", team);

            var results = command.ExecuteReader();
            List<Player> newList = new List<Player>(60);

            while(results.Read()){
                Player p = new Player {
                    Name = (string)results[0],
                    Age = (int)results[1],
                    Sport = (string)results[2],
                    Team = (string)results[3],
                    Position = (string)results[4]
                };
                newList.Add(p);
            }
            results.Close();
            return newList;
            
        }

        public void InsertPlayer(Player p) {
            
            var statement = "Insert Into Players (Name, Age, Sport, Team, Position) Values (@name, @age, @sport, @team, @position)";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@name", p.Name);
            command.Parameters.AddWithValue("@age", p.Age);
            command.Parameters.AddWithValue("@sport", p.Sport);
            command.Parameters.AddWithValue("@team", p.Team);
            command.Parameters.AddWithValue("@position", p.Position);



            int result = command.ExecuteNonQuery();
            Console.WriteLine(result);
        }

        public void UpdatePlayer(string name, Player playerIn) {
            var statement = "Update Players Set Name=@newName, Age=@newAge, Sport=@newSport, Team=@newTeam, Position=@newPosition Where Name=@updateName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newName", playerIn.Name);
            command.Parameters.AddWithValue("@newAge", playerIn.Age);
            command.Parameters.AddWithValue("@newSport", playerIn.Sport);
            command.Parameters.AddWithValue("@newTeam", playerIn.Team);
            command.Parameters.AddWithValue("@newPosition", playerIn.Position);
            command.Parameters.AddWithValue("@updateName", name);

            Console.WriteLine(playerIn);
            int result = command.ExecuteNonQuery();
            Console.WriteLine(result);
        }

        public bool DeletePlayer(string name) {
            var statement = "DELETE FROM Players WHERE Name=@newName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newName", name);

            int result = command.ExecuteNonQuery();
            //result.Close();
            if (result == 1)
                return true;
            else
                return false;
        }
    }
}