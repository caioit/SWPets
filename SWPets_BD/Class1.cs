using System.Configuration;
using System.Data.SqlClient;

namespace SWPets_BD
{
    public class Class1
    {
        public string senha = ConfigurationManager.AppSettings["UninoveSWPets"];

        static void ConexaoBD(string[] args)
        {           

            SqlConnection conexao = new SqlConnection(@"data source=swpets.database.windows.net ; Integrated Security=caio.b ; Initial Catalog=" + senha );
            conexao.Open();

        }

        
    }
}
