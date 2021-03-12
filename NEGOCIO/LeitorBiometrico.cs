using System;
using NITGEN.SDK.NBioBSP;//DLL da NitGen para C#, precisa ser referenciada
using System.Windows.Forms;

namespace NEGOCIO
{
    public class LeitorBiometrico
    {
        //Variaveis Leitor NitGen
        NBioAPI m_NBioAPI;// Variavel da API que controla os metodos        short m_OpenedDeviceID; //Variavel para armazenar o ID do leitor que esta aberto
        private short m_OpenedDeviceID;
        NBioAPI.Type.HFIR m_hNewFIR; //Variavel para armazenar os templates das digitais
        NBioAPI.Type.WINDOW_OPTION m_WinOption;//Variavel para controlar as opcoes de janelas
        uint ret;//Variavel para verificar se ocorreu erro em cadastros e leituras
        NBioAPI.Type.FIR m_biFIR;//Variavel que armazena o tipo binario da digital
        NBioAPI.Type.FIR_TEXTENCODE m_textFIR;//Variavel que armazena o tipo texto da digital
        short iDeviceID = NBioAPI.Type.DEVICE_ID.AUTO;//parametro que define o tipo de busca de leitor
        //Fim das variaveis

        //Ao instanciar a classe
        public LeitorBiometrico()
        {
            m_NBioAPI = new NBioAPI();//cria o objeto
            m_OpenedDeviceID = NBioAPI.Type.DEVICE_ID.NONE;//zera a variavel com o id do leitor
            m_hNewFIR = null;//limpa a variavel de template
            m_WinOption = new NBioAPI.Type.WINDOW_OPTION();//cria o objeto

            //executa o metodo Open que abre o leitor
            //Open();
        }

        public void Open()
        {            
            // Open device
            ret = m_NBioAPI.OpenDevice(iDeviceID);//abre usando o parametro auto detect
            if (ret == NBioAPI.Error.NONE)//verifica se nao deu nenhum erro
            {
                m_OpenedDeviceID = iDeviceID;//popula a variavel com o ID do leitor encontrado

            }
            else
            {
                MessageBox.Show("Erro ao abrir o leitor");
            }

            //O leitor tambem pode ser aberto da seguinte forma
            //m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);

        }

        //fecha o leitor, na verdade o metodo dispose libera o leitar para o coletor de lixo
        public void Close()
        {
            m_NBioAPI.Dispose();

            //O leitor tambem pode ser fechado da seguinte forma
            //m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
        }

        //metodo para cadastrar as digitais
        public String Enroll()
        {
            Open();

            ret = m_NBioAPI.Enroll(ref m_hNewFIR, out m_hNewFIR, null, NBioAPI.Type.TIMEOUT.DEFAULT, null, null);//abre o programa de cadastro de digitais

            Close();
            
            //verifica se deu algum erro ao cadastrar as digitais
            if (ret == NBioAPI.Error.NONE)
            {
                // pega o codigo binario da nova digital e joga na variavel m_biFIR
                m_NBioAPI.GetFIRFromHandle(m_hNewFIR, out m_biFIR);
                
                // pega o texto criptografado das digitais e joga na variavel m_textFIR
                m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);
                
                //cria uma variavel de texto retorno e joga o texto criptografado das digitais dentro dela. Essa variavel que pode ser salva no banco de dados
                string retorno = m_textFIR.TextFIR;

                //Retorna as digitais em forma de texto
                return retorno;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar as digitais");
                return "0";
            }
        }

        //Metodo para verificar se duas digitais são iguais
        public bool Verificar(String BDdigital, NBioAPI.Type.HFIR captdigital)
        {
            try
            {
                //cria um objeto do tipo FIR_TEXTENCODE
                NBioAPI.Type.FIR_TEXTENCODE digital = new NBioAPI.Type.FIR_TEXTENCODE();

                //popula o objeto com a digital do banco de dados
                digital.TextFIR = BDdigital;

                //metodo que faz a verificação da digital capturada com a digital armazenada no banco de dados e popula a variavel result com true quando esta igual ou false quando esta diferente
                m_NBioAPI.VerifyMatch(captdigital, digital, out bool result, null);

                return result;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        //metodo para capturar a digital que sera verificada no banco de dados
        public NBioAPI.Type.HFIR Capturar()
        {
            try
            {
                Open();
                ////Inicializacao POPUP
                //opção para aparecer o programa pedindo para colocar o dedo no leitor
                m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.POPUP;
                
                // Window Option
                m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.NO_FPIMG;
                m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.NO_TOPMOST;
                m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.NO_WELCOME;
                
                //cria uma variavel do tipo template
                NBioAPI.Type.HFIR hCapturedFIR;

                //Captura a digital que sera comparada e joga na variavel de template hCapturedFIR
                m_NBioAPI.Capture(NBioAPI.Type.FIR_PURPOSE.VERIFY, out hCapturedFIR,NBioAPI.Type.TIMEOUT.DEFAULT, null, null);
                
                //faz a mesma coisa que o de cima, mas o de cima esta no manual por isso deixei
                //m_NBioAPI.Capture(out hCapturedFIR, NBioAPI.Type.TIMEOUT.DEFAULT, m_WinOption);
                Close();
                
                //retorna a variavel do tipo template da digital
                return hCapturedFIR;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }            
            

        }



    }
}
