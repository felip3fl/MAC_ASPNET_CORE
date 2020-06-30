using System;
using System.Collections.Generic;
using System.Text;
using Identity_AutenticaAutoriza.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity_AutenticaAutoriza.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }

    }
}
