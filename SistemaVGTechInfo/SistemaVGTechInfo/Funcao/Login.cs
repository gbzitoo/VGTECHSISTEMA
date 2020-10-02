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

    public class Login
    {
        public string LoginBanco { get; set; }
        public string SenhaBanco { get; set; }

        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        Conexao c = new Conexao();
        private string mysql = string.Empty;

        public void Pesquisar(string usuario)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(c.ConsultaLogin(), sqlcon);

            comando.Parameters.Add("@usuario", MySqlDbType.String).Value = usuario;

            try
            {
                
                sqlcon.Open();
                MySqlDataReader dr = comando.ExecuteReader();


                dr.Read();

                LoginBanco = Convert.ToString(dr["VGTI_USUARIO"]);
                SenhaBanco = Convert.ToString(dr["VGTI_SENHA"]);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {

                sqlcon.Close();

            }

        }

    }
}
