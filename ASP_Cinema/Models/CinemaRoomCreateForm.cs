using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Cinema.Models
{
    public class CinemaRoomCreateForm
    {
        [DisplayName("Nombre de sièges ")]
        [Required(ErrorMessage = "Vous devez indiquer une valeur numérique.")]

        public int SeatsCount { get; set; }
        [DisplayName("Numéro du siège ")]
        [Required(ErrorMessage = "Vous devez indiquer une valeur numérique.")]
        public int Number { get; set; }
        [DisplayName("Largeur de l'écran ")]
        [Required(ErrorMessage = "Vous devez indiquer une valeur.")]
        [MinLength(100, ErrorMessage = "La largeur de l'écran ne peut pas être plus petite que 100cm.")]
        [MaxLength(10000, ErrorMessage = "La largeur de l'écran ne peut dépasser 10000cm.")]
        public int ScreenWidth { get; set; }
        [DisplayName("Hauteur de l'écran (cm)")]
        [Required(ErrorMessage ="Vous devez indiquer une valeur.")]
        [MinLength(100, ErrorMessage ="La hauteur de l'écran ne peut pas être plus petite que 100cm.")]
        [MaxLength(10000, ErrorMessage ="La hauteur de l'écran ne peut dépasser 10000cm.")]
        public int ScreenHeight { get; set; }
        [DisplayName("3D ")]
        [Required(ErrorMessage = "Vous devez indiquer si le film est en 3D.")]
        public bool Can3D { get; set; }
        [DisplayName("4DX ")]
        [Required(ErrorMessage ="Vous devez indiquer si le film est en 4DX.")]
        public bool Can4DX { get; set; }
        [DisplayName("Id du Cinéma")]
        [Required(ErrorMessage ="Vous devez identifier dans quel cinéma se trouve la salle.")]
        public int Id_CinemaPlace { get; set; }
    }
}
