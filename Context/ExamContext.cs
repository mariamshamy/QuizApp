using System.Net.Sockets;
using MariamRefaatExamProject.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MariamRefaatExamProject.Context
{
    public class ExamContext:DbContext
    {
        public virtual  DbSet<Exam> exams { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public DbSet<ExamQuestions> ExamQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source=MARIAM-REFAAT-E\\SQLEXPRESS;Initial Catalog=ExamForm;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
             optionsBuilder.UseSqlServer("workstation id = ExamFormDB.mssql.somee.com; packet size = 4096; user id = MariamElshamy_SQLLogin_2; pwd = 45hblsqopr; data source = ExamFormDB.mssql.somee.com; persist security info = False; initial catalog = ExamFormDB; TrustServerCertificate = True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamQuestions>().HasKey(eq => new { eq.ExamId, eq.QuestionId }); // مفتاح مركّب

            modelBuilder.Entity<ExamQuestions>()
                .HasOne(eq => eq.Exam)
                .WithMany(e => e.examQuestions)
                .HasForeignKey(eq => eq.ExamId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ExamQuestions>()
                .HasOne(eq => eq.Question)
                .WithMany(q => q.examQuestions)
                .HasForeignKey(eq => eq.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
