# Sistema de Gestão Universitária - Projeto Integrador
Este repositório contém o back-end do Projeto Integrador. O sistema foi projetado utilizando POO em C#. Simulando o gerenciamento das principais entidades de uma instituição de ensino.

## Tecnologias Utilizadas
* **Linguagem:** C# 
* **Framework:** .NET 9.0 

## Estrutura do Projeto

A arquitetura do projeto foi dividida separando a base lógica das entidades de negócio:

* `Models/Base/`
  * `Pessoa.cs`: Classe abstrata base do sistema.
  * `PessoaFisica.cs`: Herda de Pessoa (adiciona CPF, RG e validações).
  * `PessoaJuridica.cs`: Herda de Pessoa (adiciona CNPJ e Razão Social).
* `Models/`
  * `Aluno.cs`: Herda de PessoaFisica. Gerencia matrículas e cursos.
  * `Docente.cs`: Herda de PessoaFisica. Gerencia disciplinas, salários e horas.
  * `Fornecedor.cs`: Herda de PessoaJuridica. Gerencia serviços e prazos.

## Como executar o projeto localmente

1. Certifique-se de ter o .NET SDK instalado.
2. Clone este repositório:
   git clone [https://github.com/IgorBKrobath/Projeto-Integrador-Senac.git](https://github.com/IgorBKrobath/Projeto-Integrador-Senac.git)

* ## Equipe
* Jamile
* Julia
* Thais
* Igor Borges Krobath
* Yasmin
* Renan