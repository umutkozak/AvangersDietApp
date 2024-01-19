using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AvangersDietApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodStrategy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodStrategy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    MealTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    Proteins = table.Column<double>(type: "float", nullable: false),
                    Fats = table.Column<double>(type: "float", nullable: false),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FoodStrategyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Food_FoodStrategy_FoodStrategyId",
                        column: x => x.FoodStrategyId,
                        principalTable: "FoodStrategy",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Et" },
                    { 2, "Meyve" },
                    { 3, "Sebze ve Bakliyat" },
                    { 4, "Atıştırmalık" },
                    { 5, "Süt Ürünleri" },
                    { 6, "Diğer Ürünler" },
                    { 7, "Unlu Ürünler" },
                    { 8, "Tatlılar" },
                    { 9, "Çerez ve Kuru Yemiş" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CategoryId", "Description", "Fats", "FoodStrategyId", "Image", "Name", "Proteins" },
                values: new object[,]
                {
                    { 1, 289.0, 0.0, 5, null, 4.4000000000000004, null, null, "Kaşar peynir", 22.5 },
                    { 2, 61.0, 4.7000000000000002, 5, null, 3.2999999999999998, null, null, "Yoğurt", 3.5 },
                    { 3, 158.0, 0.0, 6, null, 11.199999999999999, null, null, "Yumurta", 12.1 },
                    { 4, 207.0, 0.0, 6, null, 4.4000000000000004, null, null, "Siyah Zeytin", 0.14999999999999999 },
                    { 5, 25.0, 4.0, 3, null, 0.29999999999999999, null, null, "Domates", 1.0 },
                    { 6, 8.0, 1.0, 3, null, 0.0, null, null, "Salatalık", 1.0 },
                    { 7, 26.0, 0.59999999999999998, 3, null, 0.10000000000000001, null, null, "Kabak", 1.0 },
                    { 8, 25.0, 3.2000000000000002, 3, null, 0.29999999999999999, null, null, "Ispanak", 2.2999999999999998 },
                    { 9, 25.0, 4.9000000000000004, 3, null, 0.20000000000000001, null, null, "Karnabahar", 2.3999999999999999 },
                    { 10, 24.0, 5.2999999999999998, 3, null, 0.20000000000000001, null, null, "Lahana", 1.3999999999999999 },
                    { 11, 351.0, 57.399999999999999, 5, null, 1.3, null, null, "Mercimek", 23.699999999999999 },
                    { 12, 376.0, 56.700000000000003, 3, null, 6.2000000000000002, null, null, "Nohut", 19.199999999999999 },
                    { 13, 63.0, 11.9, 3, null, 0.40000000000000002, null, null, "Enginar", 2.8999999999999999 },
                    { 14, 52.0, 13.0, 3, null, 0.20000000000000001, null, null, "Pırasa", 1.8 },
                    { 15, 42.0, 4.0, 3, null, 0.10000000000000001, null, null, "Bamya", 6.0 },
                    { 16, 122.0, 0.0, 1, null, 3.0, null, null, "Tavuk-but", 21.0 },
                    { 17, 104.0, 0.0, 1, null, 1.0, null, null, "Tavuk-göğüs", 23.0 },
                    { 18, 160.0, 0.0, 1, null, 8.0, null, null, "Hindi", 20.399999999999999 },
                    { 19, 170.0, 0.0, 1, null, 3.6000000000000001, null, null, "Dana kıyma yağlı", 20.0 },
                    { 20, 156.0, 0.0, 1, null, 8.0, null, null, "Dana Eti", 19.699999999999999 },
                    { 21, 450.0, 0.0, 1, null, 38.100000000000001, null, null, "Salam", 23.399999999999999 },
                    { 22, 452.0, 0.0, 1, null, 21.399999999999999, null, null, "Sucuk", 21.399999999999999 },
                    { 23, 370.0, 75.200000000000003, 7, null, 1.2, null, null, "Makarna", 12.5 },
                    { 24, 452.0, 0.0, 7, null, 21.399999999999999, null, null, "Pirinç", 21.399999999999999 },
                    { 25, 357.0, 78.099999999999994, 7, null, 1.2, null, null, "Bulgur", 10.300000000000001 },
                    { 26, 247.0, 53.100000000000001, 7, null, 1.1000000000000001, null, null, "Buğday Ekmeği", 7.2000000000000002 },
                    { 27, 315.0, 78.400000000000006, 8, null, 0.0, null, null, "Bal", 0.29999999999999999 },
                    { 28, 550.0, 51.299999999999997, 8, null, 36.0, null, null, "Çikolata", 9.3000000000000007 },
                    { 29, 275.0, 70.0, 8, null, 0.5, null, null, "Marmelat ve Reçel", 0.59999999999999998 },
                    { 30, 173.0, 29.800000000000001, 8, null, 3.7999999999999998, null, null, "Muhallebi", 5.0999999999999996 },
                    { 31, 140.0, 38.0, 8, null, 2.7000000000000002, null, null, "Sütlaç", 3.3999999999999999 },
                    { 32, 600.0, 19.800000000000001, 9, null, 54.200000000000003, null, null, "Badem", 18.600000000000001 },
                    { 33, 650.0, 15.800000000000001, 9, null, 64.0, null, null, "Ceviz", 15.0 },
                    { 34, 634.0, 16.800000000000001, 9, null, 62.399999999999999, null, null, "Fındık", 12.6 },
                    { 35, 600.0, 19.0, 9, null, 54.0, null, null, "Şam Fıstığı", 19.5 },
                    { 36, 289.0, 0.0, 5, null, 4.4000000000000004, null, null, "Beyaz peynir", 22.5 },
                    { 37, 58.0, 15.0, 2, null, 0.59999999999999998, null, null, "Elma", 0.20000000000000001 },
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
                name: "IX_Food_FoodStrategyId",
                table: "Food",
                column: "FoodStrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFoods_FoodId",
                table: "UserMealFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFoods_MealId",
                table: "UserMealFoods",
                column: "MealId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "UserMealFoods");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "FoodStrategy");
        }
    }
}
