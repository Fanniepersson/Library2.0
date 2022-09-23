using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library2._0.Migrations
{
    public partial class firstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Langugage = table.Column<string>(nullable: false),
                    ReleaseYear = table.Column<string>(nullable: false),
                    AmountOfThisBook = table.Column<int>(nullable: false),
                    Avaliable = table.Column<bool>(nullable: false),
                    ImageThmbnailUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "LibraryLoans",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfLoan = table.Column<DateTime>(nullable: false),
                    LastDayToReturn = table.Column<DateTime>(nullable: false),
                    DayOfReturn = table.Column<DateTime>(nullable: false),
                    IsReturned = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryLoans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_LibraryLoans_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryLoans_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AmountOfThisBook", "Author", "Avaliable", "ImageThmbnailUrl", "Langugage", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, 5, "Zlatan Ibrahimovic, David Lagercrantz", true, "\\images\\jag-ar-zlatan-ibrahimovic-min-historia.jpg", "English", "2019", "Jag är Zlatan Ibrahimovic: Min historia" },
                    { 2, 4, "Camilla Läckberg", false, "\\images\\en-bur-av-guld.jpg", "Swedish", "2020", "En bur av guld" },
                    { 3, 2, "Camilla Läckberg", false, "\\images\\vingar-av-silver.jpg", "Swedish", "2021", "Vingar av silver" },
                    { 4, 1, "Camilla Läckberg", false, "\\images\\gokungen.jpg", "Swedish", "2022", "Gökungen" },
                    { 5, 2, "Camilla Läckberg", false, "\\images\\isprinsessan.jpg", "Swedish", "2017", "Isprinsessan" },
                    { 6, 1, "Camilla Läckberg", false, "\\images\\lejontamjaren.jpg", "Swedish", "2017", "Lejontämjaren" },
                    { 7, 4, "Isabella Löwengrip", false, "\\images\\isabella.jpg", "Swedish", "2022", "Isabella" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "FirstName", "LastName", "PhoneNumber", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Prestbury Square", "New York", "Jay", "Duffy", "123456789", "223345" },
                    { 2, "Fifth Avenue", "New York", "Emma", "Madison", "684747382", "347363" },
                    { 3, "Rodeo Drive", "Beverly Hills", "Cora", "Ashley", "094853213", "586732" },
                    { 4, "Griffin Street", "Phoenix", "Hayes", "Robinson", "084231496", "850413" }
                });

            migrationBuilder.InsertData(
                table: "LibraryLoans",
                columns: new[] { "LoanId", "BookId", "CustomerId", "DayOfLoan", "DayOfReturn", "IsReturned", "LastDayToReturn" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 9, 22, 15, 48, 54, 327, DateTimeKind.Local).AddTicks(1110), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(1145) },
                    { 2, 2, 1, new DateTime(2022, 9, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2120), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2145) },
                    { 3, 2, 2, new DateTime(2022, 9, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2207), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2211) },
                    { 4, 7, 2, new DateTime(2022, 9, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2242), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2246) },
                    { 8, 2, 2, new DateTime(2022, 9, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2370) },
                    { 5, 6, 3, new DateTime(2022, 9, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2278) },
                    { 6, 7, 3, new DateTime(2022, 9, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2308), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2312) },
                    { 7, 3, 4, new DateTime(2022, 9, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 15, 48, 54, 331, DateTimeKind.Local).AddTicks(2341) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryLoans_BookId",
                table: "LibraryLoans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryLoans_CustomerId",
                table: "LibraryLoans",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryLoans");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
