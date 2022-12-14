// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tech_test_payment_api.Context;

#nullable disable

namespace techtestpaymentapi.Migrations
{
    [DbContext(typeof(VendasContext))]
    [Migration("20230106053418_TabelaVendaEVendedores")]
    partial class TabelaVendaEVendedores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tech_test_payment_api.Models.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Venda")
                        .HasColumnType("int")
                        .HasColumnName("id_venda");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_item");

                    b.HasKey("Id");

                    b.HasIndex("Id_Venda");

                    b.ToTable("ItemVenda", (string)null);
                });

            modelBuilder.Entity("tech_test_payment_api.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_venda");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_venda");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int")
                        .HasColumnName("id_vendedor");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status_venda");

                    b.HasKey("Id");

                    b.HasIndex("IdVendedor");

                    b.ToTable("Vendas", (string)null);
                });

            modelBuilder.Entity("tech_test_payment_api.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Vendedores", (string)null);
                });

            modelBuilder.Entity("tech_test_payment_api.Models.ItemVenda", b =>
                {
                    b.HasOne("tech_test_payment_api.Models.Venda", "Venda")
                        .WithMany("Itens")
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("tech_test_payment_api.Models.Venda", b =>
                {
                    b.HasOne("tech_test_payment_api.Models.Vendedor", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("IdVendedor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("tech_test_payment_api.Models.Venda", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("tech_test_payment_api.Models.Vendedor", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
