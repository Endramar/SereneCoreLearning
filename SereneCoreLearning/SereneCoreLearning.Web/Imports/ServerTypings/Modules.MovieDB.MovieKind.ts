﻿namespace SereneCoreLearning.Modules.MovieDB {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'SereneCoreLearning.Modules.MovieDB.MovieKind', 'MovieDB.MovieKind');
}
