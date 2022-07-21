using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FullCRUD.Migrations
{
    public partial class CurdTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrudModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebsiteName = table.Column<string>(nullable: true),
                    HostingRenewalPrice = table.Column<int>(nullable: false),
                    HostingRenwalDate = table.Column<DateTime>(nullable: false),
                    DomainRenewalPrice = table.Column<int>(nullable: false),
                    DomainRenewalDate = table.Column<DateTime>(nullable: false),
                    AMCRenewalPrice = table.Column<int>(nullable: false),
                    AMCRenewalDate = table.Column<DateTime>(nullable: false),
                    SEORenewalPrice = table.Column<int>(nullable: false),
                    SEORenewalDate = table.Column<DateTime>(nullable: false),
                    PaymentMode = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrudModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrudModel");
        }
    }
}
