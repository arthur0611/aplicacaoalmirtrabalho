using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacaoalmirtrabalho.Models.Dominio
{

    [Table("Empresas")]
    public class empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(70, ErrorMessage = "Não aceita Nome com mais de 70 dígitos")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome da Empresa é obrigatório")]
        public string Nome { get; set; }

        public ICollection<jogos> jogos { get; set; }
    }
}
