﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PUG;

namespace PUG.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20210207033339_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PUG.Models.Guild", b =>
                {
                    b.Property<decimal>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.HasKey("ID");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("PUG.Models.TextChannel", b =>
                {
                    b.Property<decimal>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<int>("ChannelType")
                        .HasColumnType("int");

                    b.Property<decimal?>("GuildID")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("ID");

                    b.HasIndex("GuildID");

                    b.ToTable("TextChannels");
                });

            modelBuilder.Entity("PUG.Models.TextChannel", b =>
                {
                    b.HasOne("PUG.Models.Guild", "Guild")
                        .WithMany("TextChannels")
                        .HasForeignKey("GuildID");

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("PUG.Models.Guild", b =>
                {
                    b.Navigation("TextChannels");
                });
#pragma warning restore 612, 618
        }
    }
}
