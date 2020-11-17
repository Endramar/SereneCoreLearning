using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SereneCoreLearning.Migrations.DefaultDB
{
    [Migration(20201116203630)]
    public class DefaultDB_20201116_203630_MovieKind : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                 .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
        }
    }
}
