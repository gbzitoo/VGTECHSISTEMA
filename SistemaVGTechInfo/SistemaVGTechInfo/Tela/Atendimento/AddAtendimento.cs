using MySql.Data.MySqlClient;
using SistemaVGTechInfo.Connection;
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

namespace SistemaVGTechInfo.Tela.Atendimento
{
    public partial class AddAtendimento : Form
    {
        public string ValorSelecionado { get; set; }

        InserirAtendimento inca = new InserirAtendimento();
        public AddAtendimento()
        {
            InitializeComponent();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValorSelecionado = Convert.ToString(CheckServicos.SelectedValue);

            text_preco.Clear();
            inca.PesquisarPreco(ValorSelecionado);

            text_preco.Text = inca.Preco;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
        //Chamando a classe conexao
        Conexao c = new Conexao();
        private string mysql = string.Empty;
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            try
            {
                String scom = "SELECT VGTI_NOMEDOSERVICOS FROM servicos_vgti";
                MySqlDataAdapter da = new MySqlDataAdapter(scom, c.Conn());
                DataTable dtResultado = new DataTable();
                dtResultado.Clear();
                CheckServicos.DataSource = null;
                da.Fill(dtResultado);
                CheckServicos.DataSource = dtResultado;
                CheckServicos.DisplayMember = "VGTI_NOMEDOSERVICOS";
                CheckServicos.ValueMember = "VGTI_NOMEDOSERVICOS";
                CheckServicos.SelectedItem = "";
                CheckServicos.Refresh();
                
            }
            catch (MySqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            InserirAtendimento inc = new InserirAtendimento();
            inc.CadastrarAtendimento(text_nome.Text,text_equipamento.Text,inca.Servico,inca.Preco);

        }

        private void AddAtendimento_Load(object sender, EventArgs e)
        {
           
        }

        private void text_preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
