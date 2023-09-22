using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOFEThesis.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacePictures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacePictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmbiguousSituation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldOfStudy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaceConditions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    FacePictureId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaceConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaceConditions_FacePictures_FacePictureId",
                        column: x => x.FacePictureId,
                        principalTable: "FacePictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CompoundConditions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    PictureId = table.Column<long>(type: "bigint", nullable: false),
                    FirstFacePictureId = table.Column<long>(type: "bigint", nullable: false),
                    SecondFacePictureId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompoundConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompoundConditions_FacePictures_FirstFacePictureId",
                        column: x => x.FirstFacePictureId,
                        principalTable: "FacePictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CompoundConditions_FacePictures_SecondFacePictureId",
                        column: x => x.SecondFacePictureId,
                        principalTable: "FacePictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CompoundConditions_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SelfConditions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureId = table.Column<long>(type: "bigint", nullable: false),
                    Order = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelfConditions_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompoundConditions_FirstFacePictureId",
                table: "CompoundConditions",
                column: "FirstFacePictureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompoundConditions_PictureId",
                table: "CompoundConditions",
                column: "PictureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompoundConditions_SecondFacePictureId",
                table: "CompoundConditions",
                column: "SecondFacePictureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FaceConditions_FacePictureId",
                table: "FaceConditions",
                column: "FacePictureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SelfConditions_PictureId",
                table: "SelfConditions",
                column: "PictureId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompoundConditions");

            migrationBuilder.DropTable(
                name: "FaceConditions");

            migrationBuilder.DropTable(
                name: "SelfConditions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FacePictures");

            migrationBuilder.DropTable(
                name: "Pictures");
        }
    }
}
