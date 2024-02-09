using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Cinema.Models
{
    public class CinemaRoomListViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaRoom { get; private set; }
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
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }
    }
}
