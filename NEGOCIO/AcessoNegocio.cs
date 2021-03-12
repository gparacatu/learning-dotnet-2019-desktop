using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using TRANSFERENCIA;
using System.Data;
using System.Windows.Forms;

namespace NEGOCIO
{
    public class AcessoNegocio
    {
        Conexao conexao = new Conexao();

        public String RegistrarPonto(Acesso acesso)
        {
            try
            {
                conexao.LimparParametros();

                conexao.AdicionarParametros("@IDCOLABORADOR", acesso.IdColaborador);
                conexao.AdicionarParametros("@DIGITAL", acesso.Digital);

                String IDUsuario = conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USPACESSO").ToString();

                return IDUsuario;
            }
            catch (Exception ex)
            {

                return ex.Message;

            }
        }

        public UVWACESSO ConsultarUltimoAcesso(Int64 IDColaborador)
        {
            try
            {                
                conexao.LimparParametros();

                conexao.AdicionarParametros("IDCOLABORADOR", IDColaborador);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "USPULTIMOACESSO");

                List<UVWACESSO> uvwAcesso = Convertions.ToList<UVWACESSO>(dataTable);


                /*foreach (DataRow dataRow in dataTable.Rows)
                {

                    uvwAcesso.Nome = Convert.ToString(dataRow["NOME"]);
                    uvwAcesso.Crm = Convert.ToString(dataRow["CRM"]);
                    uvwAcesso.DataHoraEntrada = Convert.ToString(dataRow["DATAHORAENTRADA"]);
                    uvwAcesso.DataHoraSaida = Convert.ToString(dataRow["DATAHORASAIDA"]);
                    uvwAcesso.TempoTotal = Convert.ToString(dataRow["TEMPOTOTAL"]);
                    uvwAcesso.IDColaborador = Convert.ToInt64(dataRow["IDCOLABORADOR"]);
                    uvwAcesso.Foto = (Byte[])dataRow["FOTO"];

                }*/

                return uvwAcesso[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception("Erro ao consultar ponto. Detalhes:" + ex.Message);
                
                
            }
        }

        public DataTable ConsultarPontosGeral(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                UVWACESSO uvwAcesso = new UVWACESSO();


                conexao.LimparParametros();

                conexao.AdicionarParametros("INICIAL", dataInicial);
                conexao.AdicionarParametros("FINAL", dataFinal);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "USPRELATORIOACESSOPORPERIODO");


                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar ponto. Detalhes:" + ex.Message);
            }
        }

        public DataTable ConsultarPontosMedico(DateTime dataInicial, DateTime dataFinal, Colaborador colaborador)
        {
            try
            {
                UVWACESSO uvwAcesso = new UVWACESSO();


                conexao.LimparParametros();

                conexao.AdicionarParametros("INICIAL", dataInicial);
                conexao.AdicionarParametros("FINAL", dataFinal);
                conexao.AdicionarParametros("IDCOLABORADOR", colaborador.Id);

                DataTable dataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "USPRELATORIOACESSOPORIDEPERIODO");

                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar ponto. Detalhes:" + ex.Message);
            }
        }



    }
}
