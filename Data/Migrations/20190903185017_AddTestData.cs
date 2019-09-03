using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfo.Data.Migrations
{
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Place_PlaceType_TypeId",
                table: "Place");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Place",
                table: "Place");

            migrationBuilder.RenameTable(
                name: "Place",
                newName: "Places");

            migrationBuilder.RenameIndex(
                name: "IX_Place_TypeId",
                table: "Places",
                newName: "IX_Places_TypeId");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Places",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Places",
                table: "Places",
                column: "Id");

            migrationBuilder.InsertData(
                table: "PlaceType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "City" });

            migrationBuilder.InsertData(
                table: "PlaceType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Town" });

            migrationBuilder.InsertData(
                table: "PlaceType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Village" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Name", "Population", "TypeId" },
                values: new object[,]
                {
                    { 1, "London", 0, 1 },
                    { 2, "Aberdeen", 0, 1 },
                    { 5, "Carlisle", 0, 1 },
                    { 3, "Barnsley", 0, 2 },
                    { 4, "Barking", 0, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Places_PlaceType_TypeId",
                table: "Places",
                column: "TypeId",
                principalTable: "PlaceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_PlaceType_TypeId",
                table: "Places");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Places",
                table: "Places");

            migrationBuilder.DeleteData(
                table: "PlaceType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlaceType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaceType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Places",
                newName: "Place");

            migrationBuilder.RenameIndex(
                name: "IX_Places_TypeId",
                table: "Place",
                newName: "IX_Place_TypeId");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Place",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Place",
                table: "Place",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Place_PlaceType_TypeId",
                table: "Place",
                column: "TypeId",
                principalTable: "PlaceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
