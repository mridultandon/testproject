﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestProject;

namespace TestProject.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20190822035131_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestProject.Entities.LoginModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.Property<int>("UserType");

                    b.HasKey("UserId");

                    b.ToTable("LoginModels");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "123456",
                            UserName = "Mridul",
                            UserType = 1
                        },
                        new
                        {
                            UserId = 2,
                            Password = "123456",
                            UserName = "Test",
                            UserType = 1
                        },
                        new
                        {
                            UserId = 3,
                            Password = "admin@12345",
                            UserName = "Admin",
                            UserType = 2
                        });
                });

            modelBuilder.Entity("TestProject.Entities.RequestModel", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<string>("Description");

                    b.Property<bool>("IsApproved");

                    b.Property<int>("UserId");

                    b.HasKey("RequestId");

                    b.ToTable("RequestModels");
                });
#pragma warning restore 612, 618
        }
    }
}
