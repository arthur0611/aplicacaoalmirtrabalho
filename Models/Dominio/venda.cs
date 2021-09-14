using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacaoalmirtrabalho.Models.Dominio
{
    [Table("usuario")]
    public class venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        //jogos
        public ICollection<jogos> jogos { get; set; }

        //usuario
        public ICollection<usuario> usuarios { get; set; }


        [DisplayName("Preço total")]
        [Required(ErrorMessage = "Campo preco total de jogo é obrigatório")]
        public string precototal { get; set; }

        [DisplayName("Preço total")]
        [Required(ErrorMessage = "Campo como foi feita a compra de jogo é obrigatório")]
        public string cffc { get; set; }
    }
}
