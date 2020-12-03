using Microsoft.EntityFrameworkCore.Migrations;

namespace Inscription_Ligne.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etablissements",
                columns: table => new
                {
                    IdEtablissment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Etablissment = table.Column<string>(nullable: true),
                    Code_Etablissment = table.Column<int>(nullable: false),
                    Localité_Etablissment = table.Column<string>(nullable: true),
                    Email_Etablissment = table.Column<string>(nullable: true),
                    Attestation_Etablissment = table.Column<string>(nullable: true),
                    Type_Etablissment = table.Column<string>(nullable: true),
                    Enseignement_Etablissment = table.Column<int>(nullable: false),
                    Statut_Etablissment = table.Column<string>(nullable: true),
                    Scolarité_Etablissment = table.Column<int>(nullable: false),
                    IdNiveau = table.Column<int>(nullable: false),
                    IdEleve = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissements", x => x.IdEtablissment);
                });

            migrationBuilder.CreateTable(
                name: "Eleves",
                columns: table => new
                {
                    MyProperty = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Eleve = table.Column<string>(nullable: true),
                    Prenom_Eleve = table.Column<string>(nullable: true),
                    Matricule_Eleve = table.Column<int>(nullable: false),
                    Classe_Eleve = table.Column<string>(nullable: true),
                    Email_Parent = table.Column<string>(nullable: true),
                    Contact_Parent = table.Column<int>(nullable: false),
                    Extrait_naissance = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Etablissement = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EtablissementIdEtablissment = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleves", x => x.MyProperty);
                    table.ForeignKey(
                        name: "FK_Eleves_Etablissements_EtablissementIdEtablissment",
                        column: x => x.EtablissementIdEtablissment,
                        principalTable: "Etablissements",
                        principalColumn: "IdEtablissment",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Niveaus",
                columns: table => new
                {
                    IdNiveau = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Niveau = table.Column<string>(nullable: true),
                    Montant_Affecte = table.Column<string>(nullable: true),
                    Montant_NonAffecte = table.Column<string>(nullable: true),
                    EtablissementIdEtablissment = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveaus", x => x.IdNiveau);
                    table.ForeignKey(
                        name: "FK_Niveaus_Etablissements_EtablissementIdEtablissment",
                        column: x => x.EtablissementIdEtablissment,
                        principalTable: "Etablissements",
                        principalColumn: "IdEtablissment",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eleves_EtablissementIdEtablissment",
                table: "Eleves",
                column: "EtablissementIdEtablissment");

            migrationBuilder.CreateIndex(
                name: "IX_Niveaus_EtablissementIdEtablissment",
                table: "Niveaus",
                column: "EtablissementIdEtablissment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eleves");

            migrationBuilder.DropTable(
                name: "Niveaus");

            migrationBuilder.DropTable(
                name: "Etablissements");
        }
    }
}
