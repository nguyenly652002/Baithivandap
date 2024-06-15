using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThiKhanhLy_424.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Sinhvien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sinhviens",
                columns: table => new
                {
                    Masinhvien = table.Column<string>(type: "TEXT", nullable: false),
                    Tensinhvien = table.Column<int>(type: "INTEGER", nullable: false),
                    MaLop = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinhviens", x => x.Masinhvien);
                    table.ForeignKey(
                        name: "FK_Sinhviens_Lophocs_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lophocs",
                        principalColumn: "MaLop");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sinhviens_MaLop",
                table: "Sinhviens",
                column: "MaLop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sinhviens");
        }
    }
}
