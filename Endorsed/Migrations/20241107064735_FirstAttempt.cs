using Microsoft.EntityFrameworkCore.Migrations;

namespace Endorsed.Migrations
{
    public partial class FirstAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseNumber = table.Column<long>(nullable: false),
                    StreetName = table.Column<string>(nullable: true),
                    SurburbName = table.Column<string>(nullable: false),
                    CityName = table.Column<string>(nullable: false),
                    ProvinceID = table.Column<int>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    QualificationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualififcationName = table.Column<string>(nullable: false),
                    QualificationLevel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.QualificationID);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(nullable: false),
                    AddressID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceID);
                    table.ForeignKey(
                        name: "FK_Provinces_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressLinks",
                columns: table => new
                {
                    AddressLinkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressID = table.Column<int>(nullable: false),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressLinks", x => x.AddressLinkID);
                    table.ForeignKey(
                        name: "FK_AddressLinks_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressLinks_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QualificationLinks",
                columns: table => new
                {
                    QualificationLinkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualificationDescription = table.Column<string>(nullable: true),
                    PersonID = table.Column<int>(nullable: false),
                    QualificationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualificationLinks", x => x.QualificationLinkID);
                    table.ForeignKey(
                        name: "FK_QualificationLinks_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QualificationLinks_Qualifications_QualificationID",
                        column: x => x.QualificationID,
                        principalTable: "Qualifications",
                        principalColumn: "QualificationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressLinks_AddressID",
                table: "AddressLinks",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLinks_PersonID",
                table: "AddressLinks",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_AddressID",
                table: "Provinces",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_QualificationLinks_PersonID",
                table: "QualificationLinks",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_QualificationLinks_QualificationID",
                table: "QualificationLinks",
                column: "QualificationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressLinks");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "QualificationLinks");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Qualifications");
        }
    }
}
