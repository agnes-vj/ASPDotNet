﻿namespace ASPNET
{
    public class Shops
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public string[] Inventory { get; set; } = [];
        public string OpeningHours { get; set; }
        public string Reputation { get; set; }
        public int FoundedYear { get; set; }

    }
}
