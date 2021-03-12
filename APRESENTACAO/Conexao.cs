using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace APRESENTACAO
{
    public static class Conexao
    {
        public static string RetornaStringConexao()
        {
            //faz leitura do arquivo de configuracao
            string arquivo;
            System.IO.StreamReader file = new System.IO.StreamReader(@"asql.txt");
            arquivo = file.ReadLine() +"User ID=sa;Password=8944989";

            return arquivo;

        }
        //Cria uma nova string de conexao e retorna a string
        public static void CriaStringConexao()
        {
            //Cria a string de conexao
            try
            {

                // Referência ao arquivo de configuração do o aplicativo.
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                // Uma seção connectionStrings.
                ConnectionStringsSection csSection = config.ConnectionStrings;
                // Adiona string de conexão à seção
                csSection.ConnectionStrings.Add(new ConnectionStringSettings("Conexao", RetornaStringConexao()));
                // Grava.
                config.Save(ConfigurationSaveMode.Modified);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
