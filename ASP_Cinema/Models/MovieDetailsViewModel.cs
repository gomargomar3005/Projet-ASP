using System.ComponentModel;

namespace ASP_Cinema.Models
{
    public class MovieDetailsViewModel
    {
        [DisplayName("Identifiant du film")]
        public int Id_Movie { get; set; }
        [DisplayName("Titre du film")]
        public string Title { get; set; }
        [DisplayName("Sous-titrage")]
        public string? SubTitle { get; set; }
        [DisplayName("Année de sortie")]
        public int ReleaseYear { get; set; }
        [DisplayName("Synospsis")]
        public string Synopsis { get; set; }
        [DisplayName("Affiche du film")]
        public string PosterUrl { get; set; }
        [DisplayName("Durée (en minutes)")]
        public int Duration { get; set; }
    }
}
