using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SereneCoreLearning.Migrations.DefaultDB
{
    [Migration(20201117100230)]
    public class DefaultDB_20201117_100230_MovieGenresTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("MovieGenres").InSchema("mov")
               .WithColumn("MovieGenreId").AsInt32()
                   .Identity().PrimaryKey().NotNullable()
               .WithColumn("MovieId").AsInt32().NotNullable()
                   .ForeignKey("FK_MovieGenres_MovieId",
                       "mov", "Movie", "MovieId")
               .WithColumn("GenreId").AsInt32().NotNullable()
                   .ForeignKey("FK_MovieGenres_GenreId",
                       "mov", "Genre", "GenreId");

            Execute.Sql(
              @"INSERT INTO mov.MovieGenres (MovieId, GenreId) 
                    SELECT m.MovieId, m.GenreId 
                    FROM mov.Movie m 
                    WHERE m.GenreId IS NOT NULL");

            Delete.ForeignKey("FK_Movie_GenreId")
                .OnTable("Movie").InSchema("mov");
            Delete.Column("GenreId")
                .FromTable("Movie").InSchema("mov");
        }
    }
}
