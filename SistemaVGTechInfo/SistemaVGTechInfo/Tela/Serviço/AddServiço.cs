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

namespace SistemaVGTechInfo.Tela.Serviço
{
    public partial class AddServiço : Form
    {
        public AddServiço()
        {
            InitializeComponent();
        }

        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        Conexao cn = new Conexao();

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
        public void mostraServico()
        {
            mDataSet = new DataSet();

            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("select * FROM servicos_vgti ORDER BY VGTI_IDSERVICOS", cn.Conn());

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "servicos_vgti");

            //atribui o resultado à propriedade DataSource da dataGridView
            data_db.DataSource = mDataSet;
            data_db.DataMember = "servicos_vgti";
        }
        private void AddServiço_Load(object sender, EventArgs e)
        {
            mostraServico();
        }
    }
}
