using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMVC.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
                "VALUES('Caderno espiral','Caderno espiral 100 folhas',7.45,50,'caderno1.jpg',1)");

            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
                "VALUES('Estojo escolar','Estojo escolar cinza',5.65,70,'caderno1.jpg',1)");

            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
                "VALUES('Caneta Azul','Caneta Azul Bic 10.0',5.5,30,'caneta1.jpg',1)");

            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
                "VALUES('Borracha escolar','Borracha escolar G simples',4.95,20,'borracha1.jpg',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
