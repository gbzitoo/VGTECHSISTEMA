using SistemaVGTechInfo.Tela.Atendimento;
using SistemaVGTechInfo.Tela.Fechados;
using SistemaVGTechInfo.Tela.Inicio;
using SistemaVGTechInfo.Tela.Serviço;
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
    public partial class Form2 : Form
    {
        public Form _objAtendimento = new Form();
        public Form _objServiço = new Form();
        public Form _objInicio = new Form();
        public Form _objFechados = new Form();
        public Form2()
        {
            InitializeComponent();
            p_AreaLogado.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            _objServiço.Close();
            _objInicio.Close();
            _objFechados.Close();
            _objAtendimento?.Close();
            _objAtendimento = new AddAtendimento
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_AreaLogado.Controls.Add(_objAtendimento);
            _objAtendimento.Show();
            p_AreaLogado.Visible = true;
            _objServiço.Close();
            _objInicio.Close();
            _objFechados.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            _objAtendimento.Close();
            _objInicio.Close();
            _objFechados.Close();
            _objServiço?.Close();
            _objServiço = new AddServiço
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_AreaLogado.Controls.Add(_objServiço);
            _objServiço.Show();
            p_AreaLogado.Visible = true;
            _objAtendimento.Close();
            _objInicio.Close();
            _objFechados.Close();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Close();

            Form1 f1 = new Form1();
            f1.Close();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            _objAtendimento.Close();
            _objServiço.Close();
            _objFechados.Close();
            _objInicio?.Close();
            _objInicio = new InicioForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_AreaLogado.Controls.Add(_objInicio);
            _objInicio.Show();
            _objAtendimento.Close();
            _objServiço.Close();
            _objFechados.Close();
        }
        

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            _objAtendimento.Close();
            _objServiço.Close();
            _objInicio.Close();
            //Inicio
            _objFechados?.Close();
            _objFechados = new chamadosFechados
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_AreaLogado.Controls.Add(_objFechados);
            _objFechados.Show();
            //Fim
            _objAtendimento.Close();
            _objServiço.Close();
            _objInicio.Close();
        }

        private void p_AreaLogadol_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _objServiço.Close();
            _objInicio.Close();
            _objFechados.Close();
            _objAtendimento?.Close();
            _objAtendimento = new AddAtendimento
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_AreaLogado.Controls.Add(_objAtendimento);
            _objAtendimento.Show();
            p_AreaLogado.Visible = true;
            _objServiço.Close();
            _objInicio.Close();
            _objFechados.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _objAtendimento.Close();
            _objInicio.Close();
            _objFechados.Close();
            _objServiço?.Close();
            _objServiço = new AddServiço
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_AreaLogado.Controls.Add(_objServiço);
            _objServiço.Show();
            p_AreaLogado.Visible = true;
            _objAtendimento.Close();
            _objInicio.Close();
            _objFechados.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _objAtendimento.Close();
            _objServiço.Close();
            _objInicio.Close();
            //Inicio
            _objFechados?.Close();
            _objFechados = new chamadosFechados
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            p_AreaLogado.Controls.Add(_objFechados);
            _objFechados.Show();
            //Fim
            _objAtendimento.Close();
            _objServiço.Close();
            _objInicio.Close();
        }
    }
}
