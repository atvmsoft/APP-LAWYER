using Application.IO.Core.Domain.Source.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.IO.Core.Domain.Lawyers
{
    //Área de Atuação
    [Table("LawyerOccupationAreas")]
    public class LawyerOccupationAreas : Entity
    {
        [Required, MaxLength(200), DataType("varchar(200)")]
        public string Name { get; private set; }

        [Required, DataType("float")]
        public decimal MinScore { get; private set; }

        public LawyerOccupationAreas(string name, decimal minScore)
        {
            Name = name;
            MinScore = minScore;
        }

        // EF Construtor
        protected LawyerOccupationAreas() { }

        // EF Propriedade de Navegação
        public virtual ICollection<OccupationAreasLawyer> OccupationAreasLawyer { get; set; }
    }
}
