using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThiKhanhLy_424
{
    [Table("Sinhviens")]
    public class Sinhvien 
    {
        
        [Key]
        public string? Masinhvien { get; set; }

        public int Tensinhvien { get; set; }

        public string? MaLop { get; set; }

        [ForeignKey("MaLop")]  
        public Lophoc? Lophoc {get;set;}

    }
}