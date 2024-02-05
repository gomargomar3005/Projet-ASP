using System.ComponentModel;

namespace ASP_Cinema.Models
{
    public class CinemaPlaceDetailsViewModel
    {
        [DisplayName("Identifiant")]
        public int Id_CinemaPlace { get; set; }
        [DisplayName("Nom du Cinéma")]
        public string Name { get; set; }
        [DisplayName("Ville")]
        public string City { get; set; }
        [DisplayName("Rue")]
        public string Street { get; set; }
        [DisplayName("Numéro de rue")]
        public string Number { get; set; }
    }
}
