// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Proj.Repository.Data;

namespace restaurante.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191104212047_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Proj.Domain.Entities.ContaLuz", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("data");
                     .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("idRestaurante");
                     .HasColumnType("integer");

                    b.Property<int?>("imovelid");
                     .HasColumnType("integer");

                    b.Property<int>("valor");
                     .HasColumnType("double media");

                    b.HasKey("id");

                    b.HasIndex("restauranteid");

                    b.ToTable("Consumos");
                });

            modelBuilder.Entity("Proj.Domain.Entities.Restaurante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("cidade")
                        .HasColumnType("text");

                    b.Property<string>("endereco")
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("Proj.Domain.Entities.Consumo", b =>
                {
                    b.HasOne("Proj.Domain.Entities.Restaurante", "restaurante")
                        .WithMany("consumo")
                        .HasForeignKey("restauranteid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}