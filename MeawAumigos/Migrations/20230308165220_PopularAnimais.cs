using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeawAumigos.Migrations
{
    /// <inheritdoc />
    public partial class PopularAnimais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Animais(CategoriaId,MiniDescricao,LongaDescricao,Disponivel,ImagemUrl,ImagemMiniUrl,AnimalFavorito,Nome,Preco) VALUES(1,'Cadela de 3 meses não castrada','Cadela de 3 meses vacinada e não castrada. Muito carinhosa e brincalhona',1,'https://blog.cobasi.com.br/wp-content/uploads/2021/08/vira-lata-filhote-2.png','https://blog.cobasi.com.br/wp-content/uploads/2021/08/vira-lata-filhote-2.png',1,'Mel',0.00)");
            migrationBuilder.Sql("INSERT INTO Animais(CategoriaId,MiniDescricao,LongaDescricao,Disponivel,ImagemUrl,ImagemMiniUrl,AnimalFavorito,Nome,Preco) VALUES(1,'Cão de 10 meses castrado','Cão de 10 meses vacinado e castrado. Bagunceiro e brincalhão',1,'https://img.freepik.com/fotos-premium/close-up-de-cachorro-vira-lata_109656-47.jpg','https://img.freepik.com/fotos-premium/close-up-de-cachorro-vira-lata_109656-47.jpg',0,'Bob',0.00)");
            migrationBuilder.Sql("INSERT INTO Animais(CategoriaId,MiniDescricao,LongaDescricao,Disponivel,ImagemUrl,ImagemMiniUrl,AnimalFavorito,Nome,Preco) VALUES(2,'Gata de 4 anos castrada','Gata de 4 anos vacinada e castrada. Muito carinhosa e brincalhona',0,'https://i0.statig.com.br/bancodeimagens/c6/tn/ui/c6tnui0c99uzphn0d42e70jub.jpg','https://i0.statig.com.br/bancodeimagens/c6/tn/ui/c6tnui0c99uzphn0d42e70jub.jpg',1,'Mia',0.00)");
            migrationBuilder.Sql("INSERT INTO Animais(CategoriaId,MiniDescricao,LongaDescricao,Disponivel,ImagemUrl,ImagemMiniUrl,AnimalFavorito,Nome,Preco) VALUES(2,'Gato de 2 anos não castrado','Gato de 2 anos vacinado e não castrado. Bagunceiro e brincalhão',1,'https://www.eltelegrafo.com.ec/media/k2/items/cache/a6762f6f275d60a63a656fedefb81090_XL.jpg','https://www.eltelegrafo.com.ec/media/k2/items/cache/a6762f6f275d60a63a656fedefb81090_XL.jpg',0,'Paçoca',0.00)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Animais");
        }
    }
}