using Application.IO.Core.Domain.Source.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.IO.Core.Domain.Lawyers
{
    // Advogados - Area de Ocupação
    [Table("OccupationAreasLawyer")]
    public class OccupationAreasLawyer : Entity
    {
        [Display(Name = "Score")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [Range(0, 5, ErrorMessage = "O campo \"{0}\" deve estar entre \"{1}\" e \"{2}\"")]
        public decimal LawyerScore { get; private set; }

        [Display(Name = "Cód. Advogado")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        public Guid IdLawyer { get; private set; }

        [Display(Name = "Cód. Área de Ocuoação")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        public Guid IdLawyerOccupationArea { get; private set; }

        public OccupationAreasLawyer(decimal lawyerScore, Guid idLawyer, Guid idLawyerOccupationArea)
        {
            LawyerScore = LawyerScore;
            IdLawyer = idLawyer;
            IdLawyerOccupationArea = idLawyerOccupationArea;
        }

        // EF Construtor
        protected OccupationAreasLawyer() { }

        //// EF Propriedades de Navegação
        public virtual Lawyer Lawyer { get; set; }
        public virtual LawyerOccupationAreas LawyerOccupationAreas { get; set; }
    }
}
