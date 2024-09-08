using FootApi.Domain.Entities;
using FootApi.Infrastructure.DbConextMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApi.Infrastructure.Seeders
{
    internal class ClubSeeder(FootApiDbContext dbContext) : IClubSeeder
    {
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.Clubs.Any())
                {
                    List<Club> clubs = new List<Club>()
                    {
                        new Club()
                        {
                            ClubName = "Fc Barcelona",
                            StadiumName = "Camp Nou",
                            Country = "Spain",
                            FoundedYear = 1900,
                            WhenCreated = DateTime.Now,
                            Players = new List<Player>()
                            {
                                new Player()
                                {
                                    DateOfBirth = new DateTime(1990, 01, 01),
                                    FirstName = "Test",
                                    LastName = "Test",
                                    Height = 180,
                                    Weight = 70,
                                    Nationality = "Spain",
                                    Position = "ST",
                                    WhenCreated = DateTime.Now
                                }
                            }
                        }

                    };
                    dbContext.Clubs.AddRange(clubs);
                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
