using System;
using System.Collections.Generic;
using club_ia_website.Models;
using Microsoft.EntityFrameworkCore;

namespace club_ia_website.Data;

public partial class HotelDbContext : DbContext
{
    public HotelDbContext()
    {
    }

    public HotelDbContext(DbContextOptions<HotelDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Avi> Avis { get; set; }

    public virtual DbSet<Comite> Comites { get; set; }

    public virtual DbSet<Contribution> Contributions { get; set; }

    public virtual DbSet<Cotisation> Cotisations { get; set; }

    public virtual DbSet<Evenement> Evenements { get; set; }

    public virtual DbSet<Formation> Formations { get; set; }

    public virtual DbSet<Galerie> Galeries { get; set; }

    public virtual DbSet<Inscriptionsformation> Inscriptionsformations { get; set; }

    public virtual DbSet<Membre> Membres { get; set; }

    public virtual DbSet<Projet> Projets { get; set; }

    public virtual DbSet<Ressource> Ressources { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CIA;Username=postgres;Password=Mkomegmbdysdia4");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("pgcrypto");

        modelBuilder.Entity<Avi>(entity =>
        {
            entity.HasKey(e => e.IdAvis).HasName("avis_pkey");

            entity.ToTable("avis");

            entity.Property(e => e.IdAvis).HasColumnName("id_avis");
            entity.Property(e => e.Commentaire).HasColumnName("commentaire");
            entity.Property(e => e.IdEvenement).HasColumnName("id_evenement");
            entity.Property(e => e.IdMembre).HasColumnName("id_membre");
            entity.Property(e => e.Note).HasColumnName("note");

            entity.HasOne(d => d.IdEvenementNavigation).WithMany(p => p.Avis)
                .HasForeignKey(d => d.IdEvenement)
                .HasConstraintName("avis_id_evenement_fkey");

            entity.HasOne(d => d.IdMembreNavigation).WithMany(p => p.Avis)
                .HasForeignKey(d => d.IdMembre)
                .HasConstraintName("avis_id_membre_fkey");
        });

        modelBuilder.Entity<Comite>(entity =>
        {
            entity.HasKey(e => e.IdComite).HasName("comites_pkey");

            entity.ToTable("comites");

            entity.Property(e => e.IdComite).HasColumnName("id_comite");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.NomComite)
                .HasMaxLength(100)
                .HasColumnName("nom_comite");
        });

        modelBuilder.Entity<Contribution>(entity =>
        {
            entity.HasKey(e => e.IdContribution).HasName("contributions_pkey");

            entity.ToTable("contributions");

            entity.Property(e => e.IdContribution).HasColumnName("id_contribution");
            entity.Property(e => e.DateContribution)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_contribution");
            entity.Property(e => e.IdMembre).HasColumnName("id_membre");
            entity.Property(e => e.IdProjet).HasColumnName("id_projet");
            entity.Property(e => e.RoleDansProjet)
                .HasMaxLength(100)
                .HasColumnName("role_dans_projet");

            entity.HasOne(d => d.IdMembreNavigation).WithMany(p => p.Contributions)
                .HasForeignKey(d => d.IdMembre)
                .HasConstraintName("contributions_id_membre_fkey");

            entity.HasOne(d => d.IdProjetNavigation).WithMany(p => p.Contributions)
                .HasForeignKey(d => d.IdProjet)
                .HasConstraintName("contributions_id_projet_fkey");
        });

        modelBuilder.Entity<Cotisation>(entity =>
        {
            entity.HasKey(e => e.IdCotisation).HasName("cotisations_pkey");

            entity.ToTable("cotisations");

            entity.Property(e => e.IdCotisation).HasColumnName("id_cotisation");
            entity.Property(e => e.DatePaiement)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_paiement");
            entity.Property(e => e.IdMembre).HasColumnName("id_membre");
            entity.Property(e => e.Montant)
                .HasPrecision(10, 2)
                .HasColumnName("montant");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");

            entity.HasOne(d => d.IdMembreNavigation).WithMany(p => p.Cotisations)
                .HasForeignKey(d => d.IdMembre)
                .HasConstraintName("cotisations_id_membre_fkey");
        });

        modelBuilder.Entity<Evenement>(entity =>
        {
            entity.HasKey(e => e.IdEvenement).HasName("evenements_pkey");

            entity.ToTable("evenements");

            entity.HasIndex(e => e.DateEvenement, "idx_evenements_date");

            entity.Property(e => e.IdEvenement).HasColumnName("id_evenement");
            entity.Property(e => e.DateEvenement)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_evenement");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdComite).HasColumnName("id_comite");
            entity.Property(e => e.Lieu)
                .HasMaxLength(255)
                .HasColumnName("lieu");
            entity.Property(e => e.Titre)
                .HasMaxLength(100)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdComiteNavigation).WithMany(p => p.Evenements)
                .HasForeignKey(d => d.IdComite)
                .HasConstraintName("evenements_id_comite_fkey");
        });

