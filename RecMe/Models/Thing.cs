﻿namespace RecMe.Models
{
    public class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ?UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
