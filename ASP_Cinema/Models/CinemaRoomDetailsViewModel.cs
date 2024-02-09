using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Cinema.Models
{
    public class CinemaRoomDetailsViewModel
    {
        [DisplayName("Identifiant de la salle ")]
        public int Id_CinemaRoom { get; set; }
        [DisplayName("Nombre de sièges ")]
        public int SeatsCount { get; set; }
        [DisplayName("Numéro du siège ")]
        public int Number { get; set; }
        [DisplayName("Largeur de l'écran ")]
        public int ScreenWidth { get; set; }
        [DisplayName("Hauteur de l'écran ")]
        public int ScreenHeight { get; set; }
        [DisplayName("3D ")]
        public bool Can3D { get; set; }
        [DisplayName("4DX ")]
        public bool Can4DX { get; set; }
        [DisplayName("Identifiant du Cinéma")]
        public int Id_CinemaPlace { get; set; }
    }
}
