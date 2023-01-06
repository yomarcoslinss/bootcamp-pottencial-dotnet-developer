using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.Models;
using Microsoft.EntityFrameworkCore;

namespace tech_test_payment_api.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext(DbContextOptions<VendasContext> options) : base(options)
        {

        }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<ItemVenda> ItemVendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venda>()
                .ToTable("Vendas")
                .HasKey(v => v.Id);
            modelBuilder.Entity<Venda>()
                .Property(v => v.Id)
                .HasColumnName("id_venda");
            modelBuilder.Entity<Venda>()
                .Property(v => v.Data)
                .HasColumnName("data_venda");
            modelBuilder.Entity<Venda>()
                .Property(v => v.Status)
                .HasColumnName("status_venda");
            modelBuilder.Entity<Venda>()
                .Property(v => v.IdVendedor)
                .HasColumnName("id_vendedor");

            modelBuilder.Entity<Vendedor>()
                .ToTable("Vendedores")
                .HasKey(v => v.Id);
            modelBuilder.Entity<Vendedor>()
                .Property(v => v.Id)
                .HasColumnName("id");
            modelBuilder.Entity<Vendedor>()
                .Property(v => v.Cpf)
                .HasColumnName("cpf");
            modelBuilder.Entity<Vendedor>()
                .Property(v => v.Nome)
                .HasColumnName("nome");
            modelBuilder.Entity<Vendedor>()
                .Property(v => v.Email)
                .HasColumnName("email");
            modelBuilder.Entity<Vendedor>()
                .Property(v => v.Telefone)
                .HasColumnName("telefone");


            modelBuilder.Entity<ItemVenda>()
                .ToTable("ItemVenda")
                .HasKey(v => v.Id);
            modelBuilder.Entity<ItemVenda>()
                .Property(v => v.Id)
                .HasColumnName("id");
            modelBuilder.Entity<ItemVenda>()
                .Property(v => v.Id_Venda)
                .HasColumnName("id_venda");
            modelBuilder.Entity<ItemVenda>()
                .Property(v => v.Nome)
                .HasColumnName("nome_item");



            modelBuilder.Entity<Venda>()
                .HasOne(v => v.Vendedor)
                .WithMany(v => v.Vendas)
                .HasForeignKey(v => v.IdVendedor)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venda>()
                .HasMany(v => v.Itens)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ItemVenda>()
                .HasOne(i => i.Venda)
                .WithMany(v => v.Itens)
                .HasForeignKey(i => i.Id_Venda);


        }
    }
}