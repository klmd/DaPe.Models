using System.ComponentModel.DataAnnotations;

namespace DaPe.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Jméno kategorie")]
        [MaxLength(30, ErrorMessage = "Maximální délka je 30 znaků včetně mezer.")]
        public string Name { get; set; }
        [Display(Name = "Číslo kategorie")]
        [Range(1, 100, ErrorMessage = "Číslo musí být v rozmezí 1 - 100.")]
        public int DisplayCategoryNr { get; set; } //original ve videu DisplayOrder
    }
}
