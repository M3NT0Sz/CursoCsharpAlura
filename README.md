# 🎵 Screen Sound

Projeto desenvolvido durante a formação **"Aprenda a programar em C# com Orientação a Objetos"** da [Alura](https://www.alura.com.br/).

## 📚 Sobre o Projeto

O **Screen Sound** é uma aplicação console em C# que simula um sistema de gerenciamento de bandas, álbuns e músicas. O projeto foi construído ao longo de 4 cursos, evoluindo gradualmente desde conceitos básicos até tópicos avançados como consumo de APIs e manipulação de dados com LINQ.

## 🎓 Cursos da Formação

O projeto foi desenvolvido nos seguintes cursos:

1. **C#: criando sua primeira aplicação**
   - Fundamentos da linguagem C#
   - Estruturas de controle e repetição
   - Manipulação de strings e tipos de dados básicos

2. **C#: aplicando a Orientação a Objetos**
   - Criação de classes e objetos
   - Encapsulamento e propriedades
   - Coleções e listas

3. **C#: dominando Orientação a Objetos**
   - Herança e interfaces
   - Polimorfismo
   - Organização de código em namespaces
   - Padrões de projeto

4. **C#: consumindo API, gravando arquivos e utilizando o LINQ**
   - Requisições HTTP com HttpClient
   - Serialização e desserialização JSON
   - Manipulação de arquivos
   - LINQ para consultas e filtros

## ✨ Funcionalidades

### Sistema de Menus Interativo
- **Registrar Banda**: Cadastro de novas bandas no sistema
- **Registrar Álbum**: Adiciona álbuns às bandas cadastradas
- **Mostrar Bandas**: Lista todas as bandas registradas
- **Avaliar Banda**: Sistema de avaliação com notas
- **Avaliar Álbum**: Avaliação individual de álbuns
- **Exibir Detalhes**: Visualização completa da discografia de uma banda

### Consumo de API
- Integração com API externa de músicas
- Processamento de dados em formato JSON
- Tratamento de exceções em requisições HTTP

### Manipulação de Dados com LINQ
- Filtragem de músicas por gênero
- Filtragem de artistas específicos
- Ordenação de listas
- Operações de consulta avançadas

### Geração de Arquivos
- Exportação de músicas favoritas em formato JSON
- Gravação de dados em arquivos locais

## 🏗️ Estrutura do Projeto

```
C#/
├── Modelos/
│   ├── Banda.cs              # Classe que representa uma banda
│   ├── Album.cs              # Classe que representa um álbum
│   ├── Musica.cs             # Classe que representa uma música
│   ├── Musica2.cs            # Modelo para dados da API
│   ├── Avaliacao.cs          # Sistema de avaliação
│   ├── IAvaliavel.cs         # Interface para objetos avaliáveis
│   └── MusicasPreferidas.cs  # Gerenciamento de músicas favoritas
├── Menus/
│   ├── Menu.cs               # Classe base abstrata para menus
│   ├── MenuRegistrarBanda.cs
│   ├── MenuRegistrarAlbum.cs
│   ├── MenuMostrarBandas.cs
│   ├── MenuAvaliarBanda.cs
│   ├── MenuAvaliarAlbum.cs
│   ├── MenuExibirDetalhes.cs
│   └── MenuSair.cs
├── Filtros/
│   ├── LinqFilter.cs         # Filtros usando LINQ
│   └── LinqOrder.cs          # Ordenações usando LINQ
├── Http.cs                   # Requisições HTTP e consumo de API
└── Program.cs                # Ponto de entrada da aplicação
```

## 🔧 Conceitos Aplicados

### Orientação a Objetos
- **Classes e Objetos**: Modelagem de entidades do domínio
- **Encapsulamento**: Propriedades com get/set apropriados
- **Herança**: Classe base `Menu` para diferentes tipos de menus
- **Interfaces**: `IAvaliavel` implementada por `Banda` e `Album`
- **Polimorfismo**: Método `Executar` implementado de forma diferente em cada menu

### Coleções e Estruturas de Dados
- `List<T>`: Listas genéricas para músicas, álbuns e avaliações
- `Dictionary<TKey, TValue>`: Armazenamento de bandas e opções de menu

### LINQ (Language Integrated Query)
- `Select`: Projeção de dados
- `Where`: Filtragem de elementos
- `Distinct`: Remoção de duplicatas
- `OrderBy`: Ordenação de coleções
- `Average`: Cálculo de médias
- `Sum`: Soma de valores

### Programação Assíncrona
- `async/await`: Requisições HTTP não bloqueantes
- `HttpClient`: Cliente para comunicação HTTP

### Manipulação de JSON
- `JsonSerializer`: Serialização e desserialização de objetos
- Trabalho com APIs REST

## 🚀 Como Executar

### Pré-requisitos
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)

### Executando o projeto
```bash
# Clone o repositório ou navegue até a pasta do projeto
cd "C:\Users\Matheus\Documents\Alura\C#"

# Execute o projeto
dotnet run
```

## 🎯 Exemplos de Uso

### Navegação no Menu Principal
```
Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para avaliar um álbum
Digite 6 para exibir os detalhes de uma banda
Digite -1 para sair
```

### Filtragem com LINQ (no arquivo Http.cs)
```csharp
// Filtrar todos os gêneros musicais disponíveis
LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

// Filtrar artistas por gênero
LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "Rock");

// Filtrar músicas de um artista específico
LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Post Malone");
```

## 📈 Aprendizados

Durante o desenvolvimento deste projeto, foram consolidados conhecimentos em:

- ✅ Fundamentos da linguagem C#
- ✅ Paradigma de Orientação a Objetos
- ✅ Estruturas de dados e coleções
- ✅ Consumo de APIs REST
- ✅ Serialização e desserialização JSON
- ✅ Manipulação de arquivos
- ✅ LINQ e expressões lambda
- ✅ Programação assíncrona
- ✅ Tratamento de exceções
- ✅ Organização e arquitetura de código

## 🎓 Certificação

Projeto desenvolvido como parte da formação **"Aprenda a programar em C# com Orientação a Objetos"** da Alura.

## 👨‍💻 Autor

**Matheus Mendes Dos Santos**

Desenvolvido durante os estudos na plataforma Alura - Janeiro de 2026.

---

⭐ **Screen Sound** - Sistema de Gerenciamento Musical em C#
