﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAB.Migrations
{
    /// <inheritdoc />
    public partial class AddManagerRelationToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_ManagerId",
                table: "Users",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                 name: "FK_Users_Users_ManagerId",
                 table: "Users",
                 column: "ManagerId",
                 principalTable: "Users",
                 principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ManagerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ManagerId",
                table: "Users");
        }
    }
}