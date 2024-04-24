using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cabide_solidario.Models
{
    [Table("Candidatos")]
    public class Candidato
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe o seu nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o seu e-mail.")]
        [Display(Name ="E-mail")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Informe a sua disponibilidade.")]
        public string Disponibilidade { get; set;}

        [Required(ErrorMessage = "Descreva o por quê deseja participar do Cabide Solidário.")]
        [Display(Name = "Por que deseja participar da nossa equipe de voluntários?")]
        public string Texto_Motivacao { get; set; }

    }
}
