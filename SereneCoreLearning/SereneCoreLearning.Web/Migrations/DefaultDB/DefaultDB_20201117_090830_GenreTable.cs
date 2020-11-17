using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SereneCoreLearning.Migrations.DefaultDB
{
    [Migration(20201117090830)]
    public class DefaultDB_20201117_090830_GenreTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
               .WithColumn("GenreId").AsInt32().NotNullable()
                   .PrimaryKey().Identity()
               .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie").InSchema("mov").AddColumn("GenreId").AsInt32()
                .Nullable().ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");
        }
    }
}
