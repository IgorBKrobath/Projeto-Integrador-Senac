using System;
using SistemaAcademico.Models.Base;
namespace SistemaAcademico.Models;

public class Aluno : PessoaFisica
{
    public string Matricula { get; set; }
    public string Curso { get; set; }
    public DateTime DataIngresso { get; set; }

    public void ExibirDadosAluno()
    {
        Console.WriteLine("\n--- Dados do Aluno ---");
        Console.WriteLine($"Nome: {Nome} | CPF: {Cpf}");
        Console.WriteLine($"Curso: {Curso} | Matrícula: {Matricula}");
        Console.WriteLine($"Data de Ingresso: {DataIngresso.ToShortDateString()}");
    }
}