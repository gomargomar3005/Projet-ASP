using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Cinema.Models
{
    public class CinemaPlaceListViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }
        [DisplayName("Nom du cinéma")]
        public string Name { get; set; }
        [DisplayName("Ville")]
        public string City { get; set; }
        [ScaffoldColumn(false)]
        public string Street { get; set; }
        [ScaffoldColumn(false)]
        public string Number { get; set; }

    }
}
