using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSFERENCIA
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public String Nome { get; set; }
        public String Status { get; set; }
        public String Cep { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Uf { get; set; }
        public String TelFixo { get; set; }
        public String Celular { get; set; }
        public String TelContato { get; set; }
        public String Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public int NivelAcesso { get; set; }

    }
}
