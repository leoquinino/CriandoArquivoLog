using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfigurationManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PathFile = ConfigurationManager.AppSettings["PathFileLog"];
            
            richTextBox1.Text = "";            
            richTextBox1.AppendText("Nome do Usuário: "                   + ConfigurationManager.AppSettings["Login"]);
            richTextBox1.AppendText(Environment.NewLine + "Senha :"       + ConfigurationManager.AppSettings["Senha"]);
            richTextBox1.AppendText(Environment.NewLine + "Email :"       + ConfigurationManager.AppSettings["Email"]);            
            richTextBox1.AppendText(Environment.NewLine + "LogAtivo :"    + ConfigurationManager.AppSettings["LogAtivo"]);
            richTextBox1.AppendText(Environment.NewLine + "PathFileLog :" + PathFile);

            System.Text.StringBuilder Mensagem = new System.Text.StringBuilder();

            for (var iConta = 0; iConta <= richTextBox1.Lines.Count() - 1; iConta++)
            {
                Mensagem.Append(richTextBox1.Lines[iConta].ToString() + Environment.NewLine);
            }

            //MessageBox.Show(Mensagem.ToString(), " TEXTO ", MessageBoxButtons.OK);

            GravaLog MeuLog = new GravaLog();

            MeuLog.grava(Mensagem.ToString(), PathFile);


            /*
            var MyConfig = ConfigurationManager.GetSection("appLogErros/Configuracoes") as NameValueCollection;                        

            if (MyConfig == "") 
            {
                Console.WriteLine("A seção <appLogErros> não esta definida");
            }
            else
            {                
                 foreach (var key in MyConfig.AllKeys)
                {
                    Console.WriteLine(key + " = " + MyConfig[key]);
                }                
            }
            */

        }
    }

    internal class NameValueFileCollection
    {
        internal object Get(string v)
        {
            throw new NotImplementedException();
        }
    }
}
