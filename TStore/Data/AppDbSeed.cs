using System.Data;
using Microsoft.AspNetCore.Identity;
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
                },
                new(){
                    Id = 2,
                    CategoriaId = 5,
                    Nome ="Paleta Sombras Océane Edition 6 Eyeshadow Palette Glorious 7,8g",
                    Descricao ="Procurando uma paleta de sombras versátil e moderna? A 6 Palette Edition Glorious é perfeita para te acompanhar nas makes mais básicas e nas mais elaboradas, com cores modernas, muita pigmentação e fixação.",
                    ValorCusto =20.0m,
                    ValorVenda =79.90m,
                    QtdeEstoque=6,
                    Destaque =true
                },
                new(){
                    Id = 3,
                    CategoriaId = 3,
                    Nome ="Câmera Instantânea Fujifilm Instax Mini 12 Verde Menta",
                    Descricao ="A INSTAX mini 12 chegou e está repleta de alegria, criatividade e cor. Esta icônica câmera instantânea não está apenas disponível em cinco tons atraentes - Azul Pastel, Verde Menta, Rosa Flor, Roxo Lilás e Branco Argila – como está repleta de modos e controles fáceis de usar. Projetada para acompanhar a vida, a INSTAX mini 12 está pronta para funcionar com um simples giro da lente.",
                    ValorCusto =120.0m,
                    ValorVenda =682.75m,
                    QtdeEstoque=7,
                    Destaque =true
                },
                new(){
                    Id = 4,
                    CategoriaId = 3,
                    Nome ="Torradeira Elétrica Wap Wte1 com 7 Níveis de Tostagem Reaquece e Descongela 800w 220v",
                    Descricao ="A Torradeira Elétrica WAP (WTE1) é a escolha perfeita para o seu dia a dia. Combinando seus níveis de tostagem, acabamento em inox e design moderno, esta torradeira oferece praticidade e estilo. Com seus 7 níveis de tostagem, você tem o poder de escolher a crocância perfeita para o seu pão.",
                    ValorCusto =70.0m,
                    ValorVenda =199.99m,
                    QtdeEstoque=10,
                    Destaque =true
                },
                new(){
                    Id = 5,
                    CategoriaId = 1,
                    Nome ="Sofá Retrátil 4 Lugares 242cm Itaguía Prime Cinza",
                    Descricao ="Além de coroar a décor da sua sala de estar com elegância e muito bom gosto, o Sofá Itaguaí Prime também é a opção certa para levar mais comodidade e bem-estar ao seu dia a dia. A estrutura interna conta com madeira eucalipto, que dá a resistência necessária ao uso diário, e com estofamento na densidade ideal para deixar você e sua família bem à vontade. ",
                    ValorCusto =800.0m,
                    ValorVenda =3020.99m,
                    QtdeEstoque=11,
                    Destaque =true
                },
                new(){
                    Id = 6,
                    CategoriaId = 1,
                    Nome ="Tapete Orgânico Volcano 2,00 X 2,50 Colare Lisse Branco",
                    Descricao ="A magia deste formato: Irrompa com estilo e energia com o modelo Vulcano (vulcão), que evoca a força e a intensidade dos elementos naturais. Seu padrão vibrante e forma dinâmica é uma declaração de estilo audaciosa para seus espaços.",
                    ValorCusto =100.0m,
                    ValorVenda =855.53m,
                    QtdeEstoque=5,
                    Destaque =true
                },
                new(){
                    Id = 7,
                    CategoriaId = 1,
                    Nome ="Guarda Roupa Casal 3 Portas com Espelho 4 Gavetas Costa Rica Cinamomo/Off-White",
                    Descricao ="O guarda-roupa, além de ser um móvel essencial para guardar as roupas e demais itens de uso pessoal, também é uma das peças mais importantes para compor a decoração do quarto. O guarda-roupa casal, por ser mais amplo, é o queridinho na hora da decoração.",
                    ValorCusto =600.0m,
                    ValorVenda =1000.59m,
                    QtdeEstoque=10,
                    Destaque =true
                },
                new(){
                    Id = 8,
                    CategoriaId = 2,
                    Nome ="Vestido Longo Verão Veruska",
                    Descricao ="Ideal para mulhres elegantes e charmosas que desejam um visual deslumbrante e sofisticado para os dias quentes. Com um design moderno e detalhes cuidadosamente pensados.",
                    ValorCusto =60.0m,
                    ValorVenda =236.70m,
                    QtdeEstoque=12,
                    Destaque =true
                }
            };
            builder.Entity<Produto>().HasData(produtos);

            List<ProdutoFoto> fotos = new (){
                //Bicicleta
                new() {Id =1, ProdutoId = 1, Foto = "\\img\\produto\\6\\1.jpeg"},
                new() {Id =2, ProdutoId = 1, Foto = "\\img\\produto\\6\\2.jpeg"},
                new() {Id=3, ProdutoId = 1, Foto = "\\img\\produto\\6\\3.jpeg"},

                //Paleta de Sombra
                new() {Id=4, ProdutoId= 2, Foto="\\img\\produto\\1\\1.jpeg"},
                new() {Id=5, ProdutoId= 2, Foto="\\img\\produto\\1\\2.jpeg"},
                new() {Id=6, ProdutoId= 2, Foto="\\img\\produto\\1\\3.jpeg"},

                //Camera
                new() {Id=7, ProdutoId= 3, Foto="\\img\\produto\\2\\1.jpeg"},
                new() {Id=8, ProdutoId= 3, Foto="\\img\\produto\\2\\2.jpeg"},
                new() {Id=9, ProdutoId= 3, Foto="\\img\\produto\\2\\3.jpeg"},

                //Torradeira
                new() {Id=7, ProdutoId= 4, Foto="\\img\\produto\\4\\1.jpeg"},
                new() {Id=8, ProdutoId= 4, Foto="\\img\\produto\\4\\2.jpeg"},
                new() {Id=9, ProdutoId= 4, Foto="\\img\\produto\\4\\3.jpeg"},

                //Sofá
                new() {Id=7, ProdutoId= 5, Foto="\\img\\produto\\3\\1.jpeg"},
                new() {Id=8, ProdutoId= 5, Foto="\\img\\produto\\3\\2.jpeg"},
                new() {Id=9, ProdutoId= 5, Foto="\\img\\produto\\3\\3.jpeg"},

                //Tapete
                new() {Id=7, ProdutoId= 6, Foto="\\img\\produto\\5\\1.jpeg"},
                new() {Id=8, ProdutoId= 6, Foto="\\img\\produto\\5\\2.jpeg"},
                new() {Id=9, ProdutoId= 6, Foto="\\img\\produto\\5\\3.jpeg"},

                //Guarda roupa
                new() {Id=7, ProdutoId= 7, Foto="\\img\\produto\\7\\1.jpeg"},
                new() {Id=8, ProdutoId= 7, Foto="\\img\\produto\\7\\2.jpeg"},
                new() {Id=9, ProdutoId= 7, Foto="\\img\\produto\\7\\3.jpeg"},

                //Vestido
                new() {Id=7, ProdutoId= 8, Foto="\\img\\produto\\8\\1.jpeg"},
                new() {Id=8, ProdutoId= 8, Foto="\\img\\produto\\8\\2.jpeg"},
                new() {Id=9, ProdutoId= 8, Foto="\\img\\produto\\8\\3.jpeg"},
            };
            builder.Entity<ProdutoFoto>().HasData(fotos);

            #region Populate Roles - Perfil de Usuário
            List<IdentityRole> roles = new()
            {
                new IdentityRole(){
                    Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
                    Name ="Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new IdentityRole(){
                    Id ="bec71b05-8f3d-4849-88bb-0e8d518d2de8",
                    Name="Funcionário",
                    NormalizedName="FUNCIONÁRIO"
                },
                new IdentityRole(){
                    Id="ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                    Name="Cliente",
                    NormalizedName="CLIENTE"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
            #endregion

            #region Populate Usuário
            List<Usuario> usuarios= new(){
                new Usuario(){
                    Id="ddf093a6-6bc5-4ff7-9a64-83da34aee005",
                    Email="claratesserpereira@gmail.com",
                    NormalizedEmail="CLARATESSERPEREIRA@GMAIL.COM",
                    UserName="ClaraTesser",
                    NormalizedUserName="CLARATESSER",
                    LockoutEnabled=true,
                    EmailConfirmed=true,
                    Nome="Clara Tesser",
                    DataNascimento= DateTime.Parse("11/07/2007"),
                    Foto ="/img/usuarios/clara.jpeg."
                }
            };
            foreach (var user in usuarios)
            {
                PasswordHasher<IdentityUser> pass=new();
                user.PasswordHash = pass.HashPassword(user, "123456");
            }
            builder.Entity<Usuario>().HasData(usuarios);
            #endregion

            #region Populate UserRole - Usuário com Perfil
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>(){
                    UserId = usuarios[0].Id,
                    RoleId = roles[0].Id
                },
                new IdentityUserRole<string>(){
                    UserId = usuarios[0].Id,
                    RoleId = roles[1].Id
                },
                new IdentityUserRole<string>() {
                    UserId = usuarios[0].Id,
                    RoleId = roles[2].Id
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

        }
}
