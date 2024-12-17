﻿// <auto-generated />
using ASPNET;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPNET.Migrations
{
    [DbContext(typeof(ASPDbContext))]
    [Migration("20241217153533_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
#pragma warning restore 612, 618
        }
    }
}
