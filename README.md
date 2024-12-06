# Blog Pessoal - CRUD de Categorias e Produtos

Este projeto implementa um CRUD completo para gerenciar os recursos **Categoria** e **Produto** em um blog pessoal proposto pela **Generation**, desenvolvido com o framework .NET.

---

## Funcionalidades

### CRUD Completo para Categoria e Produto
Os recursos **Categoria** e **Produto** incluem operações de:
- **Criar** novos registros.
- **Consultar** todos os registros ou um específico por ID.
- **Atualizar** registros existentes.
- **Excluir** registros.

### Métodos Implementados
#### Categoria
- `GetAll()`: Retorna todas as categorias cadastradas.
- `GetById(id)`: Retorna uma categoria específica com base no ID.
- `Create(categoria)`: Cria uma nova categoria.
- `Update(categoria)`: Atualiza uma categoria existente.
- `Delete(id)`: Remove uma categoria do sistema.
- `GetByTipo(tipo)`: Retorna categorias filtradas pelo atributo **Tipo**.

#### Produto
- `GetAll()`: Retorna todos os produtos cadastrados.
- `GetById(id)`: Retorna um produto específico com base no ID.
- `Create(produto)`: Cria um novo produto.
- `Update(produto)`: Atualiza um produto existente.
- `Delete(id)`: Remove um produto do sistema.
- `GetByNome(nome)`: Retorna produtos filtrados pelo atributo **Nome**.

---

## Estrutura do Projeto

### Models
Define as classes `Categoria` e `Produto` com os seguintes atributos:

#### Categoria
- `Id`: Identificador único da categoria.
- `Tipo`: Representa o tipo da categoria.

#### Produto
- `Id`: Identificador único do produto.
- `Nome`: Nome do produto.
- `Preco`: Preço do produto.
- `CategoriaId`: Chave estrangeira para associar o produto a uma categoria.

### Services
- Interface `ICategoriaService`: Define os métodos abstratos para o CRUD de categorias e o método `GetByTipo()`.
- Interface `IProdutoService`: Define os métodos abstratos para o CRUD de produtos e o método `GetByNome()`.
- Classe `CategoriaService`: Implementa a lógica de negócios para categorias.
- Classe `ProdutoService`: Implementa a lógica de negócios para produtos.

### Controllers
- Classe `CategoriaController`: Gerencia os endpoints RESTful para cada operação do CRUD de categorias.
- Classe `ProdutoController`: Gerencia os endpoints RESTful para cada operação do CRUD de produtos.

### Program.cs
Configura o serviço de injeção de dependência no contêiner:
```csharp
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
