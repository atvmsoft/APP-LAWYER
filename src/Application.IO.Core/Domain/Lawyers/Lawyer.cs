using Application.IO.Core.Domain.Source.Models;
using Application.IO.Core.Identity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.IO.Core.Domain.Lawyers
{
    // Advogado
    [Table("Lawyers")]
    public class Lawyer : Entity
    {
        [Display(Name ="Cód. Usuário")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        public Guid IdApplicationUser { get; private set; }

        [Display(Name = "Nº OAB")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [MinLength(3, ErrorMessage = "O campo \"{0}\" deve possuir no mínimo {1} caracteres")]
        [MaxLength(10, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        public string OAB { get; private set; } //Número de registro da OAB

        //[Required, MaxLength(20)]
        //public string BusinessPhone { get; private set; } //Telefone profissional

        //[MaxLength(20)]
        //public string BusinessCellPhone { get; private set; } //Celular profissional

        //[MaxLength(20)]
        //public string BusinessFax { get; private set; } //Fax profissional

        [Display(Name = "Data Registro na Ordem")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        public DateTime DateRegistration { get; private set; } //Data de inscrição

        public Lawyer(Guid idApplicationUser, string oab, DateTime dateRegistration/*, string businessPhone, string businessCellPhone = null, string businessFax = null*/)
        {
            IdApplicationUser = idApplicationUser;
            OAB = oab;
            //BusinessPhone = businessPhone;
            //BusinessCellPhone = businessCellPhone;
            //BusinessFax = businessFax;
            DateRegistration = dateRegistration;
        }

        // EF Construtor
        protected Lawyer() { }

        // EF Propriedade de Navegação
        public virtual ICollection<OccupationAreasLawyer> OccupationAreasLawyer { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
