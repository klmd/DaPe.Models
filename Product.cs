using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json.Linq;

namespace DaPe.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Je vyžádováno zadání jmána produktu/měřáku")]
        [Display(Name = "Jméno produktu/měřáku")]
        [MaxLength(50, ErrorMessage = "Maximální délka je 50 znaků včetně mezer.")]
        public string NameOfProduct { get; set; }
        [Display(Name = "Číslo produktu/měřáku")]
        //[Range(1, 100, ErrorMessage = "Číslo musí být v rozmezí 1 - 100.")]
        public string DisplayProductNr { get; set; } //original ve videu DisplayOrder
        [Display(Name = "Popis/umístění")]
        public string Description { get; set; }

        [Display(Name = "Zadej Kategotii (voda, plyn, elektrika)")]
        [Required(ErrorMessage = ("Je vyžadováno zadání typu zdroje"))]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [Display(Name = "Zadej typ měřáku (hlavní, podružný, dopočtený")]
        [Required(ErrorMessage = ("Je vyžadováno zadání typu měřáku"))]
        [ValidateNever]
        public int KindOfProductId { get; set; }
        [ForeignKey("KindOfProductId")]
        [ValidateNever]
        public KindOfProduct KindOfProduct { get; set; }
        [Display(Name = "Vlož obrázek")]
        [ValidateNever]
        public string? ImageUrl { get; set; }
    }
}
