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
        [Required, ForeignKey("ApplicationUser")]
        public Guid IdApplicationUser { get; private set; }

        [Required, MaxLength(10), DataType("varchar(10)")]
        public string OAB { get; private set; } //Número de registro da OAB

        //public string FatherName { get; private set; } //Nome do pai
        //public string MotherName { get; private set; } //Nome da mãe

        [Required, MaxLength(20), DataType("varchar(20)")]
        public string BusinessPhone { get; private set; } //Telefone profissional

        [MaxLength(20), DataType("varchar(20)")]
        public string BusinessCellPhone { get; private set; } //Celular profissional

        [Required, MaxLength(20), DataType("varchar(20)")]
        public string BusinessFax { get; private set; } //Fax profissional

        [Required, DataType("datetime")]
        public DateTime DateRegistration { get; private set; } //Data de inscrição

        //public string SiteUrl { get; private set; } //Site

        public Lawyer(Guid idApplicationUser, string oab, DateTime dateRegistration, /*string fatherName, string motherName,*/ string businessPhone, string businessCellPhone = null, string businessFax = null/*, string siteUrl = null*/)
        {
            IdApplicationUser = idApplicationUser;
            OAB = oab;
            //FatherName = fatherName;
            //MotherName = motherName;
            BusinessPhone = businessPhone;
            BusinessCellPhone = businessCellPhone;
            BusinessFax = businessFax;
            DateRegistration = dateRegistration;
            //SiteUrl = siteUrl;
        }

        // EF Construtor
        protected Lawyer() { }

        // EF Propriedade de Navegação
        public virtual ICollection<OccupationAreasLawyer> OccupationAreasLawyer { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
