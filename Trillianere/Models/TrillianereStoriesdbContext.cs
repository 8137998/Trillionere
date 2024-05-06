using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Trillianere.Models;

public partial class TrillianereStoriesdbContext : DbContext
{
    public TrillianereStoriesdbContext()
    {
    }

    public TrillianereStoriesdbContext(DbContextOptions<TrillianereStoriesdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Story> Stories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-3VNJEIO\\SQLEXPRESS01; Database=trillianereStoriesdb; User Id=sa; Password=ray1@3; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Story>(entity =>
        {
            entity.HasKey(e => e.StoryId).HasName("PK__stories__176D4ABFD5BA3243");

            entity.ToTable("stories");

            entity.Property(e => e.StoryId).HasColumnName("storyID");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ImageAltText)
                .IsUnicode(false)
                .HasColumnName("imageAltText");
            entity.Property(e => e.ImageId)
                .IsUnicode(false)
                .HasColumnName("imageID");
            entity.Property(e => e.ImageRedirectUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("imageRedirectUrl");
            entity.Property(e => e.PostDate)
                .HasColumnType("date")
                .HasColumnName("postDate");
            entity.Property(e => e.Title)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
