using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tranthilananh_05.Models
{
    [Table("Sinhviens")]
    public class SinhVien
    {
        [Key]
        [StringLength(20)]
        public string Masinhvien { get; set; }
        [StringLength(50)]
        public string Tensinhvien { get; set; }
        public int Malop { get; set; }
        public ICollection<LopHoc> LopHocs { get; set; }
    }
}