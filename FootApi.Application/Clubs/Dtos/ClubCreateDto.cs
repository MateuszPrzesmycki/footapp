﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApi.Application.Clubs.Dtos
{
    public class ClubCreateDto
    {
        public string ClubName { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string StadiumName { get; set; } = default!;
        public int FoundedYear { get; set; }
    }
}
