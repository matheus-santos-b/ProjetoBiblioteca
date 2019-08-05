﻿using BibliotecaDados.EntidadesConfig;
using BibliotecaDominio;
using BibliotecaDominio.Entidades;
using BibliotecaDominio.ObjetosValor;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaDados.Contexto
{
    class BibliotecaContext : DbContext
    {
        public DbSet<Assunto> Assuntos { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Classificacao> Classificacoes { get; set; }

        public DbSet<Editora> Editoras { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<ExemplarLivro> Exemplares { get; set; }

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Municipio> Municipios { get; set; }

        public DbSet<Pais> Paises { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public BibliotecaContext()
        {

        }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CPF>().HasKey("Cpf");
            modelBuilder.ApplyConfiguration(new AssuntoConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BibliotecaDB;Trusted_Connection=true;");
            }
        }
    }
}
