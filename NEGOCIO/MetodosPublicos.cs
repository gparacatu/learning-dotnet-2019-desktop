using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NEGOCIO
{
    public class MetodosPublicos
    {
        public static string calcularIdade(DateTime dataNascimento)
        {
            try
            {
                int anos = DateTime.Now.Year - dataNascimento.Year;

                if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))
                {
                    anos--;

                }

                return anos.ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public static void LimparCamposTexto(Control control)
        {
            try
            {
                foreach (Control item in control.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        item.Text = string.Empty;
                    }
                    if (item.GetType() == typeof(MaskedTextBox))
                    {
                        item.Text = string.Empty;
                    }
                    if (item.GetType() == typeof(ComboBox))
                    {
                        item.Text = string.Empty;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Programação: " + ex.Message);
            }
        }

        public static byte[] SerializeDataRow(System.Data.DataRow row)
        {
            if (row == default(System.Data.DataRow))
                return default(byte[]);

            System.IO.MemoryStream memStream = new System.IO.MemoryStream();
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(object[]));
            serializer.Serialize(memStream, row.ItemArray);

            return memStream.ToArray();
        }
    }
}
