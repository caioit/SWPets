using MySqlConnector;
using System;

namespace WebApplication1.Repository
{
    public class MySqlRepository
    {
        public MySqlRepository()
        {

        }

        public bool PersistPet()
        {

            var pet = new Pets
            {
                codigo = 5500,
                nome = "Totó",
                especie = "Cachorro",
                cor = "Marrom",
                raca = "Vira-lata",
                idade = 12,
                castrado = "Sim",
                vacinacao = "atualizada",
                dataChegada = DateTime.Today.ToString(),
                adotado = "Sim",
                nascimento = "30/5/2020",
                porte = "medio",
                observacao = "teste api",
                adotante = 123,
                cadastrador = 123
            };

            try
            {
                string connectionString = "Persist Security Info=False;server = fdb21.awardspace.net; port=3306; Database = 3849626_swpets; User= 3849626_swpets; Password = swpets07;";
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();

                string commandStr = "INSERT INTO 3849626_swpets.pets ((codigo,nome,especie,cor,raca,idade,castrado,vacinacao,dataChegada,adotado,nascimento,porte,observacao,adotante,cadastrador))" +
                   $"VALUES({pet.codigo},{pet.nome},{pet.especie},{pet.cor},{pet.raca},{pet.idade},{pet.castrado},{pet.vacinacao},{pet.dataChegada},{pet.adotado},{pet.nascimento},{pet.porte},{pet.observacao},{pet.adotante},{pet.cadastrador})";
                MySqlCommand command = new MySqlCommand(commandStr, cnn);
                int value = command.ExecuteNonQuery();

                cnn.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public Pets GetPetById(string codigoPet)
        {
            try
            {
                string connectionString = "Persist Security Info=False;server = fdb21.awardspace.net; port=3306; Database = 3849626_swpets; User= 3849626_swpets; Password = swpets07;";

                var cnn = new MySqlConnection(connectionString);

                cnn.Open();

                string commandStr = "SELECT * FROM 3849626_swpets.pets  WHERE codigo='" + codigoPet + "'";

                var command = new MySqlCommand(commandStr, cnn);
                var datareader = command.ExecuteReader();

                var resultPet = new Pets
                {
                    codigo = (int)datareader[0],
                    nome = datareader[1].ToString(),
                    especie = datareader[2].ToString(),
                    cor = datareader[3].ToString(),
                    raca = datareader[4].ToString(),
                    idade = (int)datareader[5],
                    castrado = datareader[6].ToString(),
                    vacinacao = datareader[7].ToString(),
                    dataChegada = datareader[8].ToString(),
                    adotado = datareader[9].ToString(),
                    nascimento = datareader[10].ToString(),
                    porte = datareader[11].ToString(),
                    observacao = datareader[12].ToString(),
                    adotante = (int)datareader[13],
                    cadastrador = (int)datareader[14]
                };

                cnn.Close();
                return resultPet;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
