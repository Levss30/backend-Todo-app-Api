using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Usuario> usuarios { get; set; }

    }
}
