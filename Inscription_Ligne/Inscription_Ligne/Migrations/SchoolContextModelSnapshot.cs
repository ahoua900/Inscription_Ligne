﻿// <auto-generated />
using System;
using Inscription_Ligne.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inscription_Ligne.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inscription_Ligne.Models.Eleves", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classe_Eleve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contact_Parent")
                        .HasColumnType("int");

                    b.Property<string>("Email_Parent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etablissement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EtablissementIdEtablissment")
                        .HasColumnType("int");

                    b.Property<string>("Extrait_naissance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Matricule_Eleve")
                        .HasColumnType("int");

                    b.Property<string>("Nom_Eleve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom_Eleve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MyProperty");

                    b.HasIndex("EtablissementIdEtablissment");

                    b.ToTable("Eleves");
                });

            modelBuilder.Entity("Inscription_Ligne.Models.Etablissement", b =>
                {
                    b.Property<int>("IdEtablissment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attestation_Etablissment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code_Etablissment")
                        .HasColumnType("int");

                    b.Property<string>("Email_Etablissment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Enseignement_Etablissment")
                        .HasColumnType("int");

                    b.Property<int>("IdEleve")
                        .HasColumnType("int");

                    b.Property<int>("IdNiveau")
                        .HasColumnType("int");

                    b.Property<string>("Localité_Etablissment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom_Etablissment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Scolarité_Etablissment")
                        .HasColumnType("int");

                    b.Property<string>("Statut_Etablissment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Etablissment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEtablissment");

                    b.ToTable("Etablissements");
                });

            modelBuilder.Entity("Inscription_Ligne.Models.Niveau", b =>
                {
                    b.Property<int>("IdNiveau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EtablissementIdEtablissment")
                        .HasColumnType("int");

                    b.Property<string>("Montant_Affecte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Montant_NonAffecte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom_Niveau")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNiveau");

                    b.HasIndex("EtablissementIdEtablissment");

                    b.ToTable("Niveaus");
                });

            modelBuilder.Entity("Inscription_Ligne.Models.Eleves", b =>
                {
                    b.HasOne("Inscription_Ligne.Models.Etablissement", null)
                        .WithMany("Eleves")
                        .HasForeignKey("EtablissementIdEtablissment");
                });

            modelBuilder.Entity("Inscription_Ligne.Models.Niveau", b =>
                {
                    b.HasOne("Inscription_Ligne.Models.Etablissement", null)
                        .WithMany("Niveaus")
                        .HasForeignKey("EtablissementIdEtablissment");
                });
#pragma warning restore 612, 618
        }
    }
}
