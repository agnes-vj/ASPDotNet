using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPNET.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginStory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inventory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reputation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundedYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treasures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Name", "Description", "Mission", "OriginStory" },
                values: new object[] { "Pippa's Rare Treasures", "Pippa's Rare Treasures is an exquisite collection of rare and legendary artifacts, gathered from the most distant and mysterious corners of the world. From enchanted jewels to ancient relics, each piece holds its own story, representing the pinnacle of craftsmanship and history.", "Our mission is to preserve and showcase the most extraordinary and valuable treasures ever discovered, allowing adventurers, collectors, and historians to experience the magic and wonder of forgotten realms.", "Pippa Pom, an adventurous soul with a thirst for discovery, started her collection after uncovering a rare artifact during an expedition to the Lost Kingdom. Since then, her passion for hunting down hidden treasures has turned into a renowned collection admired by many." });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Description", "FoundedYear", "Inventory", "Location", "Name", "OpeningHours", "Owner", "Reputation", "Type" },
                values: new object[,]
                {
                    { 1, "A well-known general store offering a variety of goods, from food to adventuring gear.", 50, "[]", "Main Street, Capital City", "The Golden Coin", "8 AM - 8 PM", "Marcus Goldfinger", "Trusted", "General Store" },
                    { 2, "A mystical shop filled with rare and powerful magical items.", 112, "[]", "Wizard's District, Silverport", "Arcturus's Arcane Emporium", "10 AM - 6 PM", "Arcturus the Wise", "Respected", "Magic Shop" },
                    { 3, "A renowned blacksmith offering expertly crafted weapons and armor.", 85, "[]", "Forge Alley, Stonehold", "The Silver Dagger", "7 AM - 5 PM", "Hrogar Ironforge", "Renowned", "Blacksmith" },
                    { 4, "A tailor shop known for its enchanted and elegant garments.", 95, "[]", "Market Square, Elvenholm", "The Enchanted Needle", "9 AM - 6 PM", "Elyndra Moonweaver", "Esteemed", "Tailor Shop" },
                    { 5, "A popular tavern for sailors, known for its strong drinks and lively atmosphere.", 70, "[]", "Dockside, Seabreeze", "The Crimson Chalice", "12 PM - 2 AM", "Captain Redbeard", "Infamous", "Tavern" },
                    { 6, "A well-known general store offering a variety of goods, from food to adventuring gear.", 50, "[]", "Main Street, Capital City", "The Golden Coin", "8 AM - 8 PM", "Marcus Goldfinger", "Trusted", "General Store" }
                });

            migrationBuilder.InsertData(
                table: "Treasures",
                columns: new[] { "Id", "Description", "Material", "Name", "Origin", "Rarity", "Type", "Value", "Weight" },
                values: new object[,]
                {
                    { 1, "A magnificent crown made of pure gold, adorned with rare gems.", "Gold", "Golden Crown", "Ancient Kingdom", "Legendary", "Jewelry", 50000, "2 kg" },
                    { 2, "An ancient, leather-bound tome containing forgotten knowledge and the cryptic writings of Neil, an eccentric scholar. It is said that reading too much of the book at once can drive a person to madness, but those who master its secrets are rewarded with incredible insight.", "Leather-bound with silver inlay", "Neil's Book", "Library of Shadows", "Mythical", "Book", 75000, "1.5 kg" },
                    { 3, "These legendary football boots, once worn by Alice the Undefeated, are made from rare dragonhide leather. They are said to grant the wearer unmatched speed, agility, and the ability to bend the ball in impossible ways. Legends claim that those who wear them can never lose a match—but only if they believe in the magic.", "Dragonhide Leather", "Alice's Football Boots", "Tournament of Champions", "Legendary", "Footwear", 120000, "0.8 kg" },
                    { 4, "A delicate silver necklace with a large sapphire centerpiece.", "Silver", "Sapphire Necklace", "Royal Family", "Rare", "Jewelry", 15000, "0.5 kg" },
                    { 5, "An ancient scroll containing powerful spells written in an extinct language.", "Papyrus", "Ancient Scroll", "Forgotten Empire", "Epic", "Artifact", 8000, "0.2 kg" },
                    { 6, "A deadly dagger carved from the fang of a dragon, rumored to be unbreakable.", "Dragon Fang", "Dragon's Fang Dagger", "Dragon Slayers Guild", "Legendary", "Weapon", 30000, "0.3 kg" },
                    { 7, "A small leather bag filled with coins from ancient civilizations.", "Gold and Silver", "Bag of Rare Coins", "Lost Merchant Ship", "Uncommon", "Currency", 10000, "1 kg" },
                    { 8, "A ceremonial chalice studded with rubies, used in ancient rituals.", "Gold", "Ruby-Studded Chalice", "Temple of the Sun", "Epic", "Relic", 25000, "1.5 kg" },
                    { 9, "An amulet with mystical powers, said to protect the wearer from harm.", "Bronze", "Enchanted Amulet", "Mystic Forest", "Epic", "Jewelry", 12000, "0.3 kg" },
                    { 10, "A large chest filled with gold, gems, and rare artifacts, rumored to be cursed.", "Wood and Iron", "Pirate's Treasure Chest", "Sunken Pirate Ship", "Legendary", "Container", 40000, "30 kg" },
                    { 11, "A beautifully crafted silver chalice said to hold lunar powers.", "Silver", "Silver Chalice of the Moon", "Temple of the Moon", "Rare", "Relic", 18000, "1 kg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Treasures");
        }
    }
}
