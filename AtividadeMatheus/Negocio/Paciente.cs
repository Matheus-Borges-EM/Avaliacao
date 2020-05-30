using System;

namespace AtividadeMatheus.Negocio
{
    public class Paciente : IDadosBasicos
    {
        public Endereco Endereco { get; set; }

        public string Nome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public int Idade { get; }

        public Plano Plano { get; set; }        

        public Paciente(IDadosBasicos dadosBasicos, Plano plano)
        {
            Endereco = dadosBasicos.Endereco;
            Nome = dadosBasicos.Nome;
            DataDeNascimento = dadosBasicos.DataDeNascimento;
            Idade = DateTime.Now.Year - DataDeNascimento.Year;
            Plano = plano;
        }        
    }
}
