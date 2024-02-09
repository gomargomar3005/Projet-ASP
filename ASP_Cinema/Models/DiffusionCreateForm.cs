using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Cinema.Models
{
    public class DiffusionCreateForm
    {
        [DisplayName("Date de diffusion")]
        [Required(ErrorMessage ="Veuillez entrer une date.")]
        public DateTime DiffusionDate { get; set; }
        [DisplayName("Heure de diffusion")]
        [Required(ErrorMessage = "Veuillez entrer une heure.")]
        public TimeOnly DiffusionTime { get; set; }
        [DisplayName("Langue")]
        [Required(ErrorMessage = "Veuillez indiquer une langue.")]
        public string AudioLang { get; set; }
        [DisplayName("Sous-titrage")]
        public string? SubTitleLang { get; set; }
        [DisplayName("Salle de diffusion")]
        [Required(ErrorMessage = "Veuillez indiquer l'identifiant de la salle dans laquelle la diffusion est prévue.")]
        public int Id_CinemaRoom { get; set; }
        [DisplayName("Film projeté")]
        [Required(ErrorMessage = "Veuillez indiquer l'identifiant du film qui va être projeté.")]
        public int Id_Movie { get; set; }
    }
}
