using Microsoft.EntityFrameworkCore;
using MVCALUNO.Models;
namespace MVCALUNO.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options) : base(options){}

        public DbSet<Aluno> Alunos{get; set;}
    }
}