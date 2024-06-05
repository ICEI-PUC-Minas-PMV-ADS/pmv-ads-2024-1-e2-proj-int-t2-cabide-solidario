using cabide_solidario.Models;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(AppDbContext context)
        {
            context.Database.Migrate();

            if (!context.RoupasDoadas.Any())
            {

                context.RoupasDoadas.AddRange(
                        new RoupaDoada
                        {
                            NomeItem = "Camisa",
                            Doador = "Gabriel",
                            Tamanho = 0,
                            Cor = "Vermelha",
                            Genero = 0,
                            Imagem = "redshirt.jpeg",
                            CodigoProduto = "25364"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Jaqueta",
                            Doador = "Abraão",
                            Tamanho = 0,
                            Cor = "Preto",
                            Genero = (tipoGenero)1,
                            Imagem = "jaqueta.jpg",
                            CodigoProduto = "25489"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Camisa",
                            Doador = "Clarence",
                            Tamanho = 0,
                            Cor = "Azul",
                            Genero = 0,
                            Imagem = "blueshirt.jpeg",
                            CodigoProduto = "85695"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Calça",
                            Doador = "Estevão",
                            Tamanho = 0,
                            Cor = "Azul",
                            Genero = 0,
                            Imagem = "calcajeans.jpg",
                            CodigoProduto = "87415"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Camisa",
                            Doador = "Gabriel",
                            Tamanho = 0,
                            Cor = "Branco",
                            Genero = 0,
                            Imagem = "white shirt.jpg",
                            CodigoProduto = "96521"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Camisa",
                            Doador = "Abraão",
                            Tamanho = 0,
                            Cor = "Preto",
                            Genero = 0,
                            Imagem = "black shirt.jpg",
                            CodigoProduto = "54123"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Camisa",
                            Doador = "Clarence",
                            Tamanho = 0,
                            Cor = "Amarelo",
                            Genero = 0,
                            Imagem = "yellow shirt.jpg",
                            CodigoProduto = "65418"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Camisa",
                            Doador = "Estevão",
                            Tamanho = 0,
                            Cor = "Cinza",
                            Genero = 0,
                            Imagem = "grey shirt.jpg",
                            CodigoProduto = "41572"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}