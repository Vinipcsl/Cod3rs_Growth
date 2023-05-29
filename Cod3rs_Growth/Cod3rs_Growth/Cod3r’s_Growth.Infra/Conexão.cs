using FluentMigrator;

namespace Cod3r_s_Growth.Infra.Banco
{
    [Migration(20230517083200)]
    public class Conexão : Migration
    {
        public override void Up()
        {
            Create.Table("Celulares")
            .WithColumn("id").AsInt64().PrimaryKey().Identity()
            .WithColumn("Marca").AsString()
            .WithColumn("Modelo").AsString()
            .WithColumn("Cor").AsString()
            .WithColumn("Memoria").AsInt32()
            .WithColumn("AnoFabricado").AsDateTime();
        }

        public override void Down()
        {
            Delete.Table("Celulares");
        }
    }
}
