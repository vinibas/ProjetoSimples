# ModelProject (Versión en español [aquí](README-es.md))

Criei este projeto como uma pequena demonstração da minha codificação.
É uma forma de demonstrar tanto meu estilo como parte dos meus conhecimentos de forma prática.

Criei uma versão inicial utilizando apenas um projeto com uma arquitetura simples. Se quiser, você pode conferí-lo no branch "ProjetoSimples".
A versão atual possui uma melhor divisão em camadas, que embora seja um overengineering, representa melhor um sistema corporativo real.
Como melhorias futuras, pretendo implementar ainda testes de unidade e de interface, mais funcionalidades e uso de outras tecnologias.

## SPA (Angular) & MPA (Asp.net MVC)

O ModelProject atualmente possui duas diferentes formas de implementação front-end similares: Asp.net MVC e Angular.
Pode ser que um projeto tenha funcionalidade que o outro ainda não possui. Estou atualizando e evoluindo ambos aos poucos.

Não esqueça de fazer um npm install no projeto de Angular para instalar todas as dependências, nem de fazer um Update-Database no Package Manager Console para criar o Banco de Dados.

## Tecnologias implementadas

O sistema foi construído em ASP.NET CORE 2.1, utilizando C#, e em Angular.
Segue abaixo um resumo das princiais tecnologías utilizadas:

* ASP.NET CORE MVC 2
* Angular 5
* C#
* Identity
* Entity Framework
* Bootstrap
* Sass

## Funcionalidades

Nessa primeira versão, foquei em demonstrar algumas funcionalidades. Seguem elas:

* Layout responsivo
* Cadastro de usuários
* Autenticação
* Validação de campos
* Internacionalização

## Instalação

Para executar a aplicação, é necessário antes gerar o Banco de Dados. Para isso, abra o "Console de Gerenciador de Pacotes" e execute os seguintes passos:
1. Selecione o projeto Vini.ModelProject.Infra.Data como projeto padrão
2. Execute o comando: Update-Database -Context ModelProjectContext
3. Selecione o projeto Vini.ModelProject.Infra.CrossCutting.Identity como projeto padrão
4. Execute o comando: Update-Database -Context IdentityDbContext

Para executar o projeto Angular, é necessário também instalar todas as dependências. Para isso, não esqueça de executar um "npm install" na pasta client.

### Contato e melhorias

Para maiores informações, pode me enviar uma mensagem ou me contactar também pelo [Linkedin](https://www.linkedin.com/in/vinicius-bastos/)

Caso tenha alguma sugestão de melhorias ou coisas que seriam interessantes eu implementar, não deixe de me enviar, eu fico agradecido.
