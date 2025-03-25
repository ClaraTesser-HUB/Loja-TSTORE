using Microsoft.EntityFrameworkCore;
using TStore.Models;

namespace TStore.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new(){
                new() {Id = 1, Nome = "Casa" , Foto = "\\img\\categoria\\1\\1.png"},
                new() {Id = 2, Nome = "Roupa" , Foto = "\\img\\categoria\\2.png"},
                new() {Id = 3, Nome = "Eletrodomestico" , Foto = "\\img\\categoria\\3.png"},
                new() {Id = 4, Nome = "Lazer" , Foto = "\\img\\categoria\\4.png"},
                new() {Id = 5, Nome = "Beleza" , Foto = "\\img\\categoria\\5.png"},
                new() {Id = 6, Nome = "Decoração" , Foto = "\\img\\categoria\\6.png"},
            };
        builder.Entity<Categoria>().HasData(categorias);

        List<Produto> produtos = new() {
                new(){
                Id = 1,
                CategoriaId = 4,
                Nome = "Bicicleta 29 Raider Z3x Pro 12v Azul + Preto",
                Descricao = "A bike possui um quadro altamente resistente e leve, fabricado em alumínio 6061, 12 combinações de marcha para você encarar qualquer subida, freios hidráulicos que garantem sua segurança em qualquer ladeira e uma suspensão 100mm com trava remota que proporciona conforto no seu percurso e mais desempenho quando travada",
                ValorCusto = 500.0m,
                ValorVenda = 170.99m,
                QtdeEstoque =10,
                Destaque = true
                }
            };
            builder.Entity<Produto>().HasData(produtos);

            List<ProdutoFoto> fotos = new (){
                new() {Id =1, ProdutoId = 1, Foto = "\\img\\produto\\6\\1.jpeg"}
            };
            builder.Entity<ProdutoFoto>().HasData(fotos);

        }
}
