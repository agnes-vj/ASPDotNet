using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPNET.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "Description", "Rule" },
                values: new object[,]
                {
                    { 1, "testing", "No Touching Without Gloves" },
                    { 2, "Any visitor must compliment at least one treasure aloud upon entering the exhibit. Criticizing any piece will invoke a loud, disapproving echo that follows the offender for the duration of their visit.", "Treasure Compliments Only" },
                    { 3, "If you spot Poppy, you must immediately perform a joyful dance in her honor. Failure to do so will result in Poppy giving you the most disappointed look imaginable, followed by an inexplicable urge to break out in spontaneous dance for the rest of the day.", "Dance for Poppy" },
                    { 4, "Visitors must move slowly and gracefully near the Dragon's Fang Dagger, as sudden movements might awaken the dormant spirit of the dragon, causing temporary fire hazards.", "No Sudden Moves Near the Dragon's Fang Dagger" },
                    { 5, "Talking excessively about the latest internet trends, memes, or social media drama will result in an immediate case of 'brain rot.' Symptoms include saying 'lol' out loud, quoting obscure memes non-stop, and the inability to think about anything other than the latest viral video for 24 hours.", "Limit Your Internet Chatter" },
                    { 6, "To engage with any item in the Ancient Scroll section, one must speak only in riddles. Failure to do so will result in the scrolls shuffling themselves into confusing and endless new patterns.", "Speak in Riddles at the Ancient Scroll Display" },
                    { 7, "Whistling in the presence of the Jewels of Royalty will cause the gemstones to vibrate, resulting in a short-lived but dazzling light show. However, it may also summon a royal ghost seeking an audience.", "No Whistling in the Hall of Jewels" },
                    { 8, "If boardgames are mentioned, the shopkeeper (and everyone nearby) will start an unstoppable conversation about boardgames, reciting every obscure rule, strategy, and historical fact. The conversation will continue for hours, making it impossible to leave until you've learned at least three new games.", "No Mentioning Boardgames" },
                    { 9, "Visitors who approach the Pirate's Treasure Chest must knock on it twice before leaving. Forgetting this small ritual may trigger an ancient pirate's curse, resulting in an uncontrollable urge to speak in pirate slang for the rest of the day.", "Pirate's Treasure Chest Must Be Knocked On Twice" },
                    { 10, "To view the Ruby-Studded Chalice of the Sun up close, visitors must place a gold coin in the offering dish. If no offering is made, the chalice will glow dimly and quietly hum a melancholic tune.", "Offer One Gold Coin at the Chalice of the Sun" },
                    { 11, "testing", "Dance in the Moonlight" },
                    { 12, "Photography is only permitted if the treasure appears to smile at the photographer. Capturing a treasure's displeasure on camera could result in your images mysteriously vanishing from your device.", "No Photography Unless the Treasure Smiles" },
                    { 13, "Pippa's Rare Treasures is in no way associated with Poppy's Rare Treasures! Any implication otherwise will result in a stern lecture from Pippa about the importance of brand identity.", "No Association with Poppy's Rare Treasures" },
                    { 14, "Pippa's Rare Treasures is in no way associated with Poppy's Rare Treasures! Any implication otherwise will result in a stern lecture from Pippa about the importance of brand identity.", "No Association with Poppy's Rare Treasures" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rules");
        }
    }
}
