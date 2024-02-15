using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Cinema.Models
{
    public class MovieCreateForm
    {
        [DisplayName("Titre du film")]
        [Required(ErrorMessage ="Vous devez indiquer un titre.")]
        [MaxLength(200, ErrorMessage = "Le nom ne peut dépasser 200 caractères.")]
        [MinLength(2, ErrorMessage = "Le nom doit avoir au minimum 2 caractères.")]
        public string Title { get; set; }
        [DisplayName("Sous-titrage")]
        [MaxLength(50, ErrorMessage = "La langue de sous-titrage ne peut dépasser 50 caractères.")]
        public string? SubTitle { get; set; }
        [DisplayName("Année de sortie")]
        [Required(ErrorMessage = "Vous devez la date de sortie du film.")]
        [MaxLength(4, ErrorMessage = "Veuillez indiquer une année valide (4 chiffres).")]
        [MinLength(4, ErrorMessage = "Veuillez indiquer une année valide (4 chiffres).")]
        public int ReleaseYear { get; set; }
        [DisplayName("Synopsis")]
        [Required(ErrorMessage = "Vous devez entrer une courte description du film pour valider le formulaire.")]
        [MaxLength(2000, ErrorMessage = "La description ne peut dépasser 2000 caractères.")]
        [MinLength(5, ErrorMessage = "La description doit avoir au minimum 2 caractères.")]
        public string Synopsis { get; set; }
        [DisplayName("Affiche du film")]
        [Required(ErrorMessage = "Veuillez télécharger une affiche de film avant de continuer.")]
        public string PosterUrl { get; set; }
        [DisplayName("Durée (en minutes)")]
        [Required(ErrorMessage = "Vous devez indiquer un titre.")]
        [MaxLength(4, ErrorMessage = "La durée ne peut dépasser 4 chiffres.")]
        [MinLength(1, ErrorMessage = "La durée doit avoir au moins 1 chiffre.")]
        public int Duration { get; set; }
    }
}
