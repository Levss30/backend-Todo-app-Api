using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using TodoApi.Models;
using TodoApi.Utils;

namespace TodoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Usuario user = new Usuario();
            Criptografia.CriarSenhaHash("123456789", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Name = "Lucas";
            user.Sobrenome = "Andres";
            user.Email = "lucasapollar@gmail.com";
            user.Senha_hash = hash;
            user.Senha_salt = salt;
            user.Senha = string.Empty;

            modelBuilder.Entity<Usuario>().HasData(user);
        }
    }

}
