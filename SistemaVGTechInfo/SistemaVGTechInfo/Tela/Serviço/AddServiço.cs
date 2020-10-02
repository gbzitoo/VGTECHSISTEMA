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

namespace SistemaVGTechInfo.Tela.Serviço
{
    public partial class AddServiço : Form
    {
        public AddServiço()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            InserirServico inc = new InserirServico();
            inc.Cadastrar(Text_nomeservico.Text,Text_precoservico.Text);

            Text_nomeservico.Clear();
            Text_precoservico.Clear();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            InserirServico inc = new InserirServico();
            inc.Deletar(int.Parse(text_deletar.Text));
            text_deletar.Clear();
        }
    }
}
