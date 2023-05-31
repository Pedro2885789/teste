using FluentMigrator;
using FluentMigrator.SqlServer;

namespace INFRA
{
    [Migration(20230531172500)]
    public class AdicionarTabelaPecas : Migration
    {
        public override void Up()
        {
            Create.Table("Peca")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity(1, 1)
                .WithColumn("Nome").AsString()
                .WithColumn("Categoria").AsString()
                .WithColumn("Descricao").AsString()
                .WithColumn("Estoque").AsInt32()
                .WithColumn("DataDeFabricacao").AsDateTime();
        }

        public override void Down()
        {
            Delete.Table("Peca");
        }
    }
}
