using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Cinema.Entities
{
    public class Movie
    {
        public int Id_Movie { get; set; }
        public string Title { get; set; }
        public string? SubTitle { get; set; }
        public int ReleaseYear { get; set; }
        public string Synopsis { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; set; }

        public Movie(int id_Movie, string title, string? subTitle, int releaseYear, string synopsis, string posterUrl, int duration)
        {
            Id_Movie = id_Movie;
            Title = title;
            SubTitle = subTitle;
            ReleaseYear = releaseYear;
            Synopsis = synopsis;
            PosterUrl = posterUrl;
            Duration = duration;
        }

        public Movie(int id_Movie, string? subTitle, int releaseYear, string synopsis, string posterUrl, int duration)
        {
            Id_Movie = id_Movie;
            SubTitle = subTitle;
            ReleaseYear = releaseYear;
            Synopsis = synopsis;
            PosterUrl = posterUrl;
            Duration = duration;
        }
    }
}
