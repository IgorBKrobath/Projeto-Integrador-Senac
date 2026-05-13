using System;
namespace SistemaAcademico.Models.Base;

public class PessoaJuridica : Pessoa
{
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }

    public bool ValidarCNPJ()
    {
        return !string.IsNullOrEmpty(Cnpj) && Cnpj.Length == 14;
    }
}