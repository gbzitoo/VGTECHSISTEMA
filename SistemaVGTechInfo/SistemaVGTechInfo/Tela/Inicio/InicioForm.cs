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

namespace SistemaVGTechInfo.Tela.Inicio
{
    public partial class InicioForm : Form
    {
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        Conexao cn = new Conexao();
        public void mostraAbertos()
        {
            mDataSet = new DataSet();
            

            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("select VGTI_IDATENDIMENTO, VGTI_NOME, VGTI_EQUIPAMENTO, VGTI_SERVICO,VGTI_PRECO FROM atendimentos_vgti ORDER BY VGTI_IDATENDIMENTO", cn.Conn());

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "atendimentos_vgti");

            //atribui o resultado à propriedade DataSource da dataGridView
            data_db.DataSource = mDataSet;
            data_db.DataMember = "atendimentos_vgti";
        }

        public InicioForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InicioForm_Load(object sender, EventArgs e)
        {
            mostraAbertos();
        }

        private void data_db_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            fecharChamado chamados = new fecharChamado();

            chamados.chamadoFechado(int.Parse(text_cod.Text));
            chamados.ExcluindoChamadoAberto(int.Parse(text_cod.Text));
            mostraAbertos();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
