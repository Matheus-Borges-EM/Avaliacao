using System;
namespace AtividadeMatheus.Negocio
{
    public enum TiposDePlano
    {
        privado = 0,
        publico = 1,
        particular = 2
    }

    public class Plano
    {
        public string NomeDoPlano { get; set; }

        public TiposDePlano TipoDoPlano { get; set; }

        public Plano(string nomeDoPlano, TiposDePlano tipoDoPlano)
        {
            NomeDoPlano = nomeDoPlano;
            TipoDoPlano = tipoDoPlano;
        }
    }
}
