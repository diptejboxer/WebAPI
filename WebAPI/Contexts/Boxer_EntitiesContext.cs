using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Contexts
{
    public partial class Boxer_EntitiesContext : DbContext
    {
        public Boxer_EntitiesContext()
        {
        }

        public Boxer_EntitiesContext(DbContextOptions<Boxer_EntitiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EntityFile> EntityFile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Servername;Database=DBName;User Id=Uname; Password=Pass;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityFile>(entity =>
            {
                entity.ToTable("ENTITY_FILE");

                entity.Property(e => e.EntityFileId).HasColumnName("ENTITY_FILE_ID");

                entity.Property(e => e.CheckedOutToSam)
                    .HasColumnName("CHECKED_OUT_TO_SAM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDatetime)
                    .HasColumnName("CREATED_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.ExternalUri)
                    .HasColumnName("EXTERNAL_URI")
                    .HasMaxLength(1000);

                entity.Property(e => e.FileBlob)
                    .HasColumnName("FILE_BLOB")
                    .HasColumnType("image");

                entity.Property(e => e.FileDateTime)
                    .HasColumnName("FILE_DATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.FileSizeBytes).HasColumnName("FILE_SIZE_BYTES");

                entity.Property(e => e.FileVersion).HasColumnName("FILE_VERSION");

                entity.Property(e => e.IndexLanguageId).HasColumnName("INDEX_LANGUAGE_ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastIndexAttemptDatetime)
                    .HasColumnName("LAST_INDEX_ATTEMPT_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastIndexAttempts).HasColumnName("LAST_INDEX_ATTEMPTS");

                entity.Property(e => e.LastIndexSuccess)
                    .IsRequired()
                    .HasColumnName("LAST_INDEX_SUCCESS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MigratedPath)
                    .HasColumnName("MIGRATED_PATH")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDatetime)
                    .HasColumnName("MODIFIED_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShowInlineNotes)
                    .IsRequired()
                    .HasColumnName("SHOW_INLINE_NOTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SystemCode)
                    .HasColumnName("SYSTEM_CODE")
                    .HasMaxLength(5)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
