using System;
namespace SistemaAcademico.Models.Base;

public class PessoaFisica : Pessoa
{
    public string Cpf { get; set; }
    public string Rg { get; set; }

    public bool ValidarCPF()
    {
        return !string.IsNullOrEmpty(Cpf) && Cpf.Length == 11;
    }
}