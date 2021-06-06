using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Tranthilananh_05.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
