﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DBMProject.Migrations
{
    public partial class coordenadas_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Projeto_ProjetoId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Projeto_AcademicDegrees_AcademicDegreeId",
                table: "Projeto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projeto",
                table: "Projeto");

            migrationBuilder.RenameTable(
                name: "Projeto",
                newName: "Projetos");

            migrationBuilder.RenameIndex(
                name: "IX_Projeto_AcademicDegreeId",
                table: "Projetos",
                newName: "IX_Projetos_AcademicDegreeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projetos",
                table: "Projetos",
                column: "ProjetoId");

            migrationBuilder.CreateTable(
                name: "Coordenadas",
                columns: table => new
                {
                    CoordenadasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altitude = table.Column<double>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordenadas", x => x.CoordenadasId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Projetos_ProjetoId",
                table: "Comentarios",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "ProjetoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_AcademicDegrees_AcademicDegreeId",
                table: "Projetos",
                column: "AcademicDegreeId",
                principalTable: "AcademicDegrees",
                principalColumn: "AcademicDegreeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Projetos_ProjetoId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_AcademicDegrees_AcademicDegreeId",
                table: "Projetos");

            migrationBuilder.DropTable(
                name: "Coordenadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projetos",
                table: "Projetos");

            migrationBuilder.RenameTable(
                name: "Projetos",
                newName: "Projeto");

            migrationBuilder.RenameIndex(
                name: "IX_Projetos_AcademicDegreeId",
                table: "Projeto",
                newName: "IX_Projeto_AcademicDegreeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projeto",
                table: "Projeto",
                column: "ProjetoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Projeto_ProjetoId",
                table: "Comentarios",
                column: "ProjetoId",
                principalTable: "Projeto",
                principalColumn: "ProjetoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projeto_AcademicDegrees_AcademicDegreeId",
                table: "Projeto",
                column: "AcademicDegreeId",
                principalTable: "AcademicDegrees",
                principalColumn: "AcademicDegreeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
