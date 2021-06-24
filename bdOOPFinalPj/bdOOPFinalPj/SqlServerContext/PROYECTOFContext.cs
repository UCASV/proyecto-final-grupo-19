using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class PROYECTOFContext : DbContext
    {
        public PROYECTOFContext()
        {
        }

        public PROYECTOFContext(DbContextOptions<PROYECTOFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Effect> Effects { get; set; }
        public virtual DbSet<Identifier> Identifiers { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Managerxregistration> Managerxregistrations { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<TypeOfEmployee> TypeOfEmployees { get; set; }
        public virtual DbSet<VaccinationProcess> VaccinationProcesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=PROYECTOF;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("addres");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.NameManager)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nameManager");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__D876F1BE7AEFB5D8");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Addres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("addres");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.IdCabin).HasColumnName("idCabin");

                entity.Property(e => e.IdIdentifier).HasColumnName("idIdentifier");

                entity.Property(e => e.IdVaccinationP).HasColumnName("idVaccinationP");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.NameCitizen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nameCitizen");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdCabin)
                    .HasConstraintName("FK__CITIZEN__idCabin__71D1E811");

                entity.HasOne(d => d.IdIdentifierNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdIdentifier)
                    .HasConstraintName("FK__CITIZEN__idIdent__73BA3083");

                entity.HasOne(d => d.IdVaccinationPNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdVaccinationP)
                    .HasConstraintName("FK__CITIZEN__idVacci__72C60C4A");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASES");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Diseases)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("diseases");

                entity.Property(e => e.IdCitizen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idCitizen");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Diseases)
                    .HasForeignKey(d => d.IdCitizen)
                    .HasConstraintName("FK__DISEASES__idCiti__74AE54BC");
            });

            modelBuilder.Entity<Effect>(entity =>
            {
                entity.ToTable("EFFECTS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdProcess).HasColumnName("idProcess");

                entity.Property(e => e.SideEffects)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sideEffects");

                entity.HasOne(d => d.IdProcessNavigation)
                    .WithMany(p => p.Effects)
                    .HasForeignKey(d => d.IdProcess)
                    .HasConstraintName("FK__EFFECTS__idProce__75A278F5");
            });

            modelBuilder.Entity<Identifier>(entity =>
            {
                entity.ToTable("IDENTIFIER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Identifier1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identifier");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("MANAGER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("addres");

                entity.Property(e => e.IdTypeEmployed).HasColumnName("idTypeEmployed");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.NameUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nameUser");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("passwordUser");

                entity.Property(e => e.Username)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdTypeEmployedNavigation)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.IdTypeEmployed)
                    .HasConstraintName("FK__MANAGER__idTypeE__6D0D32F4");
            });

            modelBuilder.Entity<Managerxregistration>(entity =>
            {
                entity.HasKey(e => new { e.IdManager, e.IdRecord })
                    .HasName("PK__MANAGERX__D9F35F2DF0C93F54");

                entity.ToTable("MANAGERXREGISTRATION");

                entity.Property(e => e.IdManager).HasColumnName("idManager");

                entity.Property(e => e.IdRecord).HasColumnName("idRecord");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Managerxregistrations)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGERXR__idMan__6EF57B66");

                entity.HasOne(d => d.IdRecordNavigation)
                    .WithMany(p => p.Managerxregistrations)
                    .HasForeignKey(d => d.IdRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGERXR__idRec__6FE99F9F");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("REGISTRATION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateHour)
                    .HasColumnType("datetime")
                    .HasColumnName("dateHour");

                entity.Property(e => e.IdCabin).HasColumnName("idCabin");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.IdCabin)
                    .HasConstraintName("FK__REGISTRAT__idCab__70DDC3D8");
            });

            modelBuilder.Entity<TypeOfEmployee>(entity =>
            {
                entity.ToTable("TYPE_OF_EMPLOYEES");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TypeEmployed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeEmployed");
            });

            modelBuilder.Entity<VaccinationProcess>(entity =>
            {
                entity.ToTable("VACCINATION_PROCESS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateHourStart)
                    .HasColumnType("datetime")
                    .HasColumnName("dateHourStart");

                entity.Property(e => e.DateHourVaccinated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateHourVaccinated");

                entity.Property(e => e.DateHourVaccination)
                    .HasColumnType("datetime")
                    .HasColumnName("dateHourVaccination");

                entity.Property(e => e.NumberMinutes).HasColumnName("numberMinutes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
