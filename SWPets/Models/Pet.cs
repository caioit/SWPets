using System;

namespace SWPets.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetNome { get; set; }
        public string Especie { get; set; }
        public string Cor { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public int Castrado { get; set; }
        public string Vacinado { get; set; }
        public DateTime DataChegada { get; set; }
        public string Adotado { get; set; }
        public DateTime Nascimento { get; set; }
        public string Porte { get; set; }
        public int Observacao { get; set; }
        public int Adotante { get; set; }
        public int Cadastrador { get; set; }
    }
}