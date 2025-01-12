﻿// <auto-generated />
using ASPNET;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPNET.Migrations
{
    [DbContext(typeof(ASPDbContext))]
    partial class ASPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASPNET.About", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginStory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("About");

                    b.HasData(
                        new
                        {
                            Name = "Pippa's Rare Treasures",
                            Description = "Pippa's Rare Treasures is an exquisite collection of rare and legendary artifacts, gathered from the most distant and mysterious corners of the world. From enchanted jewels to ancient relics, each piece holds its own story, representing the pinnacle of craftsmanship and history.",
                            Mission = "Our mission is to preserve and showcase the most extraordinary and valuable treasures ever discovered, allowing adventurers, collectors, and historians to experience the magic and wonder of forgotten realms.",
                            OriginStory = "Pippa Pom, an adventurous soul with a thirst for discovery, started her collection after uncovering a rare artifact during an expedition to the Lost Kingdom. Since then, her passion for hunting down hidden treasures has turned into a renowned collection admired by many."
                        });
                });

            modelBuilder.Entity("ASPNET.Rules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "testing",
                            Rule = "No Touching Without Gloves"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Any visitor must compliment at least one treasure aloud upon entering the exhibit. Criticizing any piece will invoke a loud, disapproving echo that follows the offender for the duration of their visit.",
                            Rule = "Treasure Compliments Only"
                        },
                        new
                        {
                            Id = 3,
                            Description = "If you spot Poppy, you must immediately perform a joyful dance in her honor. Failure to do so will result in Poppy giving you the most disappointed look imaginable, followed by an inexplicable urge to break out in spontaneous dance for the rest of the day.",
                            Rule = "Dance for Poppy"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Visitors must move slowly and gracefully near the Dragon's Fang Dagger, as sudden movements might awaken the dormant spirit of the dragon, causing temporary fire hazards.",
                            Rule = "No Sudden Moves Near the Dragon's Fang Dagger"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Talking excessively about the latest internet trends, memes, or social media drama will result in an immediate case of 'brain rot.' Symptoms include saying 'lol' out loud, quoting obscure memes non-stop, and the inability to think about anything other than the latest viral video for 24 hours.",
                            Rule = "Limit Your Internet Chatter"
                        },
                        new
                        {
                            Id = 6,
                            Description = "To engage with any item in the Ancient Scroll section, one must speak only in riddles. Failure to do so will result in the scrolls shuffling themselves into confusing and endless new patterns.",
                            Rule = "Speak in Riddles at the Ancient Scroll Display"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Whistling in the presence of the Jewels of Royalty will cause the gemstones to vibrate, resulting in a short-lived but dazzling light show. However, it may also summon a royal ghost seeking an audience.",
                            Rule = "No Whistling in the Hall of Jewels"
                        },
                        new
                        {
                            Id = 8,
                            Description = "If boardgames are mentioned, the shopkeeper (and everyone nearby) will start an unstoppable conversation about boardgames, reciting every obscure rule, strategy, and historical fact. The conversation will continue for hours, making it impossible to leave until you've learned at least three new games.",
                            Rule = "No Mentioning Boardgames"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Visitors who approach the Pirate's Treasure Chest must knock on it twice before leaving. Forgetting this small ritual may trigger an ancient pirate's curse, resulting in an uncontrollable urge to speak in pirate slang for the rest of the day.",
                            Rule = "Pirate's Treasure Chest Must Be Knocked On Twice"
                        },
                        new
                        {
                            Id = 10,
                            Description = "To view the Ruby-Studded Chalice of the Sun up close, visitors must place a gold coin in the offering dish. If no offering is made, the chalice will glow dimly and quietly hum a melancholic tune.",
                            Rule = "Offer One Gold Coin at the Chalice of the Sun"
                        },
                        new
                        {
                            Id = 11,
                            Description = "testing",
                            Rule = "Dance in the Moonlight"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Photography is only permitted if the treasure appears to smile at the photographer. Capturing a treasure's displeasure on camera could result in your images mysteriously vanishing from your device.",
                            Rule = "No Photography Unless the Treasure Smiles"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Pippa's Rare Treasures is in no way associated with Poppy's Rare Treasures! Any implication otherwise will result in a stern lecture from Pippa about the importance of brand identity.",
                            Rule = "No Association with Poppy's Rare Treasures"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Pippa's Rare Treasures is in no way associated with Poppy's Rare Treasures! Any implication otherwise will result in a stern lecture from Pippa about the importance of brand identity.",
                            Rule = "No Association with Poppy's Rare Treasures"
                        });
                });

            modelBuilder.Entity("ASPNET.Shops", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoundedYear")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("Inventory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reputation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A well-known general store offering a variety of goods, from food to adventuring gear.",
                            FoundedYear = 50,
                            Inventory = "[]",
                            Location = "Main Street, Capital City",
                            Name = "The Golden Coin",
                            OpeningHours = "8 AM - 8 PM",
                            Owner = "Marcus Goldfinger",
                            Reputation = "Trusted",
                            Type = "General Store"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A mystical shop filled with rare and powerful magical items.",
                            FoundedYear = 112,
                            Inventory = "[]",
                            Location = "Wizard's District, Silverport",
                            Name = "Arcturus's Arcane Emporium",
                            OpeningHours = "10 AM - 6 PM",
                            Owner = "Arcturus the Wise",
                            Reputation = "Respected",
                            Type = "Magic Shop"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A renowned blacksmith offering expertly crafted weapons and armor.",
                            FoundedYear = 85,
                            Inventory = "[]",
                            Location = "Forge Alley, Stonehold",
                            Name = "The Silver Dagger",
                            OpeningHours = "7 AM - 5 PM",
                            Owner = "Hrogar Ironforge",
                            Reputation = "Renowned",
                            Type = "Blacksmith"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A tailor shop known for its enchanted and elegant garments.",
                            FoundedYear = 95,
                            Inventory = "[]",
                            Location = "Market Square, Elvenholm",
                            Name = "The Enchanted Needle",
                            OpeningHours = "9 AM - 6 PM",
                            Owner = "Elyndra Moonweaver",
                            Reputation = "Esteemed",
                            Type = "Tailor Shop"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A popular tavern for sailors, known for its strong drinks and lively atmosphere.",
                            FoundedYear = 70,
                            Inventory = "[]",
                            Location = "Dockside, Seabreeze",
                            Name = "The Crimson Chalice",
                            OpeningHours = "12 PM - 2 AM",
                            Owner = "Captain Redbeard",
                            Reputation = "Infamous",
                            Type = "Tavern"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A well-known general store offering a variety of goods, from food to adventuring gear.",
                            FoundedYear = 50,
                            Inventory = "[]",
                            Location = "Main Street, Capital City",
                            Name = "The Golden Coin",
                            OpeningHours = "8 AM - 8 PM",
                            Owner = "Marcus Goldfinger",
                            Reputation = "Trusted",
                            Type = "General Store"
                        });
                });

            modelBuilder.Entity("ASPNET.Treasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Treasures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A magnificent crown made of pure gold, adorned with rare gems.",
                            Material = "Gold",
                            Name = "Golden Crown",
                            Origin = "Ancient Kingdom",
                            Rarity = "Legendary",
                            Type = "Jewelry",
                            Value = 50000,
                            Weight = "2 kg"
                        },
                        new
                        {
                            Id = 2,
                            Description = "An ancient, leather-bound tome containing forgotten knowledge and the cryptic writings of Neil, an eccentric scholar. It is said that reading too much of the book at once can drive a person to madness, but those who master its secrets are rewarded with incredible insight.",
                            Material = "Leather-bound with silver inlay",
                            Name = "Neil's Book",
                            Origin = "Library of Shadows",
                            Rarity = "Mythical",
                            Type = "Book",
                            Value = 75000,
                            Weight = "1.5 kg"
                        },
                        new
                        {
                            Id = 3,
                            Description = "These legendary football boots, once worn by Alice the Undefeated, are made from rare dragonhide leather. They are said to grant the wearer unmatched speed, agility, and the ability to bend the ball in impossible ways. Legends claim that those who wear them can never lose a match—but only if they believe in the magic.",
                            Material = "Dragonhide Leather",
                            Name = "Alice's Football Boots",
                            Origin = "Tournament of Champions",
                            Rarity = "Legendary",
                            Type = "Footwear",
                            Value = 120000,
                            Weight = "0.8 kg"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A delicate silver necklace with a large sapphire centerpiece.",
                            Material = "Silver",
                            Name = "Sapphire Necklace",
                            Origin = "Royal Family",
                            Rarity = "Rare",
                            Type = "Jewelry",
                            Value = 15000,
                            Weight = "0.5 kg"
                        },
                        new
                        {
                            Id = 5,
                            Description = "An ancient scroll containing powerful spells written in an extinct language.",
                            Material = "Papyrus",
                            Name = "Ancient Scroll",
                            Origin = "Forgotten Empire",
                            Rarity = "Epic",
                            Type = "Artifact",
                            Value = 8000,
                            Weight = "0.2 kg"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A deadly dagger carved from the fang of a dragon, rumored to be unbreakable.",
                            Material = "Dragon Fang",
                            Name = "Dragon's Fang Dagger",
                            Origin = "Dragon Slayers Guild",
                            Rarity = "Legendary",
                            Type = "Weapon",
                            Value = 30000,
                            Weight = "0.3 kg"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A small leather bag filled with coins from ancient civilizations.",
                            Material = "Gold and Silver",
                            Name = "Bag of Rare Coins",
                            Origin = "Lost Merchant Ship",
                            Rarity = "Uncommon",
                            Type = "Currency",
                            Value = 10000,
                            Weight = "1 kg"
                        },
                        new
                        {
                            Id = 8,
                            Description = "A ceremonial chalice studded with rubies, used in ancient rituals.",
                            Material = "Gold",
                            Name = "Ruby-Studded Chalice",
                            Origin = "Temple of the Sun",
                            Rarity = "Epic",
                            Type = "Relic",
                            Value = 25000,
                            Weight = "1.5 kg"
                        },
                        new
                        {
                            Id = 9,
                            Description = "An amulet with mystical powers, said to protect the wearer from harm.",
                            Material = "Bronze",
                            Name = "Enchanted Amulet",
                            Origin = "Mystic Forest",
                            Rarity = "Epic",
                            Type = "Jewelry",
                            Value = 12000,
                            Weight = "0.3 kg"
                        },
                        new
                        {
                            Id = 10,
                            Description = "A large chest filled with gold, gems, and rare artifacts, rumored to be cursed.",
                            Material = "Wood and Iron",
                            Name = "Pirate's Treasure Chest",
                            Origin = "Sunken Pirate Ship",
                            Rarity = "Legendary",
                            Type = "Container",
                            Value = 40000,
                            Weight = "30 kg"
                        },
                        new
                        {
                            Id = 11,
                            Description = "A beautifully crafted silver chalice said to hold lunar powers.",
                            Material = "Silver",
                            Name = "Silver Chalice of the Moon",
                            Origin = "Temple of the Moon",
                            Rarity = "Rare",
                            Type = "Relic",
                            Value = 18000,
                            Weight = "1 kg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
