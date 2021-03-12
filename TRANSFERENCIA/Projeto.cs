using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSFERENCIA
{
    public class Projeto
    {
        public int Id { get; set; }
        public String Razao { get; set; }
        public String Fantasia { get; set; }
        public String Cnpj { get; set; }
        public String Status { get; set; }
        public String Cep { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Uf { get; set; }
        public String TelFixo { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