        modelBuilder.Entity<Formation>(entity =>
        {
            entity.HasKey(e => e.IdFormation).HasName("formations_pkey");

            entity.ToTable("formations");

            entity.HasIndex(e => e.Titre, "idx_formation_titre");

            entity.Property(e => e.IdFormation).HasColumnName("id_formation");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duree).HasColumnName("duree");
            entity.Property(e => e.IdComite).HasColumnName("id_comite");
            entity.Property(e => e.Prix)
                .HasPrecision(10, 2)
                .HasColumnName("prix");
            entity.Property(e => e.Titre)
                .HasMaxLength(100)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdComiteNavigation).WithMany(p => p.Formations)
                .HasForeignKey(d => d.IdComite)
                .HasConstraintName("formations_id_comite_fkey");
        });

        modelBuilder.Entity<Galerie>(entity =>
        {
            entity.HasKey(e => e.IdImage).HasName("galerie_pkey");

            entity.ToTable("galerie");

            entity.Property(e => e.IdImage).HasColumnName("id_image");
            entity.Property(e => e.CheminImage).HasColumnName("chemin_image");
            entity.Property(e => e.IdEvenement).HasColumnName("id_evenement");
            entity.Property(e => e.IdProjet).HasColumnName("id_projet");

            entity.HasOne(d => d.IdEvenementNavigation).WithMany(p => p.Galeries)
                .HasForeignKey(d => d.IdEvenement)
                .HasConstraintName("galerie_id_evenement_fkey");

            entity.HasOne(d => d.IdProjetNavigation).WithMany(p => p.Galeries)
                .HasForeignKey(d => d.IdProjet)
                .HasConstraintName("galerie_id_projet_fkey");
        });

        modelBuilder.Entity<Inscriptionsformation>(entity =>
        {
            entity.HasKey(e => e.IdInscription).HasName("inscriptionsformation_pkey");

            entity.ToTable("inscriptionsformation");

            entity.Property(e => e.IdInscription).HasColumnName("id_inscription");
            entity.Property(e => e.DateInscription)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_inscription");
            entity.Property(e => e.IdFormation).HasColumnName("id_formation");
            entity.Property(e => e.IdMembre).HasColumnName("id_membre");
            entity.Property(e => e.Statut)
                .HasMaxLength(50)
                .HasColumnName("statut");

            entity.HasOne(d => d.IdFormationNavigation).WithMany(p => p.Inscriptionsformations)
                .HasForeignKey(d => d.IdFormation)
                .HasConstraintName("inscriptionsformation_id_formation_fkey");

            entity.HasOne(d => d.IdMembreNavigation).WithMany(p => p.Inscriptionsformations)
                .HasForeignKey(d => d.IdMembre)
                .HasConstraintName("inscriptionsformation_id_membre_fkey");
        });

        modelBuilder.Entity<Membre>(entity =>
        {
            entity.HasKey(e => e.IdMembre).HasName("membres_pkey");

            entity.ToTable("membres");

            entity.HasIndex(e => e.Email, "idx_membres_email");

            entity.HasIndex(e => e.Email, "membres_email_key").IsUnique();

            entity.Property(e => e.IdMembre).HasColumnName("id_membre");
            entity.Property(e => e.DateInscription)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_inscription");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IdComites).HasColumnName("id_comites");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.MotDePasse).HasColumnName("mot_de_passe");
            entity.Property(e => e.Nom)
                .HasMaxLength(100)
                .HasColumnName("nom");
            entity.Property(e => e.PhotoProfil).HasColumnName("photo_profil");
            entity.Property(e => e.Prenom)
                .HasMaxLength(100)
                .HasColumnName("prenom");

            entity.HasOne(d => d.IdComitesNavigation).WithMany(p => p.Membres)
                .HasForeignKey(d => d.IdComites)
                .HasConstraintName("membres_id_comites_fkey");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Membres)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("membres_id_role_fkey");
        });

        modelBuilder.Entity<Projet>(entity =>
        {
            entity.HasKey(e => e.IdProjet).HasName("projets_pkey");

            entity.ToTable("projets");

            entity.HasIndex(e => e.Statut, "idx_projets_statut");

            entity.Property(e => e.IdProjet).HasColumnName("id_projet");
            entity.Property(e => e.DateDebut)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_debut");
            entity.Property(e => e.DateFin)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_fin");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdComite).HasColumnName("id_comite");
            entity.Property(e => e.Statut)
                .HasMaxLength(50)
                .HasColumnName("statut");
            entity.Property(e => e.Titre)
                .HasMaxLength(100)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdComiteNavigation).WithMany(p => p.Projets)
                .HasForeignKey(d => d.IdComite)
                .HasConstraintName("projets_id_comite_fkey");
        });

        modelBuilder.Entity<Ressource>(entity =>
        {
            entity.HasKey(e => e.IdRessource).HasName("ressources_pkey");

            entity.ToTable("ressources");

            entity.Property(e => e.IdRessource).HasColumnName("id_ressource");
            entity.Property(e => e.IdComite).HasColumnName("id_comite");
            entity.Property(e => e.LienRessource).HasColumnName("lien_ressource");
            entity.Property(e => e.Titre)
                .HasMaxLength(100)
                .HasColumnName("titre");
            entity.Property(e => e.TypeRessource)
                .HasMaxLength(50)
                .HasColumnName("type_ressource");

            entity.HasOne(d => d.IdComiteNavigation).WithMany(p => p.Ressources)
                .HasForeignKey(d => d.IdComite)
                .HasConstraintName("ressources_id_comite_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.NomRole)
                .HasMaxLength(100)
                .HasColumnName("nom_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
