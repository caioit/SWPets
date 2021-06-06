using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Display(Name = "Data de Chegada")]
        [DataType(DataType.Date)]
        public DateTime DataChegada { get; set; }

        public string Adotado { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        public string Porte { get; set; }
        public string Observacao { get; set; }
        public int Adotante { get; set; }
        public int Cadastrador { get; set; }
    }
}