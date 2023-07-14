using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DaPe.Models;

public class KindOfProduct
{
    [Key]
    public int Id { get; set; }
    [Required]
    [Display(Name = "Typ produktu/měřáku (Hlavní, podružný, počítaný, apod.)")]
    [MaxLength(50, ErrorMessage = "Maximální délka je 50 znaků včetně mezer.")]
    public string TypeOfProduct { get; set; }
    [Display(Name = "Číslo typu produktu/měřáku")]
    //[Range(1, 100, ErrorMessage = "Číslo musí být v rozmezí 1 - 100.")]
    public int DisplayTypeOfProductNr { get; set; }
}