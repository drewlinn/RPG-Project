using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RPG.Models;

namespace RPG.Migrations
{
    [DbContext(typeof(RPGContext))]
    [Migration("20170809182853_Authentication")]
    partial class Authentication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RPG.Models.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("image");

                    b.Property<int>("inventoryId");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Players");
                });
        }
    }
}
