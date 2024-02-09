using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Cinema.Models
{
    public class DiffusionDetailsViewModel
    {
        [DisplayName("Identifiant Diffusion")]
        public int Id_Diffusion { get; set; }
        [DisplayName("Date de diffusion")]
        public DateTime DiffusionDate { get; set; }
        [DisplayName("Heure de diffusion")]
        public TimeOnly DiffusionTime { get; set; }
        [DisplayName("Langue")]
        public string AudioLang { get; set; }
        [DisplayName("Sous-titrage")]
        public string? SubTitleLang { get; set; }
        [DisplayName("Salle de diffusion")]
        public int Id_CinemaRoom { get; set; }
        [DisplayName("Film projeté")]
        public int Id_Movie { get; set; }
    }
}
