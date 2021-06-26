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
                optionsBuilder.UseSqlServer("server = localhost\\SQLEXPRESS; Database = PROYECTOF; Trusted_Connection = True; ");
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
                    .HasName("PK__CITIZEN__D876F1BEF1BD8CDB");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__idCabin__4BAC3F29");

                entity.HasOne(d => d.IdIdentifierNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdIdentifier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__idIdent__4D94879B");

                entity.HasOne(d => d.IdVaccinationPNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdVaccinationP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__idVacci__4CA06362");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASES");

                entity.Property(e => e.Id)
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
                    .HasConstraintName("FK__DISEASES__idCiti__59FA5E80");
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
                    .HasConstraintName("FK__EFFECTS__idProce__5165187F");
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
                    .HasConstraintName("FK__MANAGER__idTypeE__46E78A0C");
            });

            modelBuilder.Entity<Managerxregistration>(entity =>
            {
                entity.HasKey(e => new { e.IdManager, e.IdRecord })
                    .HasName("PK__MANAGERX__D9F35F2DDD4600D6");

                entity.ToTable("MANAGERXREGISTRATION");

                entity.Property(e => e.IdManager).HasColumnName("idManager");

                entity.Property(e => e.IdRecord).HasColumnName("idRecord");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Managerxregistrations)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGERXR__idMan__48CFD27E");

                entity.HasOne(d => d.IdRecordNavigation)
                    .WithMany(p => p.Managerxregistrations)
                    .HasForeignKey(d => d.IdRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGERXR__idRec__49C3F6B7");
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
                    .HasConstraintName("FK__REGISTRAT__idCab__4AB81AF0");
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

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("place");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
