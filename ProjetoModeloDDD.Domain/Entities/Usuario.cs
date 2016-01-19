using System;
using System.Collections.Generic;

namespace TurismoDDD.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }        
        public string Email { get; set; }
        public String Password {get;set;}

        public DateTime DataCadastro { get; set; }
        public DateTime DataInativacao { get; set; }
        
        List<Telefone> Telefones { get; set; }
        public Foto FotoPerfilId { get; set; }
        public TipoUsuario TipoUsuario;
        
        public virtual IEnumerable<Estabelecimento> Estabelecimentos { get; set; }

    }
}
