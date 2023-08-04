using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tp2JordanCoutureLafranchise.Models
{
    public class Parent
    {
        [Key]
        public int ParentId { get; set; }

        public string Nom { get; set; }

        public int NbJoueurs { get; set; }

        public int SalaireMoyen { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }


        //propriété de navigation
        public List<Enfant> Enfants { get; set; }

    }
}
