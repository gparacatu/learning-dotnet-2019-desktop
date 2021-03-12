using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSFERENCIA
{
    public class Acesso
    {
        public int Id { get; set; }
        public DateTime DataHoraSaida { get; set; }
        public Int64 IdColaborador { get; set; }
        public String Digital { get; set; }
        public DateTime TempoTotal { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public String Verificador { get; set; }

    }
}
