using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacaoalmirtrabalho.Models.Dominio
{

    [Table("jogos")]
    public class jogos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(70, ErrorMessage = "Não aceita Nome com mais de 70 dígitos")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome do jogo é obrigatório")]
        public string Nome { get; set; }

        [StringLength(70, ErrorMessage = "Não aceita Nome com mais de 70 dígitos")]
        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Campo categoria do jogo é obrigatório")]
        public string Categoria { get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "Campo preço do jogo é obrigatório")]
        public float preco { get; set; }

        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Campo quantidade de jogo é obrigatório")]
        public int quantidade { get; set; }

        //empresa
        [Display(Name = "empresa")]
        public empresa empresas { get; set; }
        [ForeignKey("empresa")]
        public int empresaID { get; set; }

        public ICollection<venda> venda { get; set; }
    }
}
