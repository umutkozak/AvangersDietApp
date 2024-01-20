using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AvangersDietApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "CategoryName");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Calorie",
                table: "Meals",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserMealFoods",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMealFoods", x => new { x.UserId, x.MealId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_UserMealFoods_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMealFoods_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMealFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Yoğurt");

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CategoryId", "Description", "Fats", "FoodStrategyId", "Image", "Name", "Proteins" },
                values: new object[,]
                {
                    { 1, 289.0, 0.0, 5, null, 4.4000000000000004, null, null, "Kaşar peynir", 22.5 },
                    { 38, 61.0, 15.300000000000001, 2, null, 0.40000000000000002, null, null, "Armut", 0.69999999999999996 },
                    { 39, 37.0, 8.4000000000000004, 2, null, 0.5, null, null, "Çilek", 0.69999999999999996 },
                    { 40, 80.0, 20.399999999999999, 2, null, 0.40000000000000002, null, null, "İncir", 1.2 },
                    { 41, 51.0, 12.9, 2, null, 0.20000000000000001, null, null, "Kayısı", 1.0 },
                    { 42, 70.0, 17.399999999999999, 2, null, 0.29999999999999999, null, null, "Kiraz", 1.3 },
                    { 43, 50.0, 12.300000000000001, 2, null, 0.20000000000000001, null, null, "Portakal", 1.0 },
                    { 44, 85.0, 9.6999999999999993, 2, null, 0.20000000000000001, null, null, "Şeftali", 0.59999999999999998 },
                    { 45, 50.0, 11.6, 2, null, 0.20000000000000001, null, null, "Muz", 1.1000000000000001 },
                    { 46, 168.0, 0.0, 1, null, 7.2999999999999998, null, null, "Palamut", 24.0 },
                    { 47, 168.0, 0.0, 1, null, 10.0, null, null, "Alabalık", 18.300000000000001 },
                    { 48, 93.0, 0.0, 1, null, 1.2, null, null, "Levrek", 19.199999999999999 },
                    { 49, 159.0, 0.0, 1, null, 7.2999999999999998, null, null, "Uskumru", 21.899999999999999 },
                    { 50, 168.0, 0.0, 1, null, 7.2999999999999998, null, null, "Palamut", 24.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_CategoryId",
                table: "Food",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFoods_FoodId",
                table: "UserMealFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFoods_MealId",
                table: "UserMealFoods",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Category_CategoryId",
                table: "Food",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Category_CategoryId",
                table: "Food");

            migrationBuilder.DropTable(
                name: "UserMealFoods");

            migrationBuilder.DropIndex(
                name: "IX_Food_CategoryId",
                table: "Food");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Calorie",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Category",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredients_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Yoğur");

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CategoryId", "Description", "Fats", "FoodStrategyId", "Image", "Name", "Proteins" },
                values: new object[] { -1, 289.0, 0.0, 5, null, 4.4000000000000004, null, null, "Kaşar peynir", 22.5 });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_FoodId",
                table: "Ingredients",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MealId",
                table: "Ingredients",
                column: "MealId");
        }
    }
}
