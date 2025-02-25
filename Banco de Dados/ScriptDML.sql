USE lojinha;
GO

-- Comandos DML - Data Manipulation Language
-- Inserir dados
INSERT INTO Categoria(Nome, ExibirHome, Foto) VALUES 
('Lazer', 1, 'img/categoria/lazer/4.png'), --1
('Casa', 1, 'img/categoria/casa/1.png'), --2
('Beleza',1, 'img/categoria/beleza/5.png'), --3
('Decora��o',1, 'img/categoria/decoracao/6.png'), --4
('Eletrodomestico',1, 'img/categoria/eletrodomestico/3.png'),--5
('Roupa', 1, 'img/categoria/roupa/2.png'); --6

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --1
('Paleta Sombras Oc�ane Edition 6 Eyeshadow Palette Glorious 7,8g',
'Procurando uma paleta de sombras vers�til e moderna? A 6 Palette Edition Glorious � perfeita para te acompanhar nas makes mais b�sicas e nas mais elaboradas, com cores modernas, muita pigmenta��o e fixa��o.',6,20.0,79.90,1,1); 

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --2
('C�mera Instant�nea Fujifilm Instax Mini 12 Verde Menta','A INSTAX mini 12 chegou e est� repleta de alegria, criatividade e cor. Esta ic�nica c�mera instant�nea n�o est� apenas dispon�vel em cinco tons atraentes - Azul Pastel, Verde Menta, Rosa Flor, Roxo Lil�s e Branco Argila � como est� repleta de modos e controles f�ceis de usar. Projetada para acompanhar a vida, a INSTAX mini 12 est� pronta para funcionar com um simples giro da lente.', 7, 120.0, 682.75, 1, 1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --3
('Torradeira El�trica Wap Wte1 com 7 N�veis de Tostagem Reaquece e Descongela 800w 220v', 'A Torradeira El�trica WAP (WTE1) � a escolha perfeita para o seu dia a dia. Combinando seus n�veis de tostagem, acabamento em inox e design moderno, esta torradeira oferece praticidade e estilo.

Com seus 7 n�veis de tostagem, voc� tem o poder de escolher a croc�ncia perfeita para o seu p�o.', 10, 70.0, 199.99, 1,1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --4
('Sof� Retr�til 4 Lugares 242cm Itagu�a Prime Cinza' , 'Al�m de coroar a d�cor da sua sala de estar com eleg�ncia e muito bom gosto, o Sof� Itagua� Prime tamb�m � a op��o certa para levar mais comodidade e bem-estar ao seu dia a dia. A estrutura interna conta com madeira eucalipto, que d� a resist�ncia necess�ria ao uso di�rio, e com estofamento na densidade ideal para deixar voc� e sua fam�lia bem � vontade. ', 11, 800.0, 3.299, 1,1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --5
('Tapete Org�nico Volcano 2,00 X 2,50 Colare Lisse Branco' , 'A magia deste formato: Irrompa com estilo e energia com o modelo Vulcano (vulc�o), que evoca a for�a e a intensidade dos elementos naturais. Seu padr�o vibrante e forma din�mica � uma declara��o de estilo audaciosa para seus espa�os. ', 5, 100.0, 855.53, 1,1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --6
('Bicicleta 29 Raider Z3x Pro 12v Azul + Preto' , 'A bike possui um quadro altamente resistente e leve, fabricado em alum�nio 6061, 12 combina��es de marcha para voc� encarar qualquer subida, freios hidr�ulicos que garantem sua seguran�a em qualquer ladeira e uma suspens�o 100mm com trava remota que proporciona conforto no seu percurso e mais desempenho quando travada!', 10, 500.0, 1.799, 1,1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --7
('Guarda Roupa Casal 3 Portas com Espelho 4 Gavetas Costa Rica Cinamomo/Off-White' , 'O guarda-roupa, al�m de ser um m�vel essencial para guardar as roupas e demais itens de uso pessoal, tamb�m � uma das pe�as mais importantes para compor a decora��o do quarto. O guarda-roupa casal, por ser mais amplo, � o queridinho na hora da decora��o.', 10, 600.0, 1.059, 1,1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES --8
('Vestido Longo Ver�o Veruska' , 'Ideal para mulhres elegantes e charmosas que desejam um visual deslumbrante e sofisticado para os dias quentes. Com um design moderno e detalhes cuidadosamente pensados.', 12, 60.0, 236.70, 1,1);


INSERT INTO ProdutoFoto (ProdutoId, Foto, Descricao) VALUES
(1, 'img/produto/1/1.jpeg', null),
(1, 'img/produto/1/2.jpeg', null),
(1, 'img/produto/1/3.jpeg', null),
(1, 'img/produto/1/4.png', null),
(2, 'img/produto/2/1.jpeg', null),
(2, 'img/produto/2/2.jpeg', null),
(2, 'img/produto/2/3.jpeg', null),
(2, 'img/produto/2/4.png', null),
(3, 'img/produto/3/1.jpeg', null),
(3, 'img/produto/3/2.jpeg', null),
(3, 'img/produto/3/3.jpeg', null),
(3, 'img/produto/3/4.png', null),
(4, 'img/produto/4/1.jpeg', null),
(4, 'img/produto/4/2.jpeg', null),
(4, 'img/produto/4/3.jpeg', null),
(4, 'img/produto/4/4.png', null),
(5, 'img/produto/5/1.jpeg', null),
(5, 'img/produto/5/2.jpeg', null),
(5, 'img/produto/5/3.png', null),
(6, 'img/produto/6/1.jpeg', null),
(6, 'img/produto/6/2.jpeg', null),
(6, 'img/produto/6/3.jpeg', null),
(6, 'img/produto/6/4.png', null),
(7, 'img/produto/7/1.jpeg', null),
(7, 'img/produto/7/2.jpeg', null),
(7, 'img/produto/7/3.png', null),
(8, 'img/produto/8/1.jpeg', null),
(8, 'img/produto/8/2.jpeg', null),
(8, 'img/produto/8/3.png', null),
(8, 'img/produto/8/4.jpeg', null);


