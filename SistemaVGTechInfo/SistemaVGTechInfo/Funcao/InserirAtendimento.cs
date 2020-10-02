using MySql.Data.MySqlClient;
using SistemaVGTechInfo.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVGTechInfo.Funcao
{
    public class InserirAtendimento
    {
        //1
        public string Servico { get; set; }
        public string Preco { get; set; }


       

        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        Conexao c = new Conexao();
        private string mysql = string.Empty;
        public void PesquisarPreco(string servicoPreco)
        {
            //Pesquisa Preco Inicio
            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand("SELECT VGTI_NOMEDOSERVICOS, VGTI_PRECO FROM servicos_vgti WHERE VGTI_NOMEDOSERVICOS=@VGTI_NOMEDOSERVICOS", sqlcon);

            comando.Parameters.Add("@VGTI_NOMEDOSERVICOS", MySqlDbType.VarChar).Value = servicoPreco;

            try
            {

                sqlcon.Open();
                MySqlDataReader dr = comando.ExecuteReader();


                dr.Read();


                Servico = Convert.ToString(dr["VGTI_NOMEDOSERVICOS"]);
                Preco = Convert.ToString(dr["VGTI_PRECO"]);


            }
            catch (Exception)
            {
                //MessageBox.Show("Erro na aplicação");
            }
            finally
            {
                sqlcon.Close();
            }
            //Pesquisa Preco Fim
        }

        public void CadastrarAtendimento(string nome, string equipamento,string servico, string preco)
        {
           

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(c.ConsultaInserir(), sqlcon);

            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@equipamento", MySqlDbType.VarChar).Value = equipamento;
            comando.Parameters.Add("@servico2", MySqlDbType.VarChar).Value = servico;
            comando.Parameters.Add("@preco", MySqlDbType.VarChar).Value = preco;

            try
            {
                
                if (nome == string.Empty)
                {
                    throw new Exception("Você precisa por um Nome!");
                }
                if (Convert.ToString(equipamento) == string.Empty)
                {
                    throw new Exception("Você precisa por um equipamento!");
                }
                


                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Atendimento cadastrado!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);

            }
            finally
            {

                sqlcon.Close();

            }
        }
    }
}
