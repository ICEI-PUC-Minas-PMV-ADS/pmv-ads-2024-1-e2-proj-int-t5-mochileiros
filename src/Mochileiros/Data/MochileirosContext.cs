using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mochileiros.Models;

namespace Mochileiros.Data
{
    public class MochileirosContext : DbContext
    {
        public MochileirosContext(DbContextOptions<MochileirosContext> options)
            : base(options)
        {
        }

        public DbSet<Mochileiros.Models.Travel> Travel { get; set; } = default!;
        public DbSet<Mochileiros.Models.Group> Group { get; set; } = default!;
        public DbSet<Mochileiros.Models.User> User { get; set; } = default!;
        public DbSet<Mochileiros.Models.Expense> Expense { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
      .HasKey(u => u.Id); // Definindo a chave primária

            modelBuilder.Entity<Group>()
                .HasKey(g => g.Id); // Definindo a chave primária
            modelBuilder.Entity<Travel>()
                .HasKey(g => g.Id); // Definindo a chave primária
            modelBuilder.Entity<Expense>()
                .HasKey(g => g.Id); // Definindo a chave primária

            modelBuilder.Entity<Travel>().HasOne<Group>(t => t.Group) // Uma viagem pertence a um grupo
        .WithOne(g => g.Travel) // Um grupo possui uma viagem
        .HasForeignKey<Group>(g => g.TravelId); // Chave estrangeira para TravelId

            modelBuilder.Entity<Travel>()
.HasMany(g => g.Expenses) // Navigation property for Travel (collection of Expenses)
.WithOne(t => t.Travel)     // Navigation property for Expense (one Travel)
.HasForeignKey(t => t.TravelID); // Foreign key in the Expense table (case-sensitive)



            modelBuilder.Entity<Group>()
        .HasOne(g => g.Travel) // Um Grupo pertence a uma Travel
        .WithOne(t => t.Group) // Uma Travel possui um Grupo
        .HasForeignKey<Group>(g => g.TravelId); // Chave estrangeira para TravelId

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Users) // Um Grupo pode ter vários usuários
                .WithMany(u => u.Groups) // Um usuário pode pertencer a vários grupos
                .UsingEntity(j => j.ToTable("GroupUsers")); // Tabela de junção para a relação muitos-para-muitos

        }
    }
}
