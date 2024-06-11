using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class AddTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpack_Character_CharacterId",
                table: "Backpack");

            migrationBuilder.DropForeignKey(
                name: "FK_Backpack_Item_ItemId",
                table: "Backpack");

            migrationBuilder.DropForeignKey(
                name: "FK_CharactersTitle_Character_CharacterId",
                table: "CharactersTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_CharactersTitle_Title_TitleId",
                table: "CharactersTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Title",
                table: "Title");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharactersTitle",
                table: "CharactersTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Character",
                table: "Character");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backpack",
                table: "Backpack");

            migrationBuilder.RenameTable(
                name: "Title",
                newName: "Titles");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "CharactersTitle",
                newName: "CharactersTitles");

            migrationBuilder.RenameTable(
                name: "Character",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "Backpack",
                newName: "backpacks");

            migrationBuilder.RenameIndex(
                name: "IX_CharactersTitle_TitleId",
                table: "CharactersTitles",
                newName: "IX_CharactersTitles_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Backpack_ItemId",
                table: "backpacks",
                newName: "IX_backpacks_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Titles",
                table: "Titles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharactersTitles",
                table: "CharactersTitles",
                columns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks",
                columns: new[] { "CharacterId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_Characters_CharacterId",
                table: "backpacks",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_Items_ItemId",
                table: "backpacks",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersTitles_Characters_CharacterId",
                table: "CharactersTitles",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersTitles_Titles_TitleId",
                table: "CharactersTitles",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_Characters_CharacterId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_Items_ItemId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharactersTitles_Characters_CharacterId",
                table: "CharactersTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_CharactersTitles_Titles_TitleId",
                table: "CharactersTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Titles",
                table: "Titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharactersTitles",
                table: "CharactersTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks");

            migrationBuilder.RenameTable(
                name: "Titles",
                newName: "Title");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "CharactersTitles",
                newName: "CharactersTitle");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Character");

            migrationBuilder.RenameTable(
                name: "backpacks",
                newName: "Backpack");

            migrationBuilder.RenameIndex(
                name: "IX_CharactersTitles_TitleId",
                table: "CharactersTitle",
                newName: "IX_CharactersTitle_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_backpacks_ItemId",
                table: "Backpack",
                newName: "IX_Backpack_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Title",
                table: "Title",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharactersTitle",
                table: "CharactersTitle",
                columns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Character",
                table: "Character",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backpack",
                table: "Backpack",
                columns: new[] { "CharacterId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Backpack_Character_CharacterId",
                table: "Backpack",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Backpack_Item_ItemId",
                table: "Backpack",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersTitle_Character_CharacterId",
                table: "CharactersTitle",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharactersTitle_Title_TitleId",
                table: "CharactersTitle",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
