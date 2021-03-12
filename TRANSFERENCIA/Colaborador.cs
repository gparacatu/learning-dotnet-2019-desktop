using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSFERENCIA
{
    public class Colaborador
    {
        public Int64 Id { get; set; }
        public String Nome { get; set; }
        public String Crm { get; set; }
        public String CrmUf { get; set; }
        public String Cep { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Uf { get; set; }
        public String TelFixo { get; set; }
        public String Celular { get; set; }
        public String TelContato { get; set; }
        public String Email { get; set; }
        public String Digital { get; set; }
        public String Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public Byte[] Foto { get; set; }

    }
}
