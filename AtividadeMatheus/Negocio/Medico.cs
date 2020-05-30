using System;
using System.Collections.Generic;

namespace AtividadeMatheus.Negocio
{
    public class Medico : IDadosBasicos
    {
        public Endereco Endereco { get; set; }

        public string Nome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public int Idade { get; set; }

        private int CRM { get; set; }

        private readonly List<Especialidade> Especialidades = new List<Especialidade>();

        public Medico(IDadosBasicos dadosBasicos, Especialidade especialidade, int crm)
        {
            Endereco = dadosBasicos.Endereco;
            Nome = dadosBasicos.Nome;
            DataDeNascimento = dadosBasicos.DataDeNascimento;
            Idade = DateTime.Now.Year - DataDeNascimento.Year;
            CRM = crm;
            Especialidades.Add(especialidade);
        }
    }
}
