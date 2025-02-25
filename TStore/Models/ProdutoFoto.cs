
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TStore.Models;
[Table("ProdutoFoto")]

    public class ProdutoFoto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Produto")]
        [Required(ErrorMessage ="Por Favor, informe o Produto")]

        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }

        [StringLength(200, ErrorMessage ="A foto deve possuir no máximo 200 caracteres")]
        [Required(ErrorMessage ="Por Favor, informe a Foto")]
        public string Foto { get; set; }

        [Display(Name ="Descrição")]
        [StringLength(100, ErrorMessage ="A Descrição deve possuir no máximo 100 caracteres")]
        public string Descricao { get; set; }
    }
