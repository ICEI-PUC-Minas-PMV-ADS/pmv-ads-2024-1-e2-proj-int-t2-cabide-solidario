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
                            NomeItem = "Apples",
                            Doador = "Gabriel",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = 0,
                            Imagem = "apples.jpg"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Apples",
                            Doador = "Abraão",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = (tipoGenero)1,
                            Imagem = "bananas.jpg"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Apples",
                            Doador = "Clarence",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = 0,
                            Imagem = "watermelon.jpg"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Apples",
                            Doador = "Estevão",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = 0,
                            Imagem = "grapefruit.jpg"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Apples",
                            Doador = "Gabriel",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = 0,
                            Imagem = "white shirt.jpg"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Apples",
                            Doador = "Abraão",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = 0,
                            Imagem = "black shirt.jpg"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Apples",
                            Doador = "Clarence",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = 0,
                            Imagem = "yellow shirt.jpg"
                        },
                        new RoupaDoada
                        {
                            NomeItem = "Apples",
                            Doador = "Estevão",
                            Tamanho = 0,
                            Cor = "verde",
                            Genero = 0,
                            Imagem = "grey shirt.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}