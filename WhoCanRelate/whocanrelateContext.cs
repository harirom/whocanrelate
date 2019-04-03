using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WhoCanRelate
{
    public partial class whocanrelateContext : DbContext
    {
        public whocanrelateContext()
        {
        }

        public whocanrelateContext(DbContextOptions<whocanrelateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlogContent> BlogContent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server = tcp:harirom.database.windows.net, 1433; Initial Catalog = whocanrelate; Persist Security Info = False; User ID =harirom; Password =Mysqlserver@2712; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogContent>(entity =>
            {
                entity.ToTable("blog_content");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnName("author")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Anonymous')");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body ");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });
        }
    }
}
