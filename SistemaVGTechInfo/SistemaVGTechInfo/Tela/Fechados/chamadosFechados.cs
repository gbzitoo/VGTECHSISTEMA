using MySql.Data.MySqlClient;
using SistemaVGTechInfo.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVGTechInfo.Tela.Fechados
{
    public partial class chamadosFechados : Form
    {
        public chamadosFechados()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        Conexao cn = new Conexao();

        public void mostraFechados()
        {
            mDataSet = new DataSet();


            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("select VGTI_IDATENDIMENTO, VGTI_NOME, VGTI_EQUIPAMENTO, VGTI_SERVICO,VGTI_PRECO FROM atendimentosfechados_vgti ORDER BY VGTI_IDATENDIMENTO", cn.Conn());

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "atendimentosfechados_vgti");

            //atribui o resultado à propriedade DataSource da dataGridView
            data_db.DataSource = mDataSet;
            data_db.DataMember = "atendimentosfechados_vgti";
        }
        private void chamadosFechados_Load(object sender, EventArgs e)
        {
            mostraFechados();
        }
    }
}
