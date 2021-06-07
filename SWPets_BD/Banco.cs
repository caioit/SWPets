using System;
using System.Configuration;
using System.Data.SqlClient;
using SWPets.Models;

namespace SWPets_BD
{
    public class Banco
    {
        
        public string senha = ConfigurationManager.AppSettings["UninoveSWPets"];

        SqlConnection conexao;

        public SqlConnection ConexaoBD()
        {           

            conexao = new SqlConnection(@"data source=swpets.database.windows.net ; User ID=caio.b ; Password=" + senha + " ; Initial Catalog=SWPets");
            conexao.Open();
            return conexao;

        }

        public SqlDataReader strQuerySelect()
        {
            
            string strQuerySelect = "SELECT * FROM PETS";
            conexao = ConexaoBD();
            SqlCommand cmdCoandoSelect = new SqlCommand(strQuerySelect, conexao);
            SqlDataReader dados = cmdCoandoSelect.ExecuteReader();
            return dados;
        }

        public void Construtor()
        {

        }
        
    }
}
