using System.ComponentModel.DataAnnotations;

namespace DemoCrudBooks.Models.ViewModel
{
    public class LivreForm
    {
        [Required]
        public string Titre { get; set; }
        [Required]
        [MaxLength(13), MinLength(13)]
        public string ISBN { get; set; }
        public string Auteur { get; set; }
    }
}
