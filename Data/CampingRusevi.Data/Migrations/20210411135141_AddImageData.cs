﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CampingRusevi.Data.Migrations
{
    public partial class AddImageData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginalFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ThumbnailContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FullscreenContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageData");
        }
    }
}
