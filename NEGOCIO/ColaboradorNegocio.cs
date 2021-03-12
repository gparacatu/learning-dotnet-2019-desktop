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
    public class ColaboradorNegocio
    {
        Conexao conexao = new Conexao();

        public string Inserir(Colaborador colaborador)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@NOME", colaborador.Nome);
                conexao.AdicionarParametros("@CRM", colaborador.Crm);
                conexao.AdicionarParametros("@CRMUF", colaborador.CrmUf);
                conexao.AdicionarParametros("@CEP", colaborador.Cep);
                conexao.AdicionarParametros("@RUA", colaborador.Rua);
                conexao.AdicionarParametros("@BAIRRO", colaborador.Bairro);
                conexao.AdicionarParametros("@CIDADE", colaborador.Cidade);
                conexao.AdicionarParametros("@UF", colaborador.Uf);
                conexao.AdicionarParametros("@TELFIXO", colaborador.TelFixo);
                conexao.AdicionarParametros("@CELULAR", colaborador.Celular);
                conexao.AdicionarParametros("@TELCONTATO", colaborador.TelContato);
                conexao.AdicionarParametros("@EMAIL", colaborador.Email);
                conexao.AdicionarParametros("@DIGITAL", colaborador.Digital);
                conexao.AdicionarParametros("@STATUS", colaborador.Status);
                conexao.AdicionarParametros("@FOTO", colaborador.Foto);

                String IDColaborador = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USPINSERIRCOLABORADOR").ToString();

                return IDColaborador;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(Colaborador colaborador)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@ID", colaborador.Id);
                conexao.AdicionarParametros("@NOME", colaborador.Nome);
                conexao.AdicionarParametros("@CRM", colaborador.Crm);
                conexao.AdicionarParametros("@CRMUF", colaborador.CrmUf);
                conexao.AdicionarParametros("@CEP", colaborador.Cep);
                conexao.AdicionarParametros("@RUA", colaborador.Rua);
                conexao.AdicionarParametros("@BAIRRO", colaborador.Bairro);
                conexao.AdicionarParametros("@CIDADE", colaborador.Cidade);
                conexao.AdicionarParametros("@UF", colaborador.Uf);
                conexao.AdicionarParametros("@TELFIXO", colaborador.TelFixo);
                conexao.AdicionarParametros("@CELULAR", colaborador.Celular);
                conexao.AdicionarParametros("@TELCONTATO", colaborador.TelContato);
                conexao.AdicionarParametros("@EMAIL", colaborador.Email);
                conexao.AdicionarParametros("@DIGITAL", colaborador.Digital);
                conexao.AdicionarParametros("@STATUS", colaborador.Status);
                conexao.AdicionarParametros("@FOTO", colaborador.Foto);

                string IDColaborador = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USPALTERARCOLABORADOR").ToString();

                return IDColaborador;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Colaborador> ConsultarPorNome(string nome)
        {
            try
            {
                //ColaboradorColecao colaboradorColecao = new ColaboradorColecao();

                conexao.LimparParametros();

                conexao.AdicionarParametros("NOME", nome);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "USPCONSULTARCOLABORADORPORNOME");

                List<Colaborador> colaboradors = Convertions.ToList<Colaborador>(dataTable);

                //colaboradorColecao = colaboradors;

                /*foreach (DataRow dataRow in dataTable.Rows)
                {
                    Colaborador colaborador = new Colaborador();

                    colaborador.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    colaborador.Celular = Convert.ToString(dataRow["CELULAR"]);
                    colaborador.Cep = Convert.ToString(dataRow["CEP"]);
                    colaborador.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    colaborador.Crm = Convert.ToString(dataRow["CRM"]);
                    colaborador.CrmUf = Convert.ToString(dataRow["CRMUF"]);
                    colaborador.DataCadastro = Convert.ToDateTime(dataRow["DATACADASTRO"]);
                    colaborador.Digital = Convert.ToString(dataRow["DIGITAL"]);//(byte[])(dataRow["DIGITAL"]);
                    colaborador.Email = Convert.ToString(dataRow["EMAIL"]);
                    colaborador.Id = Convert.ToInt32(dataRow["ID"]);
                    colaborador.Nome = Convert.ToString(dataRow["NOME"]);
                    colaborador.Rua = Convert.ToString(dataRow["RUA"]);
                    colaborador.Status = Convert.ToString(dataRow["STATUS"]);
                    colaborador.TelContato = Convert.ToString(dataRow["TELCONTATO"]);
                    colaborador.TelFixo = Convert.ToString(dataRow["TELFIXO"]);
                    colaborador.Uf = Convert.ToString(dataRow["UF"]);
                    if (colaborador.Foto != null)
                    {
                        try
                        {
                            colaborador.Foto = MetodosPublicos.SerializeDataRow((DataRow)dataRow["FOTO"]);
                        }
                        catch (Exception ex)
                        {
                            colaborador.Foto = null;
                            throw new Exception();

                        }
                    }
                                       
                                        
                    colaboradorColecao.Add(colaborador);
                    
                }*/

                return colaboradors;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar colaboradores. Detalhes:"+ex.Message);
            }
        }


    }
}
