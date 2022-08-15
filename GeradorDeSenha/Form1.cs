using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.servicoSoapClient ws = new ServiceReference1.servicoSoapClient();
                this.lb1.Text = ws.CriarSenha();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro 500");
            }
        
        }
    }
}