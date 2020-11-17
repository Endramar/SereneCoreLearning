using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneCoreLearning.MovieDB
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "SereneCoreLearning.MovieDB.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
