using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Profanus.Infrastructure;

#nullable disable

namespace Profanus.Infrastructure.Migrations
{
    [DbContext(typeof(ProfanusDbContext))]
    partial class ProfanusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview");

            modelBuilder.Entity("Profanus.Domain.Entities.Dispositivo", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd().HasColumnType("uniqueidentifier");
                b.Property<string>("Name").IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
                b.Property<string>("IpAddress").IsRequired().HasMaxLength(50).HasColumnType("nvarchar(50)");
                b.Property<bool>("IsActive").HasColumnType("bit");
                b.HasKey("Id");
                b.ToTable("Dispositivos");
            });

            modelBuilder.Entity("Profanus.Domain.Entities.Sensor", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd().HasColumnType("uniqueidentifier");
                b.Property<string>("Name").IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
                b.Property<string>("Description").HasColumnType("nvarchar(max)");
                b.Property<int>("Status").HasColumnType("int");
                b.Property<DateTime>("LastReading").HasColumnType("datetime2");
                b.Property<Guid?>("DispositivoId").HasColumnType("uniqueidentifier");
                b.HasKey("Id");
                b.HasIndex("DispositivoId");
                b.ToTable("Sensors");
                b.HasOne("Profanus.Domain.Entities.Dispositivo", null).WithMany("Sensors").HasForeignKey("DispositivoId");
            });
        }
    }
}
