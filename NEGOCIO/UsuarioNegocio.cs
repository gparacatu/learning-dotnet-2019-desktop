using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using TRANSFERENCIA;
using System.Data;

namespace NEGOCIO
{
    public class UsuarioNegocio
    {
        Conexao conexao = new Conexao();

        public string Inserir(Usuario usuario)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@NOME", usuario.Nome);
                conexao.AdicionarParametros("@LOGIN", usuario.Login);
                conexao.AdicionarParametros("@NIVELACESSO", usuario.NivelAcesso);
                conexao.AdicionarParametros("@CEP", usuario.Cep);
                conexao.AdicionarParametros("@RUA", usuario.Rua);
                conexao.AdicionarParametros("@BAIRRO", usuario.Bairro);
                conexao.AdicionarParametros("@CIDADE", usuario.Cidade);
                conexao.AdicionarParametros("@UF", usuario.Uf);
                conexao.AdicionarParametros("@TELFIXO", usuario.TelFixo);
                conexao.AdicionarParametros("@CELULAR", usuario.Celular);
                conexao.AdicionarParametros("@TELCONTATO", usuario.TelContato);
                conexao.AdicionarParametros("@EMAIL", usuario.Email);
                conexao.AdicionarParametros("@SENHA", usuario.Senha);
                conexao.AdicionarParametros("@STATUS", usuario.Status);
                conexao.AdicionarParametros("@DATACADASTRO", usuario.DataCadastro);

                String IDUsuario = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USPINSERIRUSUARIO").ToString();

                return IDUsuario;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(Usuario usuario)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@ID", usuario.Id);
                conexao.AdicionarParametros("@NOME", usuario.Nome);
                conexao.AdicionarParametros("@LOGIN", usuario.Login);
                conexao.AdicionarParametros("@NIVELACESSO", usuario.NivelAcesso);
                conexao.AdicionarParametros("@CEP", usuario.Cep);
                conexao.AdicionarParametros("@RUA", usuario.Rua);
                conexao.AdicionarParametros("@BAIRRO", usuario.Bairro);
                conexao.AdicionarParametros("@CIDADE", usuario.Cidade);
                conexao.AdicionarParametros("@UF", usuario.Uf);
                conexao.AdicionarParametros("@TELFIXO", usuario.TelFixo);
                conexao.AdicionarParametros("@CELULAR", usuario.Celular);
                conexao.AdicionarParametros("@TELCONTATO", usuario.TelContato);
                conexao.AdicionarParametros("@EMAIL", usuario.Email);
                conexao.AdicionarParametros("@SENHA", usuario.Senha);
                conexao.AdicionarParametros("@STATUS", usuario.Status);
                conexao.AdicionarParametros("@DATACADASTRO", usuario.DataCadastro);

                string IDUsuario = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USPALTERARUSUARIO").ToString();

                return IDUsuario;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public UsuarioColecao ConsultarPorNome(string nome)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("NOME", nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "USPCONSULTARUSUARIOPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    usuario.Celular = Convert.ToString(dataRow["CELULAR"]);
                    usuario.Cep = Convert.ToString(dataRow["CEP"]);
                    usuario.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    usuario.Login = Convert.ToString(dataRow["LOGIN"]);
                    usuario.Senha = Convert.ToString(dataRow["SENHA"]);
                    usuario.DataCadastro = Convert.ToDateTime(dataRow["DATACADASTRO"]);
                    usuario.NivelAcesso = Convert.ToInt32(dataRow["NIVELACESSO"]);
                    usuario.Email = Convert.ToString(dataRow["EMAIL"]);
                    usuario.Id = Convert.ToInt32(dataRow["ID"]);
                    usuario.Nome = Convert.ToString(dataRow["NOME"]);
                    usuario.Rua = Convert.ToString(dataRow["RUA"]);
                    usuario.Status = Convert.ToString(dataRow["STATUS"]);
                    usuario.TelContato = Convert.ToString(dataRow["TELCONTATO"]);
                    usuario.TelFixo = Convert.ToString(dataRow["TELFIXO"]);
                    usuario.Uf = Convert.ToString(dataRow["UF"]);

                    usuarioColecao.Add(usuario);

                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar usuários. Detalhes:" + ex.Message);
            }
        }

        public Usuario ConsultarPorUsuarioSenha(string usuario, string senha)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@USUARIO", usuario);
                conexao.AdicionarParametros("@SENHA", senha);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "USPLOGINCONSULTA");

                Usuario usuarioLogado = new Usuario();


                foreach (DataRow dataRow in dataTable.Rows)
                {
                    usuarioLogado.Login = Convert.ToString(dataRow["LOGIN"]);
                    usuarioLogado.Senha = Convert.ToString(dataRow["SENHA"]);
                }

                return usuarioLogado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar usuário. Detalhes: " + ex.Message);
            }
        }

    }
}
