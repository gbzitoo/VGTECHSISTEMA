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
    public class InserirServico
    {
      
        
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        Conexao c = new Conexao();
        private string mysql = string.Empty;

        public void Cadastrar(string nome, string preco)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(c.ConsultaInserirServico(), sqlcon);

           
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@preco", MySqlDbType.VarChar).Value = preco;
            

            try
            {
               
                if (nome == string.Empty)
                {
                    throw new Exception("Você precisa por um Nome!");
                }
                if (preco == string.Empty)
                {
                    throw new Exception("Você precisa por sua data de nascimento!");
                }
               


                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço Inserido com sucesso!");
                
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

        public void Deletar(int id)
        {
            //conexão
            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            // recebendo consulta e conexão
            MySqlCommand conn = new MySqlCommand(c.ConsultaExcluirServico(), sqlcon) ;

            //id digitado pelo usuario no textfield.
            conn.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            try
            {
                sqlcon.Open();
                MySqlDataReader dr = conn.ExecuteReader();
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Serviço excluido");
                }

                dr.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                sqlcon.Close();

            }

        }
    }
}
