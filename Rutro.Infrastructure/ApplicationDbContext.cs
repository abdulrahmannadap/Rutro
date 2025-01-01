using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rutro.Domain.Entity;

namespace Rutro.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contect>(entity =>
        {
            entity.ToTable("Contect");

            entity.HasKey(c => c.ContId);

            entity.Property(c => c.ContPhone)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // ContPhone as NVARCHAR(MAX)
                  .HasColumnName("ContPhone");

            entity.Property(c => c.ContGmail)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // ContGmail as NVARCHAR(MAX)
                  .HasColumnName("ContGmail");

            entity.Property(c => c.ContAddress)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // ContAddress as NVARCHAR(MAX)
                  .HasColumnName("ContAddress");

            entity.Property(c => c.ContDesignation)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // ContDesignation as NVARCHAR(MAX)
                  .HasColumnName("ContDesignation");

            entity.Property(c => c.ContSynopsis)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // ContSynopsis as NVARCHAR(MAX)
                  .HasColumnName("ContSynopsis");
        });

        modelBuilder.Entity<AcademicCredential>(entity =>
        {
            entity.ToTable("AcademicCredential");

            entity.HasKey(a => a.AcdId);

            entity.Property(a => a.AcdType)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // AcdType as NVARCHAR(MAX)
                  .HasColumnName("AcdType");

            entity.Property(a => a.AcdStartingYear)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // AcdStartingYear as NVARCHAR(MAX)
                  .HasColumnName("AcdStartingYear");

            entity.Property(a => a.AcdEndYear)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // AcdEndYear as NVARCHAR(MAX)
                  .HasColumnName("AcdEndYear");

            entity.Property(a => a.AcdPercentage)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // AcdPercentage as NVARCHAR(MAX)
                  .HasColumnName("AcdPercentage");

            entity.Property(a => a.AcdAddress)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // AcdAddress as NVARCHAR(MAX)
                  .HasColumnName("AcdAddress");
        });

        modelBuilder.Entity<PersonalDetail>(entity =>
        {
            entity.ToTable("PersonalDetail");

            entity.HasKey(p => p.PerId);

            entity.Property(p => p.FullName)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // FullName as NVARCHAR(MAX)
                  .HasColumnName("FullName");

            entity.Property(p => p.FatherName)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // FatherName as NVARCHAR(MAX)
                  .HasColumnName("FatherName");

            entity.Property(p => p.DateofBirth)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // DateofBirth as NVARCHAR(MAX)
                  .HasColumnName("DateofBirth");

            entity.Property(p => p.PlaceofBirth)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // PlaceofBirth as NVARCHAR(MAX)
                  .HasColumnName("PlaceofBirth");
        });

        modelBuilder.Entity<ProfessionalExperience>(entity =>
        {
            entity.ToTable("ProfessionalExperience");

            entity.HasKey(p => p.ProexId);

            entity.Property(p => p.CompanyName)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // CompanyName as NVARCHAR(MAX)
                  .HasColumnName("CompanyName");

            entity.Property(p => p.Designation)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // Designation as NVARCHAR(MAX)
                  .HasColumnName("Designation");

            entity.Property(p => p.Duration)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // Duration as NVARCHAR(MAX)
                  .HasColumnName("Duration");

            entity.Property(p => p.Project)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // Project as NVARCHAR(MAX)
                  .HasColumnName("Project");

            entity.Property(p => p.Technologies)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // Technologies as NVARCHAR(MAX)
                  .HasColumnName("Technologies");

            entity.Property(p => p.ProjectDescription)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // ProjectDescription as NVARCHAR(MAX)
                  .HasColumnName("ProjectDescription");

            entity.Property(p => p.ProjectResponsibilities)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // ProjectResponsibilities as NVARCHAR(MAX)
                  .HasColumnName("ProjectResponsibilities");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill");

            entity.HasKey(s => s.SkiId);

            entity.Property(s => s.SkiName)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // SkiName as NVARCHAR(MAX)
                  .HasColumnName("SkiName");

            entity.Property(s => s.SkiStype)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // SkiStype as NVARCHAR(MAX)
                  .HasColumnName("SkiStype");
        });

        modelBuilder.Entity<SocialMadia>(entity =>
        {
            entity.ToTable("SocialMadia");

            entity.HasKey(s => s.SocmId);

            entity.Property(s => s.GitHub)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // GitHub as NVARCHAR(MAX)
                  .HasColumnName("GitHub");

            entity.Property(s => s.Linkedin)
                  .IsRequired(false) // Nullable
                  .HasColumnType("NVARCHAR(MAX)") // Linkedin as NVARCHAR(MAX)
                  .HasColumnName("Linkedin");
        });
    }




}
