##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Visitor 

> Bridge é um padrão de projeto de software, ou design pattern em inglês, utilizado quando é desejável que uma interface (abstração) possa variar independentemente das suas implementações.

> Imagine um sistema gráfico de janelas que deve ser portável para diversas plataformas. Neste sistema são encontrados diversos tipos de janelas, como ícones, diálogos, etc. Estas janelas formam uma hierarquia que contém uma abstração das janelas (classe base). Normalmente, a portabilidade seria obtida criando-se especializações dos tipos de janelas para cada uma das plataformas suportadas. O problema com essa solução reside na complexidade da hierarquia gerada e na dependência de plataforma que existirá nos clientes do sistema.

> Através do padrão Bridge, a hierarquia que define os tipos de janelas é separada da hierarquia que contém a implementação. Desta forma todas as operações de Janela são abstratas e suas implementações são escondidas dos clientes.

> O diagrama mostra a solução para o problema citado. Temos duas hierarquias de classes relacionadas: a hierarquia de tipos de janelas (Janela, Ícone e Dialogo) e a de implementação nas plataformas suportadas (JanelaImpl, XWindowImpl e MSWindowImpl). O relacionamento entre as interfaces, Janela e JanelaImpl, é a "ponte" que "desacopla" a interface da implementação. Para que um ícone seja desenhado, faz-se uma chamada ao método DesenhaBorda() que por sua vez realiza "n" chamadas ao método DesenhaLinha() da classe XWindowImpl ou MSWindowImpl, dependendo da plataforma desejada.

![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/c/c7/Bridge_-_2.png)

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using
```shell
$ git clone `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Bridge`
```

### Setup

> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  