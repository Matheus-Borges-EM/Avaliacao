using System;

namespace AtividadeMatheus.Negocio
{
    public class Consulta
    {
        public DateTime DataDaConsulta { get; set; }

        public Paciente Paciente { get; }
        public Medico Medico { get; }
    
        public Consulta(Paciente paciente, Medico medico, DateTime dataDaConsulta)
        {
            DataDaConsulta = dataDaConsulta;
            Paciente = paciente;
            Medico = medico;
        }
    }
}
