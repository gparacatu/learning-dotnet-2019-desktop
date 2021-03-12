using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRESENTACAO
{
    public class ControleFormulario
    {
        #region Consultas
        /*public static FrmConsultarCliente frmConsultar { get; set; }*/
        #endregion

        #region Formularios
        public static FrmCadastroMedicos frmCadastroMedicos { get; set; }
        public static FrmLogon  frmLogon { get; set; }
        public static FrmPrincipal frmPrincipal { get; set; }
        #endregion

        #region AbreConsultas
        /*public static void abreFrmConsultarCliente()
        {
            if (frmConsultar == null)
            {
                frmConsultar = new FrmConsultarCliente();
            }

            frmConsultar.ShowDialog();
            //frmConsultar.Focus();
        }*/
        #endregion

        #region Formularios
        public static void abreFrmCadastroMedicos()
        {
            if (frmCadastroMedicos == null)
            {
                frmCadastroMedicos = new FrmCadastroMedicos();
            }

            frmCadastroMedicos.ShowDialog();
            //frmCliente.Focus();
        }

        public static void abreFrmLogon()
        {
            if (frmLogon == null)
            {
                frmLogon = new FrmLogon();
            }

            frmLogon.ShowDialog();
            //frmCliente.Focus();
        }

        public static void abreFrmMenu()
        {
            if (frmPrincipal == null)
            {
                frmPrincipal = new FrmPrincipal();
            }

            frmPrincipal.ShowDialog();
            //frmCliente.Focus();
        }
        #endregion
    }
}
