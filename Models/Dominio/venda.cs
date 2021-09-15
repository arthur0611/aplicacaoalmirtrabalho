using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacaoalmirtrabalho.Models.Dominio
{
    [Table("venda")]
    public class venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        //jogos
        [Display(Name = "jogo")]
        public jogos jogo { get; set; }
        [ForeignKey("jogos")]
        public int jogosID { get; set; }

        //usuario
        [Display(Name = "usuario")]
        public usuario usuarios { get; set; }
        [ForeignKey("usuario")]
        public int usuarioID { get; set; }


        [DisplayName("Preço total")]
        [Required(ErrorMessage = "Campo preco total de jogo é obrigatório")]
        public float precototal { get; set; }

        [DisplayName("Preço total")]
        [Required(ErrorMessage = "Campo como foi feita a compra de jogo é obrigatório")]
        public string cffc { get; set; }
    }
}
