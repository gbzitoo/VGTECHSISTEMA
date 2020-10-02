using SistemaVGTechInfo.Funcao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVGTechInfo
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Boolean tela { get; set; }

        public Form _objLogin = new Form();
        public Form1()
        {
            InitializeComponent();
            //Deixando o painel "invisivel"
            p_Principal.Visible = false;

        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logar_btn_Click(object sender, EventArgs e)
        {
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Pesquisar(txtUsuario.Text);
            if (txtUsuario.Text == log.LoginBanco && txtSenha.Text == log.SenhaBanco)
            {
                //Chamando o form cadastro no painel principal
                _objLogin?.Close();
                _objLogin = new Form2
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                p_Principal.Controls.Add(_objLogin);
                _objLogin.Show();
                p_Principal.Visible = true;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void p_Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_Principal_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
