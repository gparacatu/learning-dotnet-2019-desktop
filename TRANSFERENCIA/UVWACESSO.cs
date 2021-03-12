using System;

namespace TRANSFERENCIA
{
    public class UVWACESSO
    {
        public string Nome { get; set; }
        public string Crm { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime DataHoraSaida { get; set; }
        public string TempoTotal { get; set; }
        public Int64 IDColaborador { get; set; }
        public Byte[] Foto { get; set; }
    }
}
