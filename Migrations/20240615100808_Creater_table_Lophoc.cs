using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThiKhanhLy_424.Migrations
{
    /// <inheritdoc />
    public partial class Creater_table_Lophoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lophocs",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "TEXT", nullable: false),
                    TenLop = table.Column<int>(type: "INTEGER", nullable: false),
                    SoTT = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lophocs", x => x.MaLop);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lophocs");
        }
    }
}
