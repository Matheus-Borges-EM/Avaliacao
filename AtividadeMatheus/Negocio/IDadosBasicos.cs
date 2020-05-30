using System;

namespace AtividadeMatheus.Negocio
{
    public interface IDadosBasicos
    {
        public Endereco Endereco { get; set; }

        public string Nome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public int Idade { get; }
    }
}
