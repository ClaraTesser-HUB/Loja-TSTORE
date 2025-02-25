USE lojinha;
GO

-- Comandos DML - Data Manipulation Language
-- Inserir dados
INSERT INTO Categoria(Nome, ExibirHome, Foto) VALUES 
('Lazer', 1, 'img/), ('Casa', 1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId) VALUES 
('Paleta Sombras Océane Edition 6 Eyeshadow Palette Glorious 7,8g', 'Procurando uma paleta de sombras versátil e moderna. A 6 Palette Edition Glorious é perfeita para te acompanhar nas makes mais básicas e nas mais elaboradas, com cores modernas, muita pigmentação e fixação.',
(6, 20.0, 79.90, 1, 1); 

INSERT INTO ProdutoFoto (ProdutoId, Foto, Descricao)
