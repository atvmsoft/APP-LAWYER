using Application.IO.Core.Domain.Source.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.IO.Core.Domain.Lawyers
{
    //Área de Atuação
    [Table("LawyerOccupationAreas")]
    public class LawyerOccupationArea : Entity
    {
        [Display(Name ="Nome")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [MinLength(3, ErrorMessage = "O campo \"{0}\" deve possuir no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        [DataType("varchar(200)")]
        public string Name { get; private set; }

        [Display(Name = "Score")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [Range(0, 5, ErrorMessage = "O campo \"{0}\" deve estar entre \"{1}\" e \"{2}\"")]
        public decimal MinScore { get; private set; }

        public LawyerOccupationArea(string name, decimal minScore)
        {
            Name = name;
            MinScore = minScore;
        }

        // EF Construtor
        protected LawyerOccupationArea() { }

        // EF Propriedade de Navegação
        public virtual ICollection<OccupationAreaLawyer> OccupationAreasLawyer { get; set; }
    }
}
