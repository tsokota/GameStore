﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Domain.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
