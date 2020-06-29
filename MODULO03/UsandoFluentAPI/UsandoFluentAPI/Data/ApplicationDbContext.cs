using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsandoFluentAPI.Models;

namespace UsandoFluentAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //exclui a tabela do modelo do EF e logo a entidade não será mapeada
            builder.Ignore<LogAudit>();

            //mapeamento para entidade Usuario
            builder.Entity<Usuario>().ToTable("Usuarios");

            //valor da propriedade Id não deve ser gerado pelo BD
            builder.Entity<Usuario>().Property(p => p.Id).ValueGeneratedNever();

            //tamanho maximo para nome e email
            builder.Entity<Usuario>().Property(u => u.Nome).HasMaxLength(80).IsRequired();
            builder.Entity<Usuario>().Property(u => u.Email).HasMaxLength(150).IsRequired();

            //mapeamento para entidade Cliente
            builder.Entity<Cliente>().ToTable("Clientes");

            //chave primaria
            builder.Entity<Cliente>().HasKey(c => c.ClienteId);
            // tamanho máximo para as propriedades Nome,Endereco,Telefone e Cidade
            builder.Entity<Cliente>().Property(c => c.Telefone).HasMaxLength(20);
            builder.Entity<Cliente>().Property(c => c.Cidade).HasMaxLength(50);
            builder.Entity<Cliente>().Property(c => c.Endereco).HasMaxLength(100);
            builder.Entity<Cliente>().Property(c => c.Nome).HasMaxLength(80);

            //pedidos
            builder.Entity<Pedido>().ToTable("Pedidos");
            //propriedades
            builder.Entity<Pedido>().HasKey(p => p.PedidoId);

            //relacionamento entre clientes e pedidos
            //e desabilita deleção em cascata
            builder.Entity<Pedido>()
                .HasOne(c => c.Cliente)
                .WithMany(p => p.Pedidos)
                 .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
