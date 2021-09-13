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
    public class usuario
    {[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [DisplayName("ID")]
    public int Id { get; set; }
    

    [StringLength(70,ErrorMessage = "Não aceita Nome com mais de 70 dígitos")]
    [DisplayName("Nome")]
    [Required(ErrorMessage = "Campo nome do usuario é obrigatório")]
    public string Nome { get; set; }
    
    [StringLength(3, ErrorMessage = "Não aceita Nome com mais de 3 dígitos")]
    [DisplayName("Idade")]
    [Required(ErrorMessage = "Campo idade do usuario é obrigatório")]
    public string idade { get; set; }

    [StringLength(140, ErrorMessage = "Não aceita Nome com mais de 140 dígitos")]
    [DisplayName("Endereço")]
    [Required(ErrorMessage = "Campo endereço do usuario é obrigatório")]
    public string endereco { get; set; }
     
    }
}
