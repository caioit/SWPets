namespace SWPets.Repository
{
    public class Pets
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string especie { get; set; }
        public string cor { get; set; }
        public string raca { get; set; }
        public int idade { get; set; }
        public string castrado { get; set; }
        public string vacinacao { get; set; }
        public string dataChegada { get; set; }
        public string adotado { get; set; }
        public string nascimento { get; set; }
        public string porte { get; set; }
        public string observacao { get; set; }
        public int adotante { get; set; }
        public int cadastrador { get; set; }

        public Pets()
        {

        }
    }

}