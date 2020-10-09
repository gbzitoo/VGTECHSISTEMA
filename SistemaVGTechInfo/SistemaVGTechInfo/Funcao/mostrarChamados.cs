using MySql.Data.MySqlClient;
using SistemaVGTechInfo.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVGTechInfo.Funcao
{
    public class mostrarChamados
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
            //data_db.DataSource = mDataSet;
            //data_db.DataMember = "atendimentos_vgti";
        }
    }
}
