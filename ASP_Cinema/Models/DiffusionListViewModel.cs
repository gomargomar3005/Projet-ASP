using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Cinema.Models
{
    public class DiffusionListViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Diffusion { get; set; }
        [DisplayName("Date de diffusion")]
        public DateTime DiffusionDate { get; set; }
        [DisplayName("Heure de diffusion")]
        public TimeOnly DiffusionTime { get; set; }
        [DisplayName("Langue")]
        public string AudioLang { get; set; }
        [DisplayName("Sous-titrage")]
        public string? SubTitleLang { get; set; }
        [ScaffoldColumn(false)]
        public int Id_CinemaRoom { get; set; }
        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }
    }
}
