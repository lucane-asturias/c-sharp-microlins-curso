using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Conexao
    {
        private static string conexao = @"Data Source=LUCAS-PC\SQLEXPRESS;Initial Catalog = Academia; Integrated Security = True";

        //Método acessor de leitura da String de Conexão
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
