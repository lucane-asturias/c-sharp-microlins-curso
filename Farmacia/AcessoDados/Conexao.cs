using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class Conexao
    {
        //Atributo que é a String de Conexão.
        private static string conexao = @"Data Source=LUCAS-PC\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True";

        //Método de acessor de leitura da String de Conexão.
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
