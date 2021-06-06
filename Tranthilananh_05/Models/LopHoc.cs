using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tranthilananh_05.Models
{
    [Table("LopHocs")]
    public class LopHoc
    {
        [Key]
        public int Malop { get; set; }

        [StringLength(50)]
        public string Tenlop { get; set; }
    }
}