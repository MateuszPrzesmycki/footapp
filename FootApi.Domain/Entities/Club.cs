using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApi.Domain.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string ClubName { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string StadiumName { get; set; } = default!;
        public int FoundedYear { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
    }
}
