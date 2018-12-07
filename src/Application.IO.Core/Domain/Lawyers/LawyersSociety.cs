﻿using Application.IO.Core.Domain.Source.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.IO.Core.Domain.Lawyers
{
    [Table("LawyersSociety")]
    public class LawyersSociety : Entity
    {
        [Display(Name = "Cód. Advogado")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        public Guid IdLawyer { get; private set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        public Guid IdPostalCodeAdress { get; private set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [MinLength(3, ErrorMessage = "O campo \"{0}\" deve possuir no mínimo {1} caracteres")]
        [MaxLength(80, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        public string Name { get; private set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [MaxLength(10, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        public string Number { get; private set; }

        [Display(Name = "Complemento")]
        [MaxLength(100, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        public string Complement { get; private set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo \"{0}\" é obrigatorio")]
        [MinLength(8, ErrorMessage = "O campo \"{0}\" deve possuir no mínimo {1} caracteres")]
        [MaxLength(20, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        [Phone(ErrorMessage = "O campo \"{0}\" é inválido")]
        public string BusinessPhone { get; private set; }

        [Display(Name = "Fax")]
        [MinLength(8, ErrorMessage = "O campo \"{0}\" deve possuir no mínimo {1} caracteres")]
        [MaxLength(20, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        [Phone(ErrorMessage = "O campo \"{0}\" é inválido")]
        public string BusinessFax { get; private set; }

        [Display(Name = "E-mail")]
        [MinLength(3, ErrorMessage = "O campo \"{0}\" deve possuir no mínimo {1} caracteres")]
        [MaxLength(256, ErrorMessage = "O campo \"{0}\" deve possuir no máximo {1} caracteres")]
        [EmailAddress(ErrorMessage = "O campo \"{0}\" é inválido")]
        public string BusinessEmail { get; private set; }
    }
}
