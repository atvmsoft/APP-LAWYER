using Application.IO.Core.Domain.Source.Models;
using Application.IO.Core.Identity.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.IO.Core.Domain.System
{
    // Usuários administradores do sistema
    [Table("AdmUsersSystem")]
    public class AdmUserSystem : Entity
    {
        [Required, ForeignKey("ApplicationUser")]
        public Guid IdApplicationUser { get; private set; }

        public AdmUserSystem(Guid idApplicationUser)
        {
            IdApplicationUser = idApplicationUser;
        }

        // EF Construtor
        protected AdmUserSystem() { }

        // EF Propriedade de Navegação
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
