using BLL_Cinema.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Cinema.Models
{
    public class CinemaPlaceCreateForm
    {
        [DisplayName("Nom du Cinéma")]
        [Required(ErrorMessage = "Vous devez entrer un nom de Cinéma")]
        [MaxLength(120, ErrorMessage = "Le nom ne peut dépasser 120 caractères.")]
        [MinLength(2, ErrorMessage = "Le nom doit avoir au minimum 2 caractères.")]
        public string Name { get; set; }
        [DisplayName("Ville")]
        [Required(ErrorMessage = "Vous devez entrer une ville.")]
        [MaxLength(200, ErrorMessage = "La ville ne peut dépasser 200 caractères.")]
        [MinLength(2, ErrorMessage = "La ville doit avoir au minimum 2 caractères.")]
        public string City { get; set; }
        [DisplayName("Rue")]
        [Required(ErrorMessage = "Vous devez entrer un nom de rue.")]
        [MaxLength(300, ErrorMessage = "La rue ne peut dépasser 300 caractères.")]
        [MinLength(2, ErrorMessage = "La rue doit avoir au minimum 2 caractères.")]
        public string Street { get; set; }
        [DisplayName("Numéro de rue")]
        [Required(ErrorMessage = "Vous devez entrer un numéro de rue.")]
        public string Number { get; set; }
    }
}
