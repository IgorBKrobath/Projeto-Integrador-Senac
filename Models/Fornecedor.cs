using System;
using SistemaAcademico.Models.Base;
namespace SistemaAcademico.Models;

public class Fornecedor : PessoaJuridica
{
    public string TipoServico { get; set; }
    public string PrazoEntrega { get; set; }

    public void SolicitarOrcamento()
    {
        Console.WriteLine($"\nSolicitando orçamento para {RazaoSocial} (CNPJ: {Cnpj}).");
        Console.WriteLine($"Serviço requisitado: {TipoServico}. Prazo esperado: {PrazoEntrega}.");
    }
}