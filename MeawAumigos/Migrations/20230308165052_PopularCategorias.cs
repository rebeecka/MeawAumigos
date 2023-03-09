﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeawAumigos.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
                "VALUES('Cães','Cães de todos os portes')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
                "VALUES('Gatos','Gatos de todos os portes')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
