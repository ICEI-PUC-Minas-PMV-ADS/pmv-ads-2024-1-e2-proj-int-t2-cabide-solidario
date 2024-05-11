using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cabide_solidario.Models
{
    [Table("Parceiros")]
    public class Parceiro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o nome da empresa")]
        public string NomeEmpresa { get; set; }
        [Required(ErrorMessage = "Informe o edereço de Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o Telefone")]
        public int Telefone { get; set; }
    }
}
