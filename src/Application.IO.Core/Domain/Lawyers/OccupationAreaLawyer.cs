using Application.IO.Core.Domain.Source.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.IO.Core.Domain.Lawyers
{
    // Advogados - Area de Ocupação
    //[Table("OccupationAreasLawyer")]
    public class OccupationAreaLawyer : Entity
    {
        [Display(Name = "Cód. Área de Ocuoação")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        //[ForeignKey("LawyerOccupationAreas")]
        public int IdLawyerOccupationArea { get; private set; }

        [Display(Name = "Cód. Advogado")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        //[ForeignKey("Lawyer")]
        public int IdLawyer { get; private set; }

        [Display(Name = "Score")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [Range(0, 5, ErrorMessage = "O campo \"{0}\" deve estar entre \"{1}\" e \"{2}\"")]
        public decimal LawyerScore { get; private set; }

        public OccupationAreaLawyer(decimal lawyerScore, int idLawyer, int idLawyerOccupationArea)
        {
            LawyerScore = LawyerScore;
            IdLawyer = idLawyer;
            IdLawyerOccupationArea = idLawyerOccupationArea;
        }

        // EF Construtor
        protected OccupationAreaLawyer() { }

        //// EF Propriedades de Navegação
        public virtual LawyerOccupationArea LawyerOccupationAreas { get; set; }
        public virtual Lawyer Lawyer { get; set; }
    }
}
