using System;
using SistemaAcademico.Models;
using SistemaAcademico.Models.Base;

namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIANDO INTEGRAÇÃO DO SISTEMA ACADÊMICO ===");

            // 1. Testando Aluno
            Aluno aluno = new Aluno
            {
                Nome = "Carlos Andrade",
                Cpf = "12345678900",
                Endereco = "Rua das Flores, 123",
                Telefone = "11999998888",
                Matricula = "2026001",
                Curso = "Engenharia de Software",
                DataIngresso = DateTime.Now
            };
            aluno.Cadastrar();
            aluno.ExibirDadosAluno();

            // 2. Testando Docente
            Docente docente = new Docente
            {
                Nome = "Prof. Silva",
                Cpf = "09876543211",
                Titulacao = "Mestre",
                AreaAtuacao = "Banco de Dados",
                Salario = 5500.00f
            };
            docente.LancarNota();

            // 3. Testando Fornecedor
            Fornecedor fornecedor = new Fornecedor
            {
                RazaoSocial = "Tech Equipamentos Ltda",
                Cnpj = "12345678000199",
                TipoServico = "Manutenção de Servidores",
                PrazoEntrega = "15 dias úteis"
            };
            fornecedor.SolicitarOrcamento();

            Console.WriteLine("\n=== TODOS OS TESTES PASSARAM COM SUCESSO ===");
        }
    }
}