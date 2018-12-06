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
        [Required, DataType("float")]
        public decimal LawyerScore { get; private set; }

        [Required, ForeignKey("Lawyer")]
        public Guid IdLawyer { get; private set; }

        [Required, ForeignKey("LawyerOccupationAreas")]
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
