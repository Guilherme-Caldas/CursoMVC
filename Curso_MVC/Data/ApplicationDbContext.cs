using System.Collections.Immutable;
using Curso_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Curso_MVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            model.Entity<Aluno>().HasKey(p => p.Id);
            model.Entity<Aluno>().Property(alu => alu.Nome).HasMaxLength(50).IsRequired();
        }
    }
}