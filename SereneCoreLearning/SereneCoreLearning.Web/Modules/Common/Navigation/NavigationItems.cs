using SereneCoreLearning.MovieDB.Pages;
using Serenity.Navigation;
using Administration = SereneCoreLearning.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]


#region MovieDB Navigation
[assembly: NavigationLink(1100, "Movie Database", typeof(MovieController), icon: "fa-film")]
[assembly: NavigationLink(10, "Movie Database/Movies", typeof(MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(20, "Movie Database/Genres", typeof(GenreController), icon: "fa-arrows")]
#endregion
