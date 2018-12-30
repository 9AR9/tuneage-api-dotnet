﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tuneage.Data.Orm.EF.DataContexts;

namespace Tuneage.Data.Migrations
{
    [DbContext(typeof(TuneageDataContext))]
    partial class TuneageDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tuneage.Domain.Entities.Label", b =>
                {
                    b.Property<int>("LabelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("LabelId");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("Tuneage.Domain.Entities.PrimaryCredType", b =>
                {
                    b.Property<string>("PrimaryCredTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("Weight");

                    b.HasKey("PrimaryCredTypeId");

                    b.ToTable("PrimaryCredTypes");
                });
#pragma warning restore 612, 618
        }
    }
}