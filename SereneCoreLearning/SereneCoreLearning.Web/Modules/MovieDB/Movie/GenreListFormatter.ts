﻿
namespace SereneCoreLearning.MovieDB {
    @Serenity.Decorators.registerFormatter()
    export class GenreListFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string {
            let idList = ctx.value as number[];
            if (!idList || !idList.length)
                return "";

            const byId = GenreRow.getLookup().itemById;

            return idList.map(x => {
                let g = byId[x];
                if (!g)
                    return x.toString();

                return Q.htmlEncode(g.Name);
            }).join(", ");
        }

    }
}

