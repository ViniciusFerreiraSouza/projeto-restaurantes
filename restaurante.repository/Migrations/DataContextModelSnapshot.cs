// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Proj.Repository.Data;

namespace restaurante.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.0.0-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Proj.Domain.Entities.Consumo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idRestaurante")
                        .HasColumnType("integer");

                    b.Property<int?>("restauranteid")
                        .HasColumnType("integer");

                    b.Property<double>("valor")
                        .HasColumnType("double precision");

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