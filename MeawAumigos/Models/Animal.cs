using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeawAumigos.Models
{
    [Table("Animais")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [StringLength(80,MinimumLength =10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        [Required(ErrorMessage = "O nome do Animal deve ser informado")]
        [Display(Name = "Nome do animal")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do Animal deve ser informada")]
        [Display(Name = "Descrição do animal")]
        [MinLength(20,ErrorMessage ="A descrição deve ter no mínimo {1} caractere")]
        [MaxLength(200,ErrorMessage ="A descrição pode exceder {1} caractere")]
        public string MiniDescricao { get; set; }

        [Required(ErrorMessage = "A descrição longa do Animal deve ser informada")]
        [Display(Name = "Descrição longa do animal")]
        [MinLength(20, ErrorMessage = "A descrição longa deve ter no mínimo {1} caractere")]
        [MaxLength(200, ErrorMessage = "A descrição longa pode exceder {1} caractere")]
        public string LongaDescricao { get; set; }

        [Required(ErrorMessage ="Informe o preço do animal")]
        [Display(Name ="Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0,999.99,ErrorMessage ="O preço deve estar entre 0 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho da imagem")]
        [StringLength(200,ErrorMessage ="O {0} deve ter no máximo {1} caractere")]
        public string ImagemUrl { get; set; }

        [Display(Name ="Caminho da imagem em miniatura")]
        [StringLength(200,ErrorMessage ="O {0} deve ter no máximo {1} caractere")]
        public string ImagemMiniUrl { get; set; }

        [Display(Name ="Animal favorito?")]
        public bool AnimalFavorito { get; set; }

        [Display(Name ="Disponível?")]
        public bool Disponivel { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
