using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class CapstoneProjectRegisterContext : DbContext
    {
        public CapstoneProjectRegisterContext()
        {
        }

        public CapstoneProjectRegisterContext(DbContextOptions<CapstoneProjectRegisterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<Lecturer> Lecturers { get; set; } = null!;
        public virtual DbSet<Semester> Semesters { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentInGroup> StudentInGroups { get; set; } = null!;
        public virtual DbSet<StudentInSemester> StudentInSemesters { get; set; } = null!;
        public virtual DbSet<Topic> Topics { get; set; } = null!;
        public virtual DbSet<TopicOfLecturer> TopicOfLecturers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(e => e.TopicId, "UQ__Groups__022E0F5C7A4B8015")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK__Groups__Semester__440B1D61");

                entity.HasOne(d => d.Topic)
                    .WithOne(p => p.Group)
                    .HasForeignKey<Group>(d => d.TopicId)
                    .HasConstraintName("FK__Groups__TopicId__44FF419A");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable("Lecturer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("Semester");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Semesters)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK__Semester__TopicI__3A81B327");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Credit)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fee)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Projected)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentInGroup>(entity =>
            {
                entity.ToTable("StudentInGroup");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.StudentInGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK__StudentIn__Group__48CFD27E");

                entity.HasOne(d => d.StudentInSemester)
                    .WithMany(p => p.StudentInGroups)
                    .HasForeignKey(d => d.StudentInSemesterId)
                    .HasConstraintName("FK__StudentIn__Stude__47DBAE45");
            });

            modelBuilder.Entity<StudentInSemester>(entity =>
            {
                entity.ToTable("StudentInSemester");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Condition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.StudentInSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK__StudentIn__Semes__3F466844");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentInSemesters)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudentIn__Stude__403A8C7D");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TopicOfLecturer>(entity =>
            {
                entity.ToTable("TopicOfLecturer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Lecture)
                    .WithMany(p => p.TopicOfLecturers)
                    .HasForeignKey(d => d.LectureId)
                    .HasConstraintName("FK__TopicOfLe__Lectu__4CA06362");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TopicOfLecturers)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK__TopicOfLe__Topic__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
