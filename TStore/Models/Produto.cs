using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TStore.Models;
[Table("Produto")]

    public class Produto
    {
        [Key]
      public int Id { get; set; }   

      [Display(Name ="Categoria")]
    [Required(ErrorMessage ="Por Favor, informe a Categoria")]
      public int CategoriaId { get; set; }

      [ForeignKey("CategoriaId")]
      public Categoria Categoria { get; set; }

    [Required(ErrorMessage ="Por Favor, informe o Nome")]       
    [StringLength(100, ErrorMessage ="O Nome deve possuir no máximo 100 caracteres")]
      public string Nome { get; set; }
      
    [Display(Name ="Descrição")]
    [StringLength(1000, ErrorMessage ="A Descrição deve possuir no máximo 1000 caracteres")]
      public string Descricao { get; set; }

    [Display(Name ="Quantidade em Estoque")]
    [Required(ErrorMessage = "Por Favor, informe a Quantidade em Estoque")]
    [Range(0, int.MaxValue)]
    
      public int QtdeEstoque { get; set; }

    [Display(Name ="Quantidade de Custo")]
    [Required(ErrorMessage = "Por Favor, informe o Valor de Custo")]
    [Range(0, double.MaxValue)]
    [Column(TypeName ="numeric(10,2)")]
      public decimal ValorCusto { get; set; }


    [Display(Name ="Quantidade de Custo")]
    [Required(ErrorMessage = "Por Favor, informe o Valor de Custo")]
    [Range(0, double.MaxValue)]
    [Column(TypeName ="numeric(10,2)")]
      public decimal ValorVenda { get; set; }


      public bool Destaque { get; set; } = false;
    }
