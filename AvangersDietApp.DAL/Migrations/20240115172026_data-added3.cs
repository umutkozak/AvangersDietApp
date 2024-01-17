using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AvangersDietApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dataadded3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CategoryId", "Description", "Fats", "FoodStrategyId", "Image", "Name", "Proteins" },
                values: new object[,]
                {
                    { 2, 61.0, 4.7000000000000002, 5, null, 3.2999999999999998, null, null, "Yoğur", 3.5 },
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
                    { 37, 58.0, 15.0, 2, null, 0.59999999999999998, null, null, "Elma", 0.20000000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
