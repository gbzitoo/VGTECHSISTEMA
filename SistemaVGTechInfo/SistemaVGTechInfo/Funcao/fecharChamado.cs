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
    public class fecharChamado
    {
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;

        //Chamando a classe conexao
        Conexao c = new Conexao();
        private string mysql = string.Empty;

        public void chamadoFechado(int codigo)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(c.ConsultaFecharChamado(), sqlcon);
            comando.Parameters.Add("@codigoChamado", MySqlDbType.Int32).Value = codigo;


            try
            {
                if (codigo == 0)
                {
                    throw new Exception("Você precisa por um Codigo!");
                }
                sqlcon.Open();
                

                MySqlDataReader dr = comando.ExecuteReader();
               
                dr.Read();
               


            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                sqlcon.Close();
            }
           
         }

        public void ExcluindoChamadoAberto(int codigo)
        {
            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(c.ConsultaExcluirChamado(), sqlcon);
            comando.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;


            try
            {
                if (codigo == 0)
                {
                    throw new Exception("Você precisa por um Codigo!");
                }
                sqlcon.Open();


                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == false)
                {
                    MessageBox.Show("Chamado fechado.");
                }

                dr.Read();



            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
