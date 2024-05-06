using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace cabide_solidario.Models
{
    [Table("Roupas Doadas")]
    public class RoupaDoada
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do item.")]
        [Display(Name = "Nome do item")]
        public string NomeItem { get; set; }

        [Required(ErrorMessage = "Informe o nome do doador.")]
        public string Doador { get; set; }

        [Required(ErrorMessage = "Informe o tipo do item.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Selecione o tamanho do item.")]
        public string Tamanho { get; set; }

        [Required(ErrorMessage = "Informe a cor do item.")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Selecione o genero do item.")]
        public string Genero { get; set; }
    }

    public enum Genero
    {
        Feminino,
        Masculino,
        Unissex,
        Infantil
    }

    public enum Tamanho
    {
        P,
        M,
        G,
        GG
    }


}
