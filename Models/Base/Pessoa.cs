using System;
namespace SistemaAcademico.Models.Base;

public abstract class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public virtual void Cadastrar()
    {
        Console.WriteLine($"{Nome} cadastrado(a) com sucesso no sistema acadêmico!");
    }

    public virtual void Atualizar()
    {
        Console.WriteLine($"Dados de {Nome} atualizados com sucesso!");
    }
}