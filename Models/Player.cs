namespace PlayerApi.Models
{
    public class Player {
        public string Name {get; set;}
        public int Age {get; set;}
        public string Sport {get; set;}
        public string Team {get; set;}
        public string Position {get; set;}

        public override string ToString() {
            return $"{Name}, {Age}, {Team}, {Position}";    
        }
    }
}