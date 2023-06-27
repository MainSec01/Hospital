using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiseaseCause_Sickness_SicknessId",
                table: "DiseaseCause");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthyFood_Sickness_SicknessId",
                table: "HealthyFood");

            migrationBuilder.DropForeignKey(
                name: "FK_treatmentMethod_Sickness_SicknessId",
                table: "treatmentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_treatmentMethod",
                table: "treatmentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthyFood",
                table: "HealthyFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiseaseCause",
                table: "DiseaseCause");

            migrationBuilder.RenameTable(
                name: "treatmentMethod",
                newName: "TreatmentMethods");

            migrationBuilder.RenameTable(
                name: "HealthyFood",
                newName: "HealthyFoods");

            migrationBuilder.RenameTable(
                name: "DiseaseCause",
                newName: "DiseaseCauses");

            migrationBuilder.RenameIndex(
                name: "IX_treatmentMethod_SicknessId",
                table: "TreatmentMethods",
                newName: "IX_TreatmentMethods_SicknessId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthyFood_SicknessId",
                table: "HealthyFoods",
                newName: "IX_HealthyFoods_SicknessId");

            migrationBuilder.RenameIndex(
                name: "IX_DiseaseCause_SicknessId",
                table: "DiseaseCauses",
                newName: "IX_DiseaseCauses_SicknessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatmentMethods",
                table: "TreatmentMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthyFoods",
                table: "HealthyFoods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiseaseCauses",
                table: "DiseaseCauses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseCauses_Sickness_SicknessId",
                table: "DiseaseCauses",
                column: "SicknessId",
                principalTable: "Sickness",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthyFoods_Sickness_SicknessId",
                table: "HealthyFoods",
                column: "SicknessId",
                principalTable: "Sickness",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentMethods_Sickness_SicknessId",
                table: "TreatmentMethods",
                column: "SicknessId",
                principalTable: "Sickness",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiseaseCauses_Sickness_SicknessId",
                table: "DiseaseCauses");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthyFoods_Sickness_SicknessId",
                table: "HealthyFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentMethods_Sickness_SicknessId",
                table: "TreatmentMethods");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatmentMethods",
                table: "TreatmentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthyFoods",
                table: "HealthyFoods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiseaseCauses",
                table: "DiseaseCauses");

            migrationBuilder.RenameTable(
                name: "TreatmentMethods",
                newName: "treatmentMethod");

            migrationBuilder.RenameTable(
                name: "HealthyFoods",
                newName: "HealthyFood");

            migrationBuilder.RenameTable(
                name: "DiseaseCauses",
                newName: "DiseaseCause");

            migrationBuilder.RenameIndex(
                name: "IX_TreatmentMethods_SicknessId",
                table: "treatmentMethod",
                newName: "IX_treatmentMethod_SicknessId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthyFoods_SicknessId",
                table: "HealthyFood",
                newName: "IX_HealthyFood_SicknessId");

            migrationBuilder.RenameIndex(
                name: "IX_DiseaseCauses_SicknessId",
                table: "DiseaseCause",
                newName: "IX_DiseaseCause_SicknessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_treatmentMethod",
                table: "treatmentMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthyFood",
                table: "HealthyFood",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiseaseCause",
                table: "DiseaseCause",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseCause_Sickness_SicknessId",
                table: "DiseaseCause",
                column: "SicknessId",
                principalTable: "Sickness",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthyFood_Sickness_SicknessId",
                table: "HealthyFood",
                column: "SicknessId",
                principalTable: "Sickness",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_treatmentMethod_Sickness_SicknessId",
                table: "treatmentMethod",
                column: "SicknessId",
                principalTable: "Sickness",
                principalColumn: "Id");
        }
    }
}
