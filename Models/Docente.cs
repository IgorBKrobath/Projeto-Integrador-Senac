using System;
using SistemaAcademico.Models.Base;
namespace SistemaAcademico.Models;

public class Docente : PessoaFisica
{
    public string Titulacao { get; set; }
    public string AreaAtuacao { get; set; }
    public float Salario { get; set; }

    public void LancarNota()
    {
        Console.WriteLine($"O docente {Nome} lançou as notas da área de {AreaAtuacao}.");
    }

    public void ConsultarHorario()
    {
        Console.WriteLine($"Consultando grade de horários do professor {Nome}...");
    }
}