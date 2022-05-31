using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBooks.Migrations
{
    public partial class othertables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktiflik = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Makales",
                columns: table => new
                {
                    MakaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<int>(type: "int", nullable: false),
                    yazar = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makales", x => x.MakaleID);
                    table.ForeignKey(
                        name: "FK_Makales_Kategoris_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Makales_KategoriID",
                table: "Makales",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Makales");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
