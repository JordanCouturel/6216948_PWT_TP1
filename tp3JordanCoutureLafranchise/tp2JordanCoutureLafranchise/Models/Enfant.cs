using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tp2JordanCoutureLafranchise.Models
{
    public class Enfant
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ParentId")]
        public int ParentId { get; set; }

        //propriété de navigation
        public Parent Parent { get; set; }

        public string ImageURL { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public int NumeroDeChandail { get; set; }

        public string Age { get; set; }

        public string Position { get; set; }

        public int Salaire { get; set; }

        public string Equipe { get; set; }

        public string EnVedette { get; set; }

        public bool Favoris { get; set; }


    }
}
