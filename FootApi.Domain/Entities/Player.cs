namespace FootApi.Domain.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; } = default!;
        public string Position { get; set; } = default!;
        public float Height { get; set; }
        public float Weight { get; set; }

        public int? CurrentClubId { get; set; }
        public Club? CurrentClub { get; set; } 
    }
}
