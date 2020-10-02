using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVGTechInfo.Connection
{
   public class Conexao
    {
        //String de conexão com o banco de dados.
        public string Server = "Server=127.0.0.1;port=3306;User Id=root;Database=vgti_system;password=";
        private static string strcon = "";

        public string Conn()
        {

            strcon = Server;

            return strcon;
        }

        public string ConsultaLogin()
        {
            return "SELECT VGTI_USUARIO, VGTI_SENHA FROM LOGIN_VGTI where VGTI_USUARIO=@usuario";
        }

        public string ConsultaInserirServico()
        {
            return "INSERT INTO SERVICOS_VGTI(VGTI_NOMEDOSERVICOS,VGTI_PRECO) VALUES (@nome,@preco)";
        }
        public string ConsultaExcluirServico()
        {
            return "delete from SERVICOS_VGTI where VGTI_IDSERVICOS=@id";
        }

        public string ConsultaProcurarServico()
        {
            return "SELECT VGTI_NOMEDOSERVICOS FROM servicos_vgti";
        }

        public string ConsultaProcurarPreco()
        {
            return "SELECT  VGTI_NOMEDOSERVICOS,VGTI_PRECO FROM servicos_vgti WHERE VGTI_NOMEDOSERVICOS=@servico";
        }

        public string ConsultaInserir()
        {
            return "INSERT INTO atendimentos_vgti(VGTI_NOME,VGTI_EQUIPAMENTO,VGTI_SERVICO,VGTI_PRECO) VALUES (@nome,@equipamento,@servico2,@preco)";
        }

    }
}
