using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Usuario
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        [NotMapped]
        public string Senha { get; set; }

        public byte[]? Senha_hash { get; set; }

        public byte[]? Senha_salt { get; set; }

        [NotMapped]
        public string Token { get; set; }
    }
}
