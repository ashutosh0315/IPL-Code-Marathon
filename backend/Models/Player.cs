﻿namespace IPL_API.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int TeamId { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
        public int MatchesPlayed { get; set; }
        public Team Team { get; set; }
    }
}
